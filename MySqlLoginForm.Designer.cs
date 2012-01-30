namespace DataQuestBuilder
{
    partial class MySqlLoginForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.secondaryColor = new System.Windows.Forms.Button();
            this.primaryColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tooltipTime = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.mySqlLoginControl = new DataQuestBuilder.Content.MySqlLoginControl();
            this.mySqlLoginControl1 = new DataQuestBuilder.Controls.MySqlLoginForm();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.secondaryColor);
            this.groupBox1.Controls.Add(this.primaryColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tooltipTime);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Options:";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(126, 185);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 28);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // secondaryColor
            // 
            this.secondaryColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondaryColor.Location = new System.Drawing.Point(201, 93);
            this.secondaryColor.Name = "secondaryColor";
            this.secondaryColor.Size = new System.Drawing.Size(26, 23);
            this.secondaryColor.TabIndex = 5;
            this.secondaryColor.UseVisualStyleBackColor = false;
            this.secondaryColor.Click += new System.EventHandler(this.secondaryColor_Click);
            // 
            // primaryColor
            // 
            this.primaryColor.Location = new System.Drawing.Point(201, 64);
            this.primaryColor.Name = "primaryColor";
            this.primaryColor.Size = new System.Drawing.Size(26, 23);
            this.primaryColor.TabIndex = 4;
            this.primaryColor.UseVisualStyleBackColor = true;
            this.primaryColor.Click += new System.EventHandler(this.primaryColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Secondary Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primary Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tooltip Duration (Seconds)";
            // 
            // tooltipTime
            // 
            this.tooltipTime.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooltipTime.Location = new System.Drawing.Point(201, 34);
            this.tooltipTime.Name = "tooltipTime";
            this.tooltipTime.Size = new System.Drawing.Size(27, 26);
            this.tooltipTime.TabIndex = 0;
            this.tooltipTime.Text = "3";
            this.tooltipTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mySqlLoginControl
            // 
            this.mySqlLoginControl.Location = new System.Drawing.Point(14, 9);
            this.mySqlLoginControl.Name = "mySqlLoginControl";
            this.mySqlLoginControl.Size = new System.Drawing.Size(205, 224);
            this.mySqlLoginControl.TabIndex = 2;
            this.mySqlLoginControl.Load += new System.EventHandler(this.mySqlLoginControl_Load);
            // 
            // mySqlLoginControl1
            // 
            this.mySqlLoginControl1.Location = new System.Drawing.Point(12, 12);
            this.mySqlLoginControl1.Name = "mySqlLoginControl1";
            this.mySqlLoginControl1.Size = new System.Drawing.Size(205, 224);
            this.mySqlLoginControl1.TabIndex = 0;
            // 
            // MySqlLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 245);
            this.Controls.Add(this.mySqlLoginControl);
            this.Controls.Add(this.groupBox1);
            this.Name = "MySqlLoginForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MySqlLoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MySqlLoginForm mySqlLoginControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button secondaryColor;
        private System.Windows.Forms.Button primaryColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tooltipTime;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button saveButton;
        private Content.MySqlLoginControl mySqlLoginControl;
    }
}