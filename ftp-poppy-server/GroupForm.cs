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
            if (mainForm.cmbGroup.SelectedItem == null
                || string.IsNullOrEmpty(mainForm.cmbGroup.SelectedItem.ToString()))
            {
                this.Text = "Нова група";
                this.btnDeleteGroup.Visible = false;
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
            GroupPreset group;
            //if item empty
            if (mainForm.cmbGroup.SelectedItem == null ||
                mainForm.cmbGroup.SelectedItem.ToString() == "")
            {
                group = new GroupPreset();
                group.GroupName = tbGroupName.Text;
                group.GroupDirectory = tbGroupDir.Text;
                mainForm.loadedGroups.groups.Add(group);
            }
            //if not empty
            else
            {
                group = mainForm.loadedGroups.groups.
                       Single(x=>x.GroupName==mainForm.cmbGroup.SelectedItem);
                group.GroupName = tbGroupName.Text;
                group.GroupDirectory = tbGroupDir.Text;
            }
            mainForm.cmbGroupsUpdate();
            mainForm.loadedGroupsUpdate();
            mainForm.cmbGroup.SelectedItem = group.GroupName;
            this.Close();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 
                MessageBox.Show("Дійсно видалити цю групу?", "Видалення", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GroupPreset group = mainForm.loadedGroups.groups.
                      Single(x => x.GroupName == mainForm.
                            cmbGroup.SelectedItem.ToString());
                mainForm.loadedGroups.groups.Remove(group);
                mainForm.cmbGroupsUpdate();
                mainForm.loadedGroupsUpdate();
                mainForm.cmbGroup.SelectedItem = "";
                Close();
            }
        }
    }
}
