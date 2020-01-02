using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace View
{
    public partial class Form1 : Form
    {
        #region [- ctor -]
        public Form1()
        {
            InitializeComponent();
            Ref_PersonViewModel = new ViewModel.PersonViewModel();
        }
        #endregion

        #region [- props -]
        public ViewModel.PersonViewModel Ref_PersonViewModel { get; set; }
        public Edit Ref_Edit { get; set; }
        #endregion

        #region [- btnRefresh_Click -]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = Ref_PersonViewModel.FillGrid();
        }
        #endregion

        #region [- btnSavee_Click -]
        private void btnSavee_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Save(txtTitle.Text, txtPhoneNumber.Text, txtMobile.Text);
            dgvPerson.DataSource = Ref_PersonViewModel.FillGrid();
            MessageBox.Show("Successfully Saved");
            txtTitle.Text = "";
            txtPhoneNumber.Text = "";
            txtMobile.Text = "";
        }

        #endregion

        #region [- btnDelete_Click -]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPerson[0, dgvPerson.CurrentRow.Index].Value);
            DialogResult res = MessageBox.Show("Are you sure you want to delete ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Ref_PersonViewModel.Delete(id);
                MessageBox.Show("deleted");
                dgvPerson.DataSource = Ref_PersonViewModel.FillGrid();
            }
        }


        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Ref_Edit = new Edit();
            Ref_Edit.lblID.Text = Convert.ToString(dgvPerson[0, dgvPerson.CurrentRow.Index].Value);
            Ref_Edit.txtTitle.Text = Convert.ToString(dgvPerson[1, dgvPerson.CurrentRow.Index].Value);
            Ref_Edit.txtPhoneNumber.Text= Convert.ToString(dgvPerson[2, dgvPerson.CurrentRow.Index].Value);
            Ref_Edit.txtMobile.Text = Convert.ToString(dgvPerson[3, dgvPerson.CurrentRow.Index].Value);
            Ref_Edit.Show();
        }
    }
}
