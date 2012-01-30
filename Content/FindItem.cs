using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOL.Database;
using DataQuestBuilder.Properties;

namespace DataQuestBuilder.Content
{
    public partial class FindItem : Form
    {
        public FindItem()
        {
           InitializeComponent();
        }
        
        private void FindItem_Load(object sender, EventArgs e)
        {
           var i = DatabaseManager.Database.SelectAllObjects<ItemTemplate>();
           foreach (ItemTemplate m in i)
           {
               dataGridView1.Rows.Add(m.Id_nb, m.Model, m.Level, m.Realm);
           }
        }

        private void SelectOption_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectOption = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void SelectFinish_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectFinish = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void SelectStep_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectStepItem = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void SelectCollect_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectCollectItem = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                //http://herald.uthgard-server.net/daoc/list.php?img=items-%3E38 Items are not prefixed with 00's
                string model = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                webBrowser1.Navigate("http://herald.uthgard-server.net/daoc/list.php?img=items-%3E" + model);
            }
            catch { }
        }
    }
}
