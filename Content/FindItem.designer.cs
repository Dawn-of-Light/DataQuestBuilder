namespace DataQuestBuilder.Content
{
    partial class FindItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectCollect = new System.Windows.Forms.Button();
            this.SelectStep = new System.Windows.Forms.Button();
            this.SelectOption = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SelectFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_nb,
            this.Model,
            this.Level,
            this.Realm});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(416, 505);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Id_nb
            // 
            this.Id_nb.HeaderText = "Id_nb";
            this.Id_nb.Name = "Id_nb";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            // 
            // Realm
            // 
            this.Realm.HeaderText = "Realm";
            this.Realm.Name = "Realm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SelectCollect);
            this.panel1.Controls.Add(this.SelectStep);
            this.panel1.Controls.Add(this.SelectOption);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.SelectFinish);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(416, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 505);
            this.panel1.TabIndex = 1;
            // 
            // SelectCollect
            // 
            this.SelectCollect.Location = new System.Drawing.Point(156, 458);
            this.SelectCollect.Name = "SelectCollect";
            this.SelectCollect.Size = new System.Drawing.Size(132, 23);
            this.SelectCollect.TabIndex = 4;
            this.SelectCollect.Text = "Select Collect Item";
            this.SelectCollect.UseVisualStyleBackColor = true;
            this.SelectCollect.Click += new System.EventHandler(this.SelectCollect_Click);
            // 
            // SelectStep
            // 
            this.SelectStep.Location = new System.Drawing.Point(156, 429);
            this.SelectStep.Name = "SelectStep";
            this.SelectStep.Size = new System.Drawing.Size(132, 23);
            this.SelectStep.TabIndex = 3;
            this.SelectStep.Text = "Select Step Item";
            this.SelectStep.UseVisualStyleBackColor = true;
            this.SelectStep.Click += new System.EventHandler(this.SelectStep_Click);
            // 
            // SelectOption
            // 
            this.SelectOption.Location = new System.Drawing.Point(22, 429);
            this.SelectOption.Name = "SelectOption";
            this.SelectOption.Size = new System.Drawing.Size(92, 23);
            this.SelectOption.TabIndex = 2;
            this.SelectOption.Text = "Select Option";
            this.SelectOption.UseVisualStyleBackColor = true;
            this.SelectOption.Click += new System.EventHandler(this.SelectOption_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(22, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(266, 411);
            this.webBrowser1.TabIndex = 1;
            // 
            // SelectFinish
            // 
            this.SelectFinish.Location = new System.Drawing.Point(22, 458);
            this.SelectFinish.Name = "SelectFinish";
            this.SelectFinish.Size = new System.Drawing.Size(92, 23);
            this.SelectFinish.TabIndex = 0;
            this.SelectFinish.Text = "Select Finish";
            this.SelectFinish.UseVisualStyleBackColor = true;
            this.SelectFinish.Click += new System.EventHandler(this.SelectFinish_Click);
            // 
            // FindItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindItem";
            this.ShowIcon = false;
            this.Text = "Find Item";
            this.Load += new System.EventHandler(this.FindItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelectFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Realm;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button SelectOption;
        private System.Windows.Forms.Button SelectCollect;
        private System.Windows.Forms.Button SelectStep;
    }
}