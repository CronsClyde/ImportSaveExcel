namespace ImportSaveExcel
{
    partial class Form2
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            txtCustom = new RichTextBox();
            btnOk = new Button();
            btnCancle = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 417);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancle);
            panel3.Controls.Add(btnOk);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 374);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 43);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCustom);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(800, 374);
            panel2.TabIndex = 2;
            // 
            // txtCustom
            // 
            txtCustom.Dock = DockStyle.Fill;
            txtCustom.Location = new Point(10, 10);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(780, 354);
            txtCustom.TabIndex = 0;
            txtCustom.Text = "";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(627, 8);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "확인";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(713, 8);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(75, 23);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "취소";
            btnCancle.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RichTextBox txtCustom;
        private Panel panel3;
        private Button btnCancle;
        private Button btnOk;
    }
}