using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmSystem.DAL
{
    public class ExcleHelper
    {
        public bool ExportDataToExcel(DataTable dt, string FileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出excel文件";
            saveFileDialog.Filter = "Excel 工作簿(*.xlsx)|*.xlsx|Excel 97-2003 工作簿(*xls)|*.xls";

            saveFileDialog.FilterIndex = 1;

            //自动添加扩展名
            saveFileDialog.AddExtension = true;
            //记忆上次打开的目录
            saveFileDialog.RestoreDirectory = true;
            //设置默认名称
            saveFileDialog.FileName = FileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取文件路径
                string localFilePath = saveFileDialog.FileName.ToString();

                     

                IWorkbook workbook;
                //获取文件扩展名
                string FileExt = Path.GetExtension(localFilePath).ToLower();


                //确定导出excel版本
                ICellStyle headerStyle;
                ICellStyle cellStyle;
                IDataFormat dataFormat;
                IFont font;
                if (FileExt == ".xlsx")
                {
                    workbook = new XSSFWorkbook();
                    headerStyle = (XSSFCellStyle)workbook.CreateCellStyle();
                    cellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
                    dataFormat = (XSSFDataFormat)workbook.CreateDataFormat();
                    font = workbook.CreateFont();

                }
                else if (FileExt == ".xls")
                {
                    workbook = new HSSFWorkbook();
                    headerStyle = (HSSFCellStyle)workbook.CreateCellStyle();
                    cellStyle = (HSSFCellStyle)workbook.CreateCellStyle();
                    dataFormat = (HSSFDataFormat)workbook.CreateDataFormat();
                    font = workbook.CreateFont();
                }
                else
                {
                    workbook = null;
                    return false;
                }
                //创建一个Sheet页,括号内为工作簿名称
                ISheet sheet =
                    string.IsNullOrEmpty(FileName) ? workbook.CreateSheet("Sheet1") : workbook.CreateSheet(FileName);

                sheet.SetColumnWidth(2, 15 * 265);
                //设置单元格格式            
                try
                {
                    //读取标题,设置标题相关属性
                    IRow rowHeader = sheet.CreateRow(0);
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        ICell cell = rowHeader.CreateCell(i-1);

                        font.Boldweight = (short)FontBoldWeight.BOLD;
                        headerStyle.SetFont(font);
                        headerStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER;
                        cell.CellStyle = headerStyle;

                        cell.SetCellValue(dt. Columns[i].ColumnName);                                         
                    }


                    //读取数据
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        IRow rowData = sheet.CreateRow(i + 1);
                        for (int j = 1; j < dt.Columns.Count; j++)
                        {
                            ICell cell = rowData.CreateCell(j-1);
                            if (j == 3)
                            {
                                cellStyle.DataFormat = dataFormat.GetFormat("yyyy年MM月dd日");
                                cell.CellStyle = cellStyle;
                                cell.SetCellValue((DateTime)dt.Rows[i][j]);
                            }
                            else
                            {
                                cell.SetCellValue(dt.Rows[i][j].ToString());
                            }                                                             
                            
                        }
                    }

                    //转换成字节数组
                    MemoryStream stream = new MemoryStream();
                    workbook.Write(stream);
                    var buf = stream.ToArray();
                    using (FileStream fs = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(buf, 0, buf.Length);
                        fs.Flush();
                        fs.Close();

                    }
                    return true;
                }
                catch (Exception )
                {
                    return false;
                }               
            }
            return false;
        }
    }
}

