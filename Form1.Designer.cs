namespace SomeQuizLikeApp
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
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.lblPictureBox = new System.Windows.Forms.Label();
            this.lblDropdown = new System.Windows.Forms.Label();
            this.comboBoxCountrySelect = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNextFlag = new System.Windows.Forms.Button();
            this.lblAnswerField = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Location = new System.Drawing.Point(70, 72);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(271, 189);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlag.TabIndex = 0;
            this.pictureBoxFlag.TabStop = false;
            // 
            // lblPictureBox
            // 
            this.lblPictureBox.AutoSize = true;
            this.lblPictureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureBox.Location = new System.Drawing.Point(67, 43);
            this.lblPictureBox.Name = "lblPictureBox";
            this.lblPictureBox.Size = new System.Drawing.Size(47, 24);
            this.lblPictureBox.TabIndex = 1;
            this.lblPictureBox.Text = "Flag";
            // 
            // lblDropdown
            // 
            this.lblDropdown.AutoSize = true;
            this.lblDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropdown.Location = new System.Drawing.Point(412, 72);
            this.lblDropdown.Name = "lblDropdown";
            this.lblDropdown.Size = new System.Drawing.Size(203, 24);
            this.lblDropdown.TabIndex = 2;
            this.lblDropdown.Text = "Please select a country";
            // 
            // comboBoxCountrySelect
            // 
            this.comboBoxCountrySelect.FormattingEnabled = true;
            this.comboBoxCountrySelect.Items.AddRange(new object[] {
            "Australia",
            "Gernany",
            "Italy",
            "Japan",
            "South Africa",
            "United States"});
            this.comboBoxCountrySelect.Location = new System.Drawing.Point(416, 138);
            this.comboBoxCountrySelect.Name = "comboBoxCountrySelect";
            this.comboBoxCountrySelect.Size = new System.Drawing.Size(199, 21);
            this.comboBoxCountrySelect.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(665, 72);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 53);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNextFlag
            // 
            this.btnNextFlag.Location = new System.Drawing.Point(665, 171);
            this.btnNextFlag.Name = "btnNextFlag";
            this.btnNextFlag.Size = new System.Drawing.Size(112, 53);
            this.btnNextFlag.TabIndex = 5;
            this.btnNextFlag.Text = "Next Flag";
            this.btnNextFlag.UseVisualStyleBackColor = true;
            // 
            // lblAnswerField
            // 
            this.lblAnswerField.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswerField.Location = new System.Drawing.Point(416, 190);
            this.lblAnswerField.Name = "lblAnswerField";
            this.lblAnswerField.Size = new System.Drawing.Size(199, 47);
            this.lblAnswerField.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.lblAnswerField);
            this.Controls.Add(this.btnNextFlag);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBoxCountrySelect);
            this.Controls.Add(this.lblDropdown);
            this.Controls.Add(this.lblPictureBox);
            this.Controls.Add(this.pictureBoxFlag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Label lblPictureBox;
        private System.Windows.Forms.Label lblDropdown;
        private System.Windows.Forms.ComboBox comboBoxCountrySelect;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNextFlag;
        private System.Windows.Forms.Label lblAnswerField;
    }
}

