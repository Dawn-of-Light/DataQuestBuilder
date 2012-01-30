using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DataQuestBuilder
{
    public partial class MySqlLoginForm : Form
    {
        public MySqlLoginForm()
        {
            InitializeComponent();
        }
        private void primaryColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            primaryColor.BackColor = colorDialog.Color;
            Properties.Settings.Default.PrimaryColor = colorDialog.Color;
        }

        private void secondaryColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            secondaryColor.BackColor = colorDialog.Color;
            Properties.Settings.Default.SecondaryColor = colorDialog.Color;
        }

        private void mySqlLoginControl1_Load(object sender, EventArgs e)
        {

        }

        private void MySqlLoginForm_Load(object sender, EventArgs e)
        {
            tooltipTime.TextChanged += new EventHandler(CheckTooltipDuration);
            primaryColor.BackColor = Properties.Settings.Default.PrimaryColor;
            secondaryColor.BackColor = Properties.Settings.Default.SecondaryColor;
            tooltipTime.Text = Properties.Settings.Default.TooltipDuration;
        }

        void CheckTooltipDuration(object sender, EventArgs e)
        {
            foreach (char c in tooltipTime.Text)
            {
                if (!char.IsNumber(c))
                {
                    tooltipTime.Text = "3";
                }
            }

            int def = 3;

            if (int.TryParse(tooltipTime.Text, out def))
            {
                if (def > 10)
                tooltipTime.Text = "3";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            ToolTip tooltip = new ToolTip();
            tooltip.ToolTipTitle = "Successful";
            tooltip.Show("Options Saved Successfully!", saveButton, 3000);
            tooltip.IsBalloon = true;

       
        }

        private void mySqlLoginControl_Load(object sender, EventArgs e)
        {

        }

        private void eStepType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
