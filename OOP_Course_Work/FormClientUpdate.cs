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
    public partial class FormClientUpdate : Form
    {
        int choicecell;
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public MainMenu mainMenu2 = new MainMenu();
        public FormClientUpdate(int choicecell)
        {
            InitializeComponent();
            this.choicecell = choicecell;
        }
        private void btnFormClientUpdateExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormClientUpdate_Load(object sender, EventArgs e)
        {          
            LoadtbFormClientUpdatePassport();
            LoadtbFormClientUpdateName();
            LoadtbFormClientUpdateEmail();
        }
        private void LoadtbFormClientUpdateName()
        {
            tbFormClientUpdateName.Text = "Введите имя";
            tbFormClientUpdateName.ForeColor = Color.Gray;
        }
        private void EntertbFormClientUpdateName()
        {
            tbFormClientUpdateName.Text = string.Empty;
            tbFormClientUpdateName.ForeColor = Color.Black;
        }
        private void LoadtbFormClientUpdatePassport()
        {
            tbFormClientUpdatePassport.Text = "Введите паспортные данные";
            tbFormClientUpdatePassport.ForeColor = Color.Gray;
        }
        private void EntertbFormClientUpdatePassport()
        {
            tbFormClientUpdatePassport.Text = string.Empty;
            tbFormClientUpdatePassport.ForeColor = Color.Black;
        }
        private void LoadtbFormClientUpdateEmail()
        {
            tbFormClientUpdateEmail.Text = "Введите электронную почту";
            tbFormClientUpdateEmail.ForeColor = Color.Gray;
        }
        private void EntertbFormClientUpdateEmail()
        {
            tbFormClientUpdateEmail.Text = string.Empty;
            tbFormClientUpdateEmail.ForeColor = Color.Black;
        }
        private void tbFormClientUpdateName_Enter(object sender, EventArgs e)
        {
            EntertbFormClientUpdateName();
        }
        private void tbFormClientUpdatePassport_Enter(object sender, EventArgs e)
        {
            EntertbFormClientUpdatePassport();
        }
        private void tbFormClientUpdateEmail_Enter(object sender, EventArgs e)
        {
            EntertbFormClientUpdateEmail();
        }
        private void tbFormClientUpdateName_Leave(object sender, EventArgs e)
        {
            if (tbFormClientUpdateName.Text == string.Empty)
                LoadtbFormClientUpdateName();
        }
        private void tbFormClientUpdatePassport_Leave(object sender, EventArgs e)
        {
            if (tbFormClientUpdatePassport.Text == string.Empty)
                LoadtbFormClientUpdatePassport();
        }
        private void tbFormClientUpdateEmail_Leave(object sender, EventArgs e)
        {
            if (tbFormClientUpdateEmail.Text == string.Empty)
                LoadtbFormClientUpdateEmail();
        }
        private void btnFormClientUpdateUpdate_Click(object sender, EventArgs e)
        {           
            dataBaseFunction.ClientUpdate(tbFormClientUpdateName.Text, tbFormClientUpdatePassport.Text, 
                tbFormClientUpdateEmail.Text, choicecell);
            mainMenu2.TableAdapterClient.Fill(mainMenu2.DBDataSet.Client);
        }
    }
}
