
namespace ElegoraDeskTop.PL
{
    partial class FRM_ADD_BACKUP
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "رجاء قم بتحديد مسار حفظ النسخة الاحتياطية";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(119, 80);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFileName.Size = new System.Drawing.Size(466, 20);
            this.txtFileName.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(180, 134);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreate.Size = new System.Drawing.Size(198, 34);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "إنشاء النسخة الاحتياطية";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(388, 134);
            this.l.Margin = new System.Windows.Forms.Padding(4);
            this.l.Name = "l";
            this.l.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l.Size = new System.Drawing.Size(112, 34);
            this.l.TabIndex = 11;
            this.l.Text = "إلغاء";
            this.l.UseVisualStyleBackColor = true;
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(593, 80);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBrowse.Size = new System.Drawing.Size(112, 26);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FRM_ADD_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(753, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.l);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADD_BACKUP";
            this.Text = "FRM_ADD_BACKUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}