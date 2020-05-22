using SHYJ_App.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ZJ_ECS_JLX_COS.Model;
using ZJSoft.DbHelper.DataAccess;

namespace SHYJ_App
{
    public partial class Form3 : Form
    {

        BaseAccess dbhelper = BaseAccess.CreateDataBase();

        public Form3()
        {
            InitializeComponent();
        }

        public List<Excel> excels = new List<Excel>();
        public PageList<MaterialStatus> listTask = new PageList<MaterialStatus>();
        private void buttonimport_Click(object sender, EventArgs e)
        {
            PageCondition.Visible = false;
            lvw.Clear();

            string fileaddress;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "选择文件";
            openFile.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileaddress = openFile.FileName;

                DataTable dt = new DataTable();

                lvw.Clear();
                lvw.Items.Clear();
                string[] head = { "物料编号", "物料描述" };
                lvw.Columns.Add(new ColumnHeader { Text = "物料编号", Width = 100, TextAlign = HorizontalAlignment.Right });
                lvw.Columns.Add(new ColumnHeader { Text = "物料描述", Width = 100, TextAlign = HorizontalAlignment.Center });
                //dataGridView1.DataSource = null; //每次打开清空内容
                try
                {

                    dt = ReadExcelToTable(fileaddress).DefaultView.ToTable(true, head);
                }
                catch (Exception)
                {
                    MessageBox.Show("导入格式错误", "提示");
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem view = new ListViewItem(dt.Rows[i]["物料编号"].ToString());
                    if (!string.IsNullOrEmpty(dt.Rows[i]["物料编号"].ToString()))
                    {
                        excels.Add
                         (
                         new Excel
                         {
                             MaterialID = dt.Rows[i]["物料编号"].ToString(),

                         });
                    }


                    view.SubItems.Add(dt.Rows[i]["物料描述"].ToString());


                    lvw.Items.Add(view);
                }

            }

            int b = 0;

        }


        //根据excle的路径把第一个sheel中的内容放入datatable
        public static DataTable ReadExcelToTable(string path)//excel存放的路径
        {
            try
            {

                //连接字符串
                string connstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1';"; // Office 07及以上版本 不能出现多余的空格 而且分号注意
                                                                                                                                                  //string connstring = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + path + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1';"; //Office 07以下版本 
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    string firstSheetName;
                    conn.Open();
                    DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
                    if (sheetsName.Rows.Count == 1)
                    {
                        firstSheetName = sheetsName.Rows[0][2].ToString();  //得到第一个sheet的名字
                    }
                    else
                    {
                        firstSheetName = "按物料盘点导入模板$";
                    }

                    string sql = string.Format("SELECT * FROM [{0}] ", firstSheetName); //查询字符串                    //string sql = string.Format("SELECT * FROM [{0}] WHERE [日期] is not null", firstSheetName); //查询字符串
                    OleDbDataAdapter ada = new OleDbDataAdapter(sql, connstring);
                    DataSet set = new DataSet();
                    ada.Fill(set);
                    return set.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请检查文件格式", "提示");
                return null;
            }

        }
        public int page;
        private void button1_Click(object sender, EventArgs e)
        {

            PageCondition.Visible = true;

            BaseAccess dbhelper = BaseAccess.CreateDataBase();

            dbhelper.ExecuteNonQuerySQL("".AsSQLQuery() + "delete ZBO");


            if (dbhelper.Insert<Excel>(excels) > 0)
            {
                lvw.Clear();
                lvw.Items.Clear();
                lvw.Columns.AddRange(new ColumnHeader[] {

                new ColumnHeader { Text="物料编码",Width=100,TextAlign= HorizontalAlignment.Center},
                new ColumnHeader { Text="物料名称",Width=100,TextAlign= HorizontalAlignment.Center},
                new ColumnHeader { Text="在库数量",Width=100,TextAlign= HorizontalAlignment.Center},
                new ColumnHeader { Text="待验收数量",Width=100,TextAlign= HorizontalAlignment.Center},
                new ColumnHeader { Text="一次验收完成数量",Width=110,TextAlign= HorizontalAlignment.Center},
                new ColumnHeader { Text="二次验收完成数量",Width=110,TextAlign= HorizontalAlignment.Center},
                new ColumnHeader { Text="入库待处理数量",Width=110,TextAlign= HorizontalAlignment.Center},



            });

                PageCondition.PageSize = 50;
                PageCondition.SqlSort = "order by MaterialId";

                listTask = dbhelper.GetList<MaterialStatus>("".AsSQLQuery() + "select * from  View_ZBO", PageCondition.PageCondition);
                page = listTask.rows.Count();
                PageCondition.DataQuery(new Func<int>(() =>
                {
                    if (listTask != null && listTask.rows != null
                           && listTask.rows.Count > 0)
                    {
                        Invoke(new Action(() =>
                        {
                            lvw.Items.Clear();
                            for (int i = 0; i < listTask.rows.Count; i++)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Tag = listTask.rows[i];
                                item.Text = listTask.rows[i].MaterialId;

                                item.SubItems.Add(listTask.rows[i].MaterialName);
                                item.SubItems.Add(listTask.rows[i].AllQuantity);
                                item.SubItems.Add(listTask.rows[i].Checkquantity);
                                item.SubItems.Add(listTask.rows[i].FCheckquantity);
                                item.SubItems.Add(listTask.rows[i].SCheckquantity);
                                item.SubItems.Add(listTask.rows[i].Inquantity);
                                lvw.Items.Add(item);
                            }
                        }));
                    }
                    return (listTask == null ? 0 : listTask.total);
                }), true);

                

            }
            else
            {
                MessageBox.Show("请重试", "提示");
            }

