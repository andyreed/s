using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIBlend.WinForms.Controls;

namespace Hydro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public object  createNewTabPage(){

            vTabPage TabPage = new vTabPage();
            vRichTextBox RichTextBox = new vRichTextBox();

            RichTextBox.Dock = DockStyle.Fill;
            RichTextBox.BackColor = Color.Silver;
            TabPage.Text = "New Page ";
            TabPage.Controls.Add(RichTextBox);
            return TabPage;
        }
        private void createNewFile_Click(object sender, EventArgs e)
        {
            this.tabList.TabPages.Add(createNewTabPage());
        }

        private void createNewFile_ts_Click(object sender, EventArgs e)
        {
            tabList.TabPages.Add(createNewTabPage());
        }

        private void programSettings_Click(object sender, EventArgs e)
        {
            SettingsForm SettingsForm = new SettingsForm();
            SettingsForm.Show();
        }
    }
}
