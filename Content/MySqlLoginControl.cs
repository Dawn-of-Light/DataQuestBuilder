using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataQuestBuilder.Content
{
    public class MySqlLoginControl : DataQuestBuilder.Controls.MySqlLoginForm
    {
        private Controls.MySqlLoginForm mySqlLoginForm1;
    
        private void InitializeComponent()
        {
            this.mySqlLoginForm1 = new DataQuestBuilder.Controls.MySqlLoginForm();
            this.SuspendLayout();
            // 
            // mySqlLoginForm1
            // 
            this.mySqlLoginForm1.Location = new System.Drawing.Point(0, 0);
            this.mySqlLoginForm1.Name = "mySqlLoginForm1";
            this.mySqlLoginForm1.Size = new System.Drawing.Size(205, 224);
            this.mySqlLoginForm1.TabIndex = 13;
            // 
            // MySqlLoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.mySqlLoginForm1);
            this.Name = "MySqlLoginControl";
            this.Controls.SetChildIndex(this.mySqlLoginForm1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
