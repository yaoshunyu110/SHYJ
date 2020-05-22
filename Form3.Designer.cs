namespace SHYJ_App
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonimport = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttontongji = new System.Windows.Forms.Button();
            this.buttonoutport = new System.Windows.Forms.Button();
            this.lvw = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.PageCondition = new ZJ_ECS_AppFrame.UseControls.ZJWinPageConditionBottom();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonimport
            // 
            this.buttonimport.Location = new System.Drawing.Point(25, 8);
            this.buttonimport.Name = "buttonimport";
            this.buttonimport.Size = new System.Drawing.Size(75, 23);
            this.buttonimport.TabIndex = 0;
            this.buttonimport.Text = "导入Excel文件";
            this.buttonimport.UseVisualStyleBackColor = true;
            this.buttonimport.Click += new System.EventHandler(this.buttonimport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttontongji);
            this.splitContainer1.Panel1.Controls.Add(this.buttonoutport);
            this.splitContainer1.Panel1.Controls.Add(this.buttonimport);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvw);
            this.splitContainer1.Panel2.Controls.Add(this.PageCondition);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttontongji
            // 
            this.buttontongji.Location = new System.Drawing.Point(161, 8);
            this.buttontongji.Name = "buttontongji";
            this.buttontongji.Size = new System.Drawing.Size(75, 23);
            this.buttontongji.TabIndex = 2;
            this.buttontongji.Text = "统计";
            this.buttontongji.UseVisualStyleBackColor = true;
            this.buttontongji.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonoutport
            // 
            this.buttonoutport.Location = new System.Drawing.Point(295, 8);
            this.buttonoutport.Name = "buttonoutport";
            this.buttonoutport.Size = new System.Drawing.Size(75, 23);
            this.buttonoutport.TabIndex = 1;
            this.buttonoutport.Text = "导出Excel文件";
            this.buttonoutport.UseVisualStyleBackColor = true;
            this.buttonoutport.Visible = false;
            this.buttonoutport.Click += new System.EventHandler(this.buttonoutport_Click);
            // 
            // lvw
            // 
            this.lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw.FullRowSelect = true;
            this.lvw.GridLines = true;
            this.lvw.Location = new System.Drawing.Point(0, 0);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(800, 373);
            this.lvw.SmallImageList = this.imageList2;
            this.lvw.TabIndex = 1;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.Details;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(20, 20);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PageCondition
            // 
            this.PageCondition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PageCondition.Location = new System.Drawing.Point(0, 373);
            this.PageCondition.Name = "PageCondition";
            this.PageCondition.PageSize = 1;
            this.PageCondition.Size = new System.Drawing.Size(800, 39);
            this.PageCondition.TabIndex = 0;
            this.PageCondition.TotalRows = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonimport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonoutport;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button buttontongji;
        private System.Windows.Forms.ListView lvw;
        private ZJ_ECS_AppFrame.UseControls.ZJWinPageConditionBottom PageCondition;
    }
}