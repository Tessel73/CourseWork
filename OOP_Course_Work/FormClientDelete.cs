using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Course_Work
{
    public partial class FormClientDelete : Form
    {
        public FormClientDelete()
        {
            InitializeComponent();
        }

        private void btnFormClientDeleteExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientDelete_Load(object sender, EventArgs e)
        {          
            LoadtbFormClientDeletePassport();
            LoadtbFormClientDeleteName();
            LoadtbFormClientDeleteEmail();
        }

        private void LoadtbFormClientDeleteName()
        {
            tbFormClientDeleteName.Text = "Введите имя";
            tbFormClientDeleteName.ForeColor = Color.Gray;
        }

        private void EntertbFormClientDeleteName()
        {
            tbFormClientDeleteName.Text = string.Empty;
            tbFormClientDeleteName.ForeColor = Color.Black;
        }

        private void LoadtbFormClientDeletePassport()
        {
            tbFormClientDeletePassport.Text = "Введите паспортные данные";
            tbFormClientDeletePassport.ForeColor = Color.Gray;
        }

        private void EntertbFormClientDeletePassport()
        {
            tbFormClientDeletePassport.Text = string.Empty;
            tbFormClientDeletePassport.ForeColor = Color.Black;
        }

        private void LoadtbFormClientDeleteEmail()
        {
            tbFormClientDeleteEmail.Text = "Введите электронную почту";
            tbFormClientDeleteEmail.ForeColor = Color.Gray;
        }

        private void EntertbFormClientDeleteEmail()
        {
            tbFormClientDeleteEmail.Text = string.Empty;
            tbFormClientDeleteEmail.ForeColor = Color.Black;
        }

        private void tbFormClientDeleteName_Enter(object sender, EventArgs e)
        {
            EntertbFormClientDeleteName();
        }

        private void tbFormClientDeletePassport_Enter(object sender, EventArgs e)
        {
            EntertbFormClientDeletePassport();
        }

        private void tbFormClientDeleteEmail_Enter(object sender, EventArgs e)
        {
            EntertbFormClientDeleteEmail();
        }

        private void tbFormClientDeleteName_Leave(object sender, EventArgs e)
        {
            if (tbFormClientDeleteName.Text == string.Empty)
                LoadtbFormClientDeleteName();
        }

        private void tbFormClientDeletePassport_Leave(object sender, EventArgs e)
        {
            if (tbFormClientDeletePassport.Text == string.Empty)
                LoadtbFormClientDeletePassport();
        }

        private void tbFormClientDeleteEmail_Leave(object sender, EventArgs e)
        {
            if (tbFormClientDeleteEmail.Text == string.Empty)
                LoadtbFormClientDeleteEmail();
        }
    }
}
