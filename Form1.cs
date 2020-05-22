using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZJSoft.DbHelper.DataAccess;


namespace DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            label2.Visible = true;
            label2.Text = "查询中...";
            try
            {
                //         BaseAccess dbhelper = BaseAccess.CreateDataBase();
                //         DataTable dt= dbhelper.GetDataTable("".AsSQLQuery() + "select Top 1 * from WMS_SYS_USERS");
                //if (dt != null
                //    && dt.Rows != null
                //    && dt.Rows.Count > 0)
                //{
                //    MessageBox.Show("成功！");
                BaseAccess dbhelper = BaseAccess.CreateDataBase();
                DataTable dt = dbhelper.GetDataTable("".AsSQLQuery() + "select  * from view_Loc_needcheck ");
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;

                    label2.Text = "" + (dataGridView1.Rows.Count - 1).ToString() + "条";
                }


                else
                {
                    MessageBox.Show("未获取到数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常" + ex.Message);
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Visible = true;
          
            BaseAccess dbhelper = BaseAccess.CreateDataBase();
            //DataTable dt1 = dbhelper.GetDataTable("".AsSQLQuery() + " select '' as'完成日期', '' as'完成月份', '' as'时间段', '' as' 数量'");
            //dataGridView2.DataSource = dt1;
           
           
            try
            {

                //  BaseAccess dbhelper = BaseAccess.CreateDataBase();
                DataTable dt = dbhelper.GetDataTable("".AsSQLQuery() + "select CompletedDate as 完成日期,CompletedMonth as 完成月份,CompletedHour as 时间段,OutCount as 数量 from View_HourPickInfo where CompletedDate between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'order by CompletedDate,CompletedHour");
                if (dt != null)
                {
                    dataGridView2.DataSource = dt;
                    label3.Text =""+ (dataGridView2.Rows.Count-1).ToString()+"小时";
                }


                else
                {
                    MessageBox.Show("未获取到数据！");
                }
                double j = 0;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {

                    j+= Convert.ToDouble(dataGridView2.Rows[i].Cells["数量"].Value) ;
                    
                    //rowtemp.CreateCell(1).SetCellValue(dgv.Rows[i].Cells["Capital_assets_Name_G"].Value.ToString());
                    //rowtemp.CreateCell(2).SetCellValue(dgv.Rows[i].Cells["Capital_assets_Code_G"].Value.ToString());
                    //rowtemp.CreateCell(3).SetCellValue(dgv.Rows[i].Cells["Capital_assets_Model_G"].Value.ToString());

                }
                label4.Visible = true;
                label4.Text ="总计:"+j.ToString()+"种";

            }
            catch (Exception ex)
            {
                MessageBox.Show("异常" + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ToExcel(dataGridView1);
            ExportDataToExcel(dataGridView1);
        }
        public void ToExcel(DataGridView dataGridViewx)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl   files   (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "请选择位置";

            DateTime now = DateTime.Now;
            saveFileDialog.FileName = now.Year.ToString().PadLeft(2)
            + now.Month.ToString().PadLeft(2, '0')
            + now.Day.ToString().PadLeft(2, '0') + "-"
            + now.Hour.ToString().PadLeft(2, '0')
            + now.Minute.ToString().PadLeft(2, '0')
            + now.Second.ToString().PadLeft(2, '0');
            saveFileDialog.ShowDialog();
            saveFileDialog.ShowDialog();

            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            string str = "";
            try
            {
                //写标题     
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dataGridView1.Columns[i].HeaderText;
                }

                sw.WriteLine(str);
                //写内容   
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        tempStr += dataGridView1.Rows[j].Cells[k].Value.ToString();
                    }
                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
        public void ExportDataToExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Title = "请选择要导出的位置";
            saveFileDialog2.Filter = "Excel文件| *.xls";
            DateTime now = DateTime.Now;
            saveFileDialog2.FileName ="抽盘位置统计"+now.Year.ToString().PadLeft(2)
           + now.Month.ToString().PadLeft(2, '0')
           + now.Day.ToString().PadLeft(2, '0')
           + now.Hour.ToString().PadLeft(2, '0')
            +now.Minute.ToString().PadLeft(2, '0');
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {

                if (saveFileDialog2.FileName != "")
                {
                    //创建Excel文件的对象
                    NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                    //添加一个sheet
                    NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("Sheet1");
                    //获取list数据
                    //List<TB_STUDENTINFOModel> listRainInfo = m_BLL.GetSchoolListAATQ(schoolname);

                    //  DataTable listRainInfo = mymssqlConnet.DAL_SelectDT_Par("EnrollmentGroup", mySqlParameters);
                    //给sheet1添加第一行的头部标题

                    NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
                    //row1.CreateCell(0).SetCellValue("编码");
                    //row1.CreateCell(1).SetCellValue("名称");
                    //row1.CreateCell(3).SetCellValue("型号");
                  
                    row1.CreateCell(0).SetCellValue("位置");
                    for (int i = 0,j=1; i < dgv.Rows.Count-1; i++,j++)
                    {
                        NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(j);
                        rowtemp.CreateCell(0).SetCellValue(dgv.Rows[i].Cells["位置"].Value.ToString());
                        //rowtemp.CreateCell(1).SetCellValue(dgv.Rows[i].Cells["Capital_assets_Name_G"].Value.ToString());
                        //rowtemp.CreateCell(2).SetCellValue(dgv.Rows[i].Cells["Capital_assets_Code_G"].Value.ToString());
                        //rowtemp.CreateCell(3).SetCellValue(dgv.Rows[i].Cells["Capital_assets_Model_G"].Value.ToString());

                    }

                    FileStream ms = File.OpenWrite(saveFileDialog2.FileName.ToString());
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
        public void ExportDataToExce2(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "请选择要导出的位置";
            saveFileDialog1.Filter = "Excel文件| *.xls";
            DateTime now = DateTime.Now;
            saveFileDialog1.FileName ="二楼出库量统计"+ now.Year.ToString().PadLeft(2)
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
                    //获取list数据
                    //List<TB_STUDENTINFOModel> listRainInfo = m_BLL.GetSchoolListAATQ(schoolname);

                    //  DataTable listRainInfo = mymssqlConnet.DAL_SelectDT_Par("EnrollmentGroup", mySqlParameters);
                    //给sheet1添加第一行的头部标题

                    NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
                    row1.CreateCell(0).SetCellValue("完成日期");
                    row1.CreateCell(1).SetCellValue("完成月份");
                    row1.CreateCell(2).SetCellValue("时间段");
                    row1.CreateCell(3).SetCellValue("数量");
                    for (int i = 0,j=1; i < dgv.Rows.Count - 1; i++,j++)
                    {
                        NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(j);
                        rowtemp.CreateCell(0).SetCellValue(dgv.Rows[i].Cells["完成日期"].Value.ToString());
                        rowtemp.CreateCell(1).SetCellValue(dgv.Rows[i].Cells["完成月份"].Value.ToString());
                        rowtemp.CreateCell(2).SetCellValue(dgv.Rows[i].Cells["时间段"].Value.ToString());
                        rowtemp.CreateCell(3).SetCellValue(dgv.Rows[i].Cells["数量"].Value.ToString());

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

        private void button3_Click(object sender, EventArgs e)
        {
            ExportDataToExce2(dataGridView2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dateTimePicker2.Text = DateTime.Now.ToString();


        }
    }
    
}
