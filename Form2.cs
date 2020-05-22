using DBTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZJ_ECS_AppFrame.Comm;
using ZJ_ECS_JLX_COS.Model;
using ZJSoft.DbHelper.DataAccess;

namespace SHYJ_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listView2.Columns.AddRange(new ColumnHeader[]
            {
               
                new ColumnHeader { Text="任务编号",Width=100},
                new ColumnHeader { Text="容器编号",Width=100},
                new ColumnHeader { Text="起始位置",Width=100},
                new ColumnHeader { Text="目标位置",Width=100},
                new ColumnHeader { Text="创建时间",Width=100},
                 new ColumnHeader { Text="修改人",Width=100},
                  new ColumnHeader { Text="修改时间",Width=100},
            });


        }
        public void Datalistview()
        {
            List<WMS_IO_Task> list = new List<WMS_IO_Task>();
            BaseAccess dbhelper = BaseAccess.CreateDataBase();

            string sql = "select  * from wms_IO_task where status=1 and tasktype='2' and binding_flag=3  and taskId='" + textBox2.Text + "'";
            list = dbhelper.GetList<WMS_IO_Task>("".AsSQLQuery() + sql);
            if (list.Count <= 0)
            {
                MessageBox.Show("未查询到该抽盘任务，请确认任务是否满足");
            }
            else
            {
                this.listView2.Items.Clear();
                if (list.Count > 0)
                {
                    Invoke(new Action(() =>
                   {
                       for (int i = 0; i < list.Count; i++)
                       {
                           ListViewItem item = new ListViewItem();
                           item.Tag = list[i];
                           item.Text = list[i].TaskId;
                           item.SubItems.Add(list[i].PalletNo);
                           item.SubItems.Add(list[i].SourceLoc);
                           item.SubItems.Add(list[i].TargetLoc);
                           item.SubItems.Add(list[i].CratedTime);
                           item.SubItems.Add(list[i].EditUser);
                           item.SubItems.Add(list[i].EditTime);
                           listView2.Items.Add(item);
                       }

                   }));
                }
            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.TopLevel = false;
            form1.Parent = tabPage1;
            form1.Show();

            Form3 form3 = new Form3();
            form3.TopLevel = false;
            form3.Parent = tabPage4;
            form3.Dock = DockStyle.Fill;
            form3.Show();
  
           

            dateTimePicker1.Text = DateTime.Now.ToString();
            dateTimePicker2.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;

            dateTimePicker2.Value.AddDays(+1).ToString();
            if (textBox1.Text.Length > 17)
            {
                MessageBox.Show("请输入正确的订单号");
            }
            else
            {
                BaseAccess dbhelper = BaseAccess.CreateDataBase();
                DataTable dt = dbhelper.GetDataTable("".AsSQLQuery() + "select  TagInfo,Printtime  from  WMS_W_TagPrintLog where PrintResult=0 and TagInfo like '%出库%" + textBox1.Text + "%' and (Printtime >='" + dateTimePicker1.Text + "'and  Printtime<= '" + dateTimePicker2.Value.AddDays(+1).ToString() + "')");

                string[] a = new string[dt.Rows.Count];

                DataTable dt2 = new DataTable();
                dt2.Columns.Add(new DataColumn("合并订单号", typeof(string)));
                dt2.Columns.Add(new DataColumn("物料编码", typeof(string)));
                dt2.Columns.Add(new DataColumn("物料名称", typeof(string)));
                //   dt2.Columns.Add(new DataColumn("出库条码", typeof(string)));
                dt2.Columns.Add(new DataColumn("库区", typeof(string)));
                dt2.Columns.Add(new DataColumn("订单号", typeof(string)));
                dt2.Columns.Add(new DataColumn("出库条码", typeof(string)));
                dt2.Columns.Add(new DataColumn("打印时间", typeof(string)));

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    //  a[i] = dt.Rows[i][0].ToString();
                    string[] cc = dt.Rows[i][0].ToString().Split(new char[] { ':', ',' });
                    if (cc.Length == 62)
                    {
                        string c = cc[19].Substring(1, cc[19].Length - 2);
                        string b = cc[17].Substring(1, cc[17].Length - 2);
                        string d = cc[15].Substring(1, cc[15].Length - 2);

                        //string e1 = cc[13].Substring(1, cc[13].Length - 2);
                        string e2 = cc[39].Substring(1, cc[39].Length - 2);
                        string e3 = cc[21].Substring(1, cc[21].Length - 2);
                        string e4 = cc[7].Substring(1, cc[7].Length - 2);
                        string e5 = dt.Rows[i][1].ToString();
                        dt2.Rows.Add(c, b, d, e2, e3, e4, e5);
                    }
                    //if(cc.Length==57)
                    //{
                    //    string c = cc[17].Substring(1, cc[17].Length - 2);
                    //    string b = cc[15].Substring(1, cc[15].Length - 2);
                    //    string d = cc[13].Substring(1, cc[13].Length - 2);

                    //    //string e1 = cc[13].Substring(1, cc[13].Length - 2);
                    //    string e2 = cc[37].Substring(1, cc[37].Length - 2);
                    //    string e3 = cc[17].Substring(1, cc[17].Length - 2);
                    //    string e4 = cc[7].Substring(1, cc[7].Length - 2);
                    //    string e5 = dt.Rows[i][1].ToString();
                    //    dt2.Rows.Add(c, b, d, e2, e3, e4, e5);
                    //}
                    if (cc.Length == 56)
                    {
                        string c = cc[15].Substring(1, cc[15].Length - 2);
                        string b = cc[13].Substring(1, cc[13].Length - 2);
                        string d = cc[11].Substring(1, cc[11].Length - 2);

                        //string e1 = cc[13].Substring(1, cc[13].Length - 2);
                        string e2 = cc[35].Substring(1, cc[35].Length - 2);
                        string e3 = cc[17].Substring(1, cc[17].Length - 2);
                        string e4 = cc[7].Substring(1, cc[7].Length - 2);
                        string e5 = dt.Rows[i][1].ToString();
                        dt2.Rows.Add(c, b, d, e2, e3, e4, e5);
                    }

                }


                // string[] ss= a[0].Split(new char[] {':',',' });

                //dataGridView1.Rows[0].Cells[0].Value = ss[21];


                //  dt2.Rows.Add("dsadsad");
                dataGridView1.DataSource = dt2;
                dataGridView1.Columns["合并订单号"].Width = 130;
                dataGridView1.Columns["出库条码"].Width = 130;
                dataGridView1.Columns["打印时间"].Width = 130;
                label2.Text = "共" + dt2.Rows.Count.ToString() + "记录";

            }
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listView2.Items.Clear();
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入任务编号");
            }
            else
            {
                Datalistview();
                textBox2.Text = null;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if ((listView2.SelectedItems != null) && (listView2.SelectedItems.Count == 0))
            {
                MessageBox.Show("请选择要取消的任务");
            }
            else
            {
                BaseAccess dbhelper = BaseAccess.CreateDataBase();
                var entity = listView2.SelectedItems[0].Tag as WMS_IO_Task;
                entity.Status = "5";
                entity.EditUser = "程序";
                entity.Remark = "程序取消";
                entity.EditTime = System.DateTime.Now.ToString(CommFinal.TimeFormat);
                if(dbhelper.Update(entity)>0)
                {
                    //DataTable dt = dbhelper.GetDataTable("".AsSQLQuery() + "update wms_B_loc set status=2 where locnum="+entity.""

                   MessageBox.Show("取消成功");

                    listView2.Items.Clear();
                }
                else
                {
                    MessageBox.Show("请确认任务状态");
              
                }
              

            }
        }

     
    }
}
