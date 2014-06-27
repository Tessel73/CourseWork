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
    public partial class FormClientAdd : Form
    {
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public MainMenu mainMenu2 = new MainMenu();
        public FormClientAdd()
        {
            InitializeComponent();           
        }
        private void btnFormClientAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormClientAdd_Load(object sender, EventArgs e)
        {          
            LoadtbFormClientAddPassport();
            LoadtbFormClientAddName();
            LoadtbFormClientAddEmail();
        }
        private void LoadtbFormClientAddName()
        {
            tbFormClientAddName.Text = "Введите имя";
            tbFormClientAddName.ForeColor = Color.Gray;
        }
        private void EntertbFormClientAddName()
        {
            tbFormClientAddName.Text = string.Empty;
            tbFormClientAddName.ForeColor = Color.Black;
        }
        private void LoadtbFormClientAddPassport()
        {
            tbFormClientAddPassport.Text = "Введите паспортные данные";
            tbFormClientAddPassport.ForeColor = Color.Gray;
        }
        private void EntertbFormClientAddPassport()
        {
            tbFormClientAddPassport.Text = string.Empty;
            tbFormClientAddPassport.ForeColor = Color.Black;
        }
        private void LoadtbFormClientAddEmail()
        {
            tbFormClientAddEmail.Text = "Введите электронную почту";
            tbFormClientAddEmail.ForeColor = Color.Gray;
        }
        private void EntertbFormClientAddEmail()
        {
            tbFormClientAddEmail.Text = string.Empty;
            tbFormClientAddEmail.ForeColor = Color.Black;
        }
        private void tbFormClientAddName_Enter(object sender, EventArgs e)
        {
            EntertbFormClientAddName();
        }
        private void tbFormClientAddPassport_Enter(object sender, EventArgs e)
        {
            EntertbFormClientAddPassport();
        }
        private void tbFormClientAddEmail_Enter(object sender, EventArgs e)
        {
            EntertbFormClientAddEmail();
        }
        private void tbFormClientAddName_Leave(object sender, EventArgs e)
        {
            if (tbFormClientAddName.Text == string.Empty)
            LoadtbFormClientAddName();
        }
        private void tbFormClientAddPassport_Leave(object sender, EventArgs e)
        {
            if (tbFormClientAddPassport.Text == string.Empty)
            LoadtbFormClientAddPassport();
        }
        private void tbFormClientAddEmail_Leave(object sender, EventArgs e)
        {
            if (tbFormClientAddEmail.Text == string.Empty)
            LoadtbFormClientAddEmail();
        }
        private void btnFormClientAddAdd_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ClientAdd(tbFormClientAddName.Text, tbFormClientAddPassport.Text, 
                tbFormClientAddEmail.Text);
            mainMenu2.TableAdapterClient.Fill(mainMenu2.DBDataSet.Client);
        }
    }
}
