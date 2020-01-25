namespace CreateCaps
{
    partial class Form1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.picField = new System.Windows.Forms.PictureBox();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picField)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenFile.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(586, 716);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(138, 32);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(586, 556);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(138, 62);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // picField
            // 
            this.picField.BackColor = System.Drawing.Color.White;
            this.picField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picField.Location = new System.Drawing.Point(129, 58);
            this.picField.Margin = new System.Windows.Forms.Padding(5);
            this.picField.Name = "picField";
            this.picField.Size = new System.Drawing.Size(595, 389);
            this.picField.TabIndex = 2;
            this.picField.TabStop = false;
            // 
            // txtCreate
            // 
            this.txtCreate.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCreate.Location = new System.Drawing.Point(129, 494);
            this.txtCreate.Multiline = true;
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(391, 178);
            this.txtCreate.TabIndex = 3;
            this.txtCreate.Tag = "";
            this.txtCreate.Text = "Write Your Caption";
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtOpenFile.Location = new System.Drawing.Point(129, 719);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Size = new System.Drawing.Size(391, 29);
            this.txtOpenFile.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(586, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 62);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFont.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(586, 639);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(138, 33);
            this.btnFont.TabIndex = 9;
            this.btnFont.Text = "Change Font";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(863, 776);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOpenFile);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.picField);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Caps";
            ((System.ComponentModel.ISupportInitialize)(this.picField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox picField;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

