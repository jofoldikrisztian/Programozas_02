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

namespace DataGridView
{
    public partial class PhoneBookFrm : Form
    {

        static AppData App = new AppData();

        public PhoneBookFrm()
        {
            InitializeComponent();
        }

        private void PhoneBookFrm_Load(object sender, EventArgs e)
        {
            string filePath = string.Format("{0}//data.dat", Application.StartupPath);

            if (File.Exists(filePath)) 
                App.PhoneBook.ReadXml(filePath);

            phoneBookBindingSource.DataSource = App.PhoneBook;

            pnl.Enabled = false;
        }



        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                phoneBookBindingSource.EndEdit();
                App.PhoneBook.AcceptChanges();
                App.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                pnl.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.PhoneBook.RejectChanges();
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            phoneBookBindingSource.ResetBindings(false);
            pnl.Enabled = false;
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            pnl.Enabled = true;
            mskdTxtBxPhoneNumber.Focus();
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            try {
                pnl.Enabled = true;
                App.PhoneBook.AddPhoneBookRow(App.PhoneBook.NewPhoneBookRow());
                phoneBookBindingSource.MoveLast(); 
                mskdTxtBxPhoneNumber.Focus();
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                App.PhoneBook.RejectChanges(); 
            }
        }

        private void dtGrdVw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dtGrdVw.SelectedRows)
                    App.PhoneBook.Rows.Remove((row.DataBoundItem as DataRowView).Row);
                App.PhoneBook.AcceptChanges();
            }
        }

        private void phoneBookBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void txtBxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtBxSearch.Text))
                {
                    var result = from phoneBook in App.PhoneBook
                        where !phoneBook.IsNull(0) &&
                              (phoneBook.PhoneNumber == txtBxSearch.Text ||
                               phoneBook.FullName.Contains(txtBxSearch.Text) ||
                               phoneBook.Email == txtBxSearch.Text)
                        select phoneBook;
                    dtGrdVw.DataSource = result.ToList();
                    return;
                }
            }
            else if (e.KeyCode == Keys.Escape)
                txtBxSearch.Clear();
            else
                return;

            dtGrdVw.DataSource = phoneBookBindingSource;
        }


    }
}
