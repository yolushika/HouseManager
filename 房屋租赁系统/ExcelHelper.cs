using System;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;
using MathNet.Numerics.LinearAlgebra.Factorization;


namespace 房屋租赁系统.DAL
{
    public class ExcelHelper
    {
        /// <summary>
        /// 导出 DataTable 数据到 Excel
        /// </summary>
        /// <param name="dt">数据源</param>
        /// <param name="sheetName">工作表名称（默认：Sheet1）</param>
        /// <param name="defaultFileName">默认文件名（不含扩展名，默认：导出数据_时间戳）</param>
        /// <param name="isXlsx">是否导出为 .xlsx 格式（true：.xlsx，false：.xls）</param>
        /// <returns>导出结果（true：成功，false：失败）</returns>
        public static bool ExportDataTable(DataTable dt, string sheetName = "sheet1",
            string defaultFileName = null, bool isXlsx = true)
        {
            try
            {
                if(dt==null||dt.Rows.Count==0) 
                {
                    MessageBox.Show("没有可导出的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; 
                }
                // 创建工作簿
                IWorkbook workbook=isXlsx?(IWorkbook)new XSSFWorkbook():new XSSFWorkbook();
                ISheet sheet =workbook.CreateSheet(string.IsNullOrEmpty(sheetName)?"sheet1":sheetName);

                // 写入表头
                IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ICell cell = headerRow.CreateCell(i);
                    cell.SetCellValue(dt.Columns[i].ColumnName);                    
                }

                // 写入数据行
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow dataRow = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        dataRow.CreateCell(j).SetCellValue(dt.Rows[i][j]?.ToString() ?? "");
                    }
                }
                return SaveWorkbook(workbook, defaultFileName, isXlsx);
            }
            catch 
            {
                MessageBox.Show("导出成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        /// <summary>
        /// 导出 DataGridView 中的数据到 Excel
        /// </summary>
        /// <param name="dgv">DataGridView 控件</param>
        /// <param name="sheetName">工作表名称</param>
        /// <param name="defaultFileName">默认文件名</param>
        /// <param name="isXlsx">是否导出为 .xlsx 格式</param>
        /// <returns>导出结果</returns>
        public static bool ExportDataGridView(DataGridView dgv, string sheetName = "sheet1",
            string defaultFileName = null, bool isXlsx = false)
        {
            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("没有可导出的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //把DataGridView转换为DataTable形式
            DataTable dt = new DataTable();

            // 添加表头（列名）
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible) // 只导出可见列
                {
                    dt.Columns.Add(col.HeaderText);
                }
            }

            //添加数据行
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // 排除新增行
                {
                    DataRow dataRow = dt.NewRow();
                    int colIndex = 0;
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        if (col.Visible)
                        {
                            dataRow[colIndex] = row.Cells[col.Index].Value?.ToString() ?? "";
                            colIndex++;
                        }
                    }
                    dt.Rows.Add(dataRow);
                }
            }
            // 调用 DataTable 导出方法
            return ExportDataTable(dt, sheetName, defaultFileName, isXlsx);
        }
        /// <summary>
        /// 保存工作簿到本地文件
        /// </summary>
        private static bool SaveWorkbook(IWorkbook workbook, string defaultFileName, bool isXlsx)
        {
            // 默认文件名（含时间戳，避免重复）
            string fileName = string.IsNullOrEmpty(defaultFileName)
                ? $"导出数据_{DateTime.Now:yyyyMMddHHmmss}"
                : defaultFileName;
            //判断默认文件名是否为空，为空则生成文件名
            string extension = isXlsx ? ".xlsx" : ".xls";

            // 打开保存对话框
            SaveFileDialog sfd = new SaveFileDialog();
            
            using (sfd)
            {
                sfd.Filter = $"{(isXlsx ? "Excel 2007+" : "Excel 97-2003")} 文件|*{extension}";
                sfd.FileName = fileName + extension;
                sfd.Title = "导出Excel文件";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return false; // 取消保存
                }
            }
            // 写入文件流
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
            using (fs)
            {
                workbook.Write(fs);
                fs.Flush();
            }
            MessageBox.Show($"导出成功！\n文件路径：\n{sfd.FileName}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
