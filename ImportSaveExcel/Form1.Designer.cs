using System.Data;

namespace ImportSaveExcel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoad = new Button();
            txtExcelLoad = new RichTextBox();
            panel1 = new Panel();
            txtLocation = new TextBox();
            btnResult = new Button();
            txtResult = new RichTextBox();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            tabExcelLayout = new TabControl();
            tabPage1 = new TabPage();
            dataGridView10 = new DataGridView();
            dataGridView9 = new DataGridView();
            dataGridView8 = new DataGridView();
            dataGridView7 = new DataGridView();
            dataGridView6 = new DataGridView();
            dataGridView5 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView1 = new DataGridView();
            btnResultClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            tabExcelLayout.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(608, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(87, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "불러오기";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // txtExcelLoad
            // 
            txtExcelLoad.BackColor = SystemColors.Window;
            txtExcelLoad.Location = new Point(25, 14);
            txtExcelLoad.Name = "txtExcelLoad";
            txtExcelLoad.Size = new Size(569, 23);
            txtExcelLoad.TabIndex = 2;
            txtExcelLoad.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnResultClose);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(txtExcelLoad);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 76);
            panel1.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(25, 43);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(109, 23);
            txtLocation.TabIndex = 4;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(698, 14);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(87, 23);
            btnResult.TabIndex = 3;
            btnResult.Text = "결과창";
            btnResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(240, 105);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(63, 27);
            txtResult.TabIndex = 5;
            txtResult.Text = "";
            txtResult.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Window;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(54, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(45, 31);
            dataGridView2.TabIndex = 1;
            dataGridView2.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabExcelLayout);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(827, 390);
            panel2.TabIndex = 5;
            // 
            // tabExcelLayout
            // 
            tabExcelLayout.Controls.Add(tabPage1);
            tabExcelLayout.Dock = DockStyle.Fill;
            tabExcelLayout.Location = new Point(10, 10);
            tabExcelLayout.Name = "tabExcelLayout";
            tabExcelLayout.SelectedIndex = 0;
            tabExcelLayout.Size = new Size(807, 370);
            tabExcelLayout.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtResult);
            tabPage1.Controls.Add(dataGridView10);
            tabPage1.Controls.Add(dataGridView9);
            tabPage1.Controls.Add(dataGridView8);
            tabPage1.Controls.Add(dataGridView7);
            tabPage1.Controls.Add(dataGridView6);
            tabPage1.Controls.Add(dataGridView5);
            tabPage1.Controls.Add(dataGridView4);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 342);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            dataGridView10.BackgroundColor = SystemColors.Window;
            dataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView10.Location = new Point(462, 3);
            dataGridView10.Name = "dataGridView10";
            dataGridView10.Size = new Size(45, 31);
            dataGridView10.TabIndex = 9;
            dataGridView10.Visible = false;
            // 
            // dataGridView9
            // 
            dataGridView9.BackgroundColor = SystemColors.Window;
            dataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView9.Location = new Point(411, 3);
            dataGridView9.Name = "dataGridView9";
            dataGridView9.Size = new Size(45, 31);
            dataGridView9.TabIndex = 8;
            dataGridView9.Visible = false;
            // 
            // dataGridView8
            // 
            dataGridView8.BackgroundColor = SystemColors.Window;
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(360, 3);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.Size = new Size(45, 31);
            dataGridView8.TabIndex = 7;
            dataGridView8.Visible = false;
            // 
            // dataGridView7
            // 
            dataGridView7.BackgroundColor = SystemColors.Window;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(309, 3);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.Size = new Size(45, 31);
            dataGridView7.TabIndex = 6;
            dataGridView7.Visible = false;
            // 
            // dataGridView6
            // 
            dataGridView6.BackgroundColor = SystemColors.Window;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(258, 3);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(45, 31);
            dataGridView6.TabIndex = 5;
            dataGridView6.Visible = false;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = SystemColors.Window;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(207, 3);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(45, 31);
            dataGridView5.TabIndex = 4;
            dataGridView5.Visible = false;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.Window;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(156, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(45, 31);
            dataGridView4.TabIndex = 3;
            dataGridView4.Visible = false;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.Window;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(105, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(45, 31);
            dataGridView3.TabIndex = 2;
            dataGridView3.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(45, 31);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            // 
            // btnResultClose
            // 
            btnResultClose.Location = new Point(698, 43);
            btnResultClose.Name = "btnResultClose";
            btnResultClose.Size = new Size(87, 23);
            btnResultClose.TabIndex = 5;
            btnResultClose.Text = "결과창 닫기";
            btnResultClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 466);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            tabExcelLayout.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        //private void InitializeComponentDataGridView(DataSet ds)
        //{
        //    for (int i = 0; i < ds.Tables.Count; i++)
        //    {
        //        _dataGridViewArray[i] = new DataGridView();
        //        ((System.ComponentModel.ISupportInitialize)_dataGridViewArray[i]).BeginInit();
        //        _dataGridViewArray[i].ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //        _dataGridViewArray[i].Location = new Point(381, 95);
        //        _dataGridViewArray[i].Name = "dataGridView" + Convert.ToString(i);
        //        _dataGridViewArray[i].Size = new Size(240, 150);
        //        _dataGridViewArray[i].TabIndex = 6 + i;
        //        _dataGridViewArray[i].Dock = DockStyle.Fill;
        //        _dataGridViewArray[i].BackgroundColor = SystemColors.Window;
        //        _dataGridViewArray[i].RowHeadersVisible = false;
        //        //grd.ColumnHeadersVisible = true;
        //        _dataGridViewArray[i].AllowUserToAddRows = false;
        //        ((System.ComponentModel.ISupportInitialize)_dataGridViewArray[i]).EndInit();
        //    }
        //}

        #endregion
        private Button btnLoad;
        private RichTextBox txtExcelLoad;
        private Panel panel1;
        private Button btnResult;
        private TextBox txtLocation;
        private Panel panel2;
        private RichTextBox txtResult;
        private TabControl tabExcelLayout;
        private TabPage tabPage1;
        //private DataGridView[] _dataGridViewArray;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView10;
        private DataGridView dataGridView9;
        private DataGridView dataGridView8;
        private DataGridView dataGridView7;
        private DataGridView dataGridView6;
        private DataGridView dataGridView5;
        private DataGridView dataGridView4;
        private DataGridView dataGridView3;
        private Button btnResultClose;
    }
}
