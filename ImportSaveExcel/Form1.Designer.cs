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
            grdExcel = new DataGridView();
            btnLoad = new Button();
            txtExcelLoad = new RichTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)grdExcel).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grdExcel
            // 
            grdExcel.BackgroundColor = SystemColors.Window;
            grdExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdExcel.Dock = DockStyle.Fill;
            grdExcel.Location = new Point(0, 0);
            grdExcel.Margin = new Padding(10);
            grdExcel.Name = "grdExcel";
            grdExcel.Size = new Size(800, 450);
            grdExcel.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(663, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "불러오기";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // txtExcelLoad
            // 
            txtExcelLoad.BackColor = SystemColors.Window;
            txtExcelLoad.Location = new Point(25, 14);
            txtExcelLoad.Name = "txtExcelLoad";
            txtExcelLoad.Size = new Size(632, 23);
            txtExcelLoad.TabIndex = 2;
            txtExcelLoad.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtExcelLoad);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(grdExcel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grdExcel).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdExcel;
        private Button btnLoad;
        private RichTextBox txtExcelLoad;
        private Panel panel1;
        private Panel panel2;
    }
}