            buttonoutport.Visible = true;

        }

        private void buttonoutport_Click(object sender, EventArgs e)
        {
            //BaseAccess dbhelper = BaseAccess.CreateDataBase();
            //DataGridView dataGrid = new DataGridView();
            //DataTable dt = new DataTable();
            //dt = dbhelper.GetDataTable("".AsSQLQuery() + "select * from  view_ZBO");

            //var list = dbhelper.GetList<MaterialStatus>("".AsSQLQuery() + "select * from view_ZBO");
            //dataGridView1.DataSource = dt;
            // ExportDataToExce();
            var alllist = dbhelper.GetList<MaterialStatus>("".AsSQLQuery() + "select * from View_ZBO");
            ExportToExecl(alllist);
        }
        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="dgv"></param>
        public void ExportToExecl(List<MaterialStatus> list)
        {
            if (list.Count == 0)
            {
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "请选择要导出的位置";
            saveFileDialog1.Filter = "Excel文件| *.xls";
            DateTime now = DateTime.Now;
            saveFileDialog1.FileName = "数量统计" + now.Year.ToString().PadLeft(2)
            + now.Month.ToString().PadLeft(2, '0')
            + now.Day.ToString().PadLeft(2, '0')
            + now.Hour.ToString().PadLeft(2, '0')
            + now.Minute.ToString().PadLeft(2, '0');

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if (saveFileDialog1.FileName != "")
                {
                    //创建Excel文件的对象
                    NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                    //添加一个sheet
                    NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("Sheet1");
                    sheet1.AutoSizeColumn(0);
                    sheet1.AutoSizeColumn(1);
                    sheet1.AutoSizeColumn(2);
                    sheet1.AutoSizeColumn(3);
                    sheet1.AutoSizeColumn(4);
                    sheet1.AutoSizeColumn(5);
                    sheet1.AutoSizeColumn(6);
                    //获取list数据
                    //List<TB_STUDENTINFOModel> listRainInfo = m_BLL.GetSchoolListAATQ(schoolname);

                    //  DataTable listRainInfo = mymssqlConnet.DAL_SelectDT_Par("EnrollmentGroup", mySqlParameters);
                    //给sheet1添加第一行的头部标题

                    NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
                    row1.CreateCell(0).SetCellValue("物料编码");
                    row1.CreateCell(1).SetCellValue("物料名称");
                    row1.CreateCell(2).SetCellValue("在库数量");
                    row1.CreateCell(3).SetCellValue("待验收数量");
                    row1.CreateCell(4).SetCellValue("一次验收完成数量");
                    row1.CreateCell(5).SetCellValue("二次验收完成数量（质检合格）");
                    row1.CreateCell(6).SetCellValue("入库待处理数量");
                    for (int i = 0, j = 1; i < list.Count - 1; i++, j++)
                    {

                        NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(j);
                        rowtemp.CreateCell(0).SetCellValue(list[i].MaterialId);
                        rowtemp.CreateCell(1).SetCellValue(list[i].MaterialName);
                        rowtemp.CreateCell(2).SetCellValue(list[i].AllQuantity);
                        rowtemp.CreateCell(3).SetCellValue(list[i].Checkquantity);
                        rowtemp.CreateCell(4).SetCellValue(list[i].FCheckquantity);
                        rowtemp.CreateCell(5).SetCellValue(list[i].SCheckquantity);
                        rowtemp.CreateCell(6).SetCellValue(list[i].Inquantity);
                    }

                    FileStream ms = File.OpenWrite(saveFileDialog1.FileName.ToString());
                    try
                    {

                        book.Write(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        MessageBox.Show("导出成功");
                        ms.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("导出失败!");
                    }



                }
            }
         
        }


        /// <summary>
        /// 具体导出的方法
        /// </summary>
        /// <param name="listView">ListView</param>
        /// <param name="strFileName">导出到的文件名</param>
        private void DoExport(ListView listView, string strFileName, int page)
        {
            int rowNum = listView.Items.Count;
            int columnNum = listView.Items[0].SubItems.Count;
            int rowIndex = 1;
            int columnIndex = 0;
            if (rowNum == 0 || string.IsNullOrEmpty(strFileName))
            {
                return;
            }
            if (rowNum > 0)
            {

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建excel对象，可能您的系统没有安装excel");
                    return;
                }
                xlApp.DefaultFilePath = "";
                xlApp.DisplayAlerts = true;
                xlApp.SheetsInNewWorkbook = 1;
                Microsoft.Office.Interop.Excel.Workbook xlBook = xlApp.Workbooks.Add(true);
                //将ListView的列名导入Excel表第一行
                foreach (ColumnHeader dc in listView.Columns)
                {
                    columnIndex++;
                    xlApp.Cells[rowIndex, columnIndex] = dc.Text;
                }
                //将ListView中的数据导入Excel中
                for (int k = 0; k < page; k++)
                {
                    //先选择页数，填充
                    for (int i = 0; i < rowNum; i++)
                    {
                        rowIndex++;
                        columnIndex = 0;
                        for (int j = 0; j < columnNum; j++)
                        {
                            columnIndex++;
                            //注意这个在导出的时候加了“\t” 的目的就是避免导出的数据显示为科学计数法。可以放在每行的首尾。
                            xlApp.Cells[rowIndex, columnIndex] = Convert.ToString(listView.Items[i].SubItems[j].Text) + "\t";
                        }
                    }
                }
                //例外需要说明的是用strFileName,Excel.XlFileFormat.xlExcel9795保存方式时 当你的Excel版本不是95、97 而是2003、2007 时导出的时候会报一个错误：异常来自 HRESULT:0x800A03EC。 解决办法就是换成strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal。
                xlBook.SaveAs(strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xlApp = null;
                xlBook = null;
                MessageBox.Show("OK");
            }
        }

    }


}

