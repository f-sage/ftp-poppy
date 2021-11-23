using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftp_poppy_server
{
    public partial class GroupForm : Form
    {
        MainForm mainForm;
        public GroupForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            //if item empty
            if (mainForm.cmbGroup.SelectedItem.ToString() == "")
            {
                this.Text = "Нова група";
            }
            //if not empty
            else
            {
                this.Text = "Редагувати групу";

                GroupPreset group = mainForm.loadedGroups.groups.
                      Single(x => x.GroupName == mainForm.cmbGroup.SelectedItem.ToString());
                tbGroupName.Text = group.GroupName;
                tbGroupDir.Text = group.GroupDirectory;
            }
        }

        private void btnGroupDir_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbGroupDir.Text))
                fbdGroupDir.SelectedPath = tbGroupDir.Text;
            if (fbdGroupDir.ShowDialog() == DialogResult.OK)
            {
                tbGroupDir.Text = fbdGroupDir.SelectedPath;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //check directory for existence
            if (!Directory.Exists(tbGroupDir.Text))
            {
                MessageBox.Show("Директорії не існує");
                return;
            }
            //add to list
            //if item empty
            if (mainForm.cmbGroup.SelectedItem.ToString() == "")
            {
                GroupPreset group = new GroupPreset();
                group.GroupName = tbGroupName.Text;
                group.GroupDirectory = tbGroupDir.Text;
                mainForm.loadedGroups.groups.Add(group);
            }
            //if not empty
            else
            {
                GroupPreset group = mainForm.loadedGroups.groups.
                       Single(x=>x.GroupName==mainForm.cmbGroup.SelectedItem);
                group.GroupName = tbGroupName.Text;
                group.GroupDirectory = tbGroupDir.Text;
            }
            mainForm.cmbGroupsUpdate();
            mainForm.loadedGroupsUpdate();
            this.Close();
        }
    }
}
