using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            Ref_ViewModel = new ViewModel.PersonViewModel();
        }
        public ViewModel.PersonViewModel Ref_ViewModel { get; set; }
        public Form1 Ref_Form1 { get; set; }
        private void btnSubmit_Click(object sender, EventArgs e)
        {   Ref_Form1 = new Form1();
            Ref_ViewModel.Edit(Convert.ToInt32(lblID.Text), txtTitle.Text
                , txtPhoneNumber.Text, txtMobile.Text);
            
            this.Close();
            MessageBox.Show("please enter Refresh Button !!!");
        }


        //txtTitle.Text=Convert.ToString(Ref_Form1.dgvPerson[1, Ref_Form1.dgvPerson.CurrentRow.Index].Value);
        //txtPhoneNumber.Text = Convert.ToString(Ref_Form1.dgvPerson[2, Ref_Form1.dgvPerson.CurrentRow.Index].Value);
        //txtMobile.Text = Convert.ToString(Ref_Form1.dgvPerson[3, Ref_Form1.dgvPerson.CurrentRow.Index].Value);

    }
}
