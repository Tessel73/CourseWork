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
    public partial class FormTurUpdate : Form
    {
        int choicesell;
        public MainMenu mainMenu2 = new MainMenu();
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public FormTurUpdate(int choicesell)
        {
            InitializeComponent();
            this.choicesell = choicesell;
        }
        private void FormTurUpdate_Load(object sender, EventArgs e)
        {
            LoadtbFormTurUpdateDateI();
            LoadtbFormTurUpdateDateO();
            LoadtbFormTurUpdateCountry();
            LoadtbFormTurUpdateCity();
            LoadtbFormTurUpdateD_N();
            LoadtbFormTurUpdateCost();
        }
        private void LoadtbFormTurUpdateCountry()
        {
            tbFormTurUpdateCountry.Text = "Введите страну";
            tbFormTurUpdateCountry.ForeColor = Color.Gray;
        }
        private void EntertbFormTurUpdateCountry()
        {
            tbFormTurUpdateCountry.Text = string.Empty;
            tbFormTurUpdateCountry.ForeColor = Color.Black;
        }
        private void LoadtbFormTurUpdateCity()
        {
            tbFormTurUpdateCity.Text = "Введите город";
            tbFormTurUpdateCity.ForeColor = Color.Gray;
        }
        private void EntertbFormTurUpdateCity()
        {
            tbFormTurUpdateCity.Text = string.Empty;
            tbFormTurUpdateCity.ForeColor = Color.Black;
        }
        private void LoadtbFormTurUpdateDateI()
        {
            tbFormTurUpdateDateI.Text = "Введите дату прибытия (ДД:ММ:ГГ)";
            tbFormTurUpdateDateI.ForeColor = Color.Gray;
        }
        private void EntertbFormTurUpdateDateI()
        {
            tbFormTurUpdateDateI.Text = string.Empty;
            tbFormTurUpdateDateI.ForeColor = Color.Black;
        }
        private void LoadtbFormTurUpdateDateO()
        {
            tbFormTurUpdateDateO.Text = "Введите дату отправления (ДД:ММ:ГГ)";
            tbFormTurUpdateDateO.ForeColor = Color.Gray;
        }
        private void EntertbFormTurUpdateDateO()
        {
            tbFormTurUpdateDateO.Text = string.Empty;
            tbFormTurUpdateDateO.ForeColor = Color.Black;
        }
        private void LoadtbFormTurUpdateD_N()
        {
            tbFormTurUpdateD_N.Text = "Введите количество дней/ночей";
            tbFormTurUpdateD_N.ForeColor = Color.Gray;
        }
        private void EntertbFormTurUpdateD_N()
        {
            tbFormTurUpdateD_N.Text = string.Empty;
            tbFormTurUpdateD_N.ForeColor = Color.Black;
        }
        private void LoadtbFormTurUpdateCost()
        {
            tbFormTurUpdateCost.Text = "Введите стоимость";
            tbFormTurUpdateCost.ForeColor = Color.Gray;
        }
        private void EntertbFormTurUpdateCost()
        {
            tbFormTurUpdateCost.Text = string.Empty;
            tbFormTurUpdateCost.ForeColor = Color.Black;
        }
        private void LoadcbFormTurUpdateExcursionID() 
        {
            cbFormTurUpdateExcursionID.Text = "Выберите экскурсию";
            cbFormTurUpdateExcursionID.ForeColor = Color.Gray;
        }
        private void EntercbFormTurUpdateExcurtionID()
        {
            cbFormTurUpdateExcursionID.Text = string.Empty;
            cbFormTurUpdateExcursionID.ForeColor = Color.Black;
        }
        private void tbFormTurUpdateCountry_Enter(object sender, EventArgs e)
        {
            EntertbFormTurUpdateCountry();
        }
        private void tbFormTurUpdateCity_Enter(object sender, EventArgs e)
        {
            EntertbFormTurUpdateCity();
        }
        private void tbFormTurUpdateDateO_Enter(object sender, EventArgs e)
        {
            EntertbFormTurUpdateDateO();
        }
        private void tbFormTurUpdateDateI_Enter(object sender, EventArgs e)
        {
            EntertbFormTurUpdateDateI();
        }
        private void tbFormTurUpdateD_N_Enter(object sender, EventArgs e)
        {
            EntertbFormTurUpdateD_N();
        }
        private void tbFormTurUpdateCost_Enter(object sender, EventArgs e)
        {
            EntertbFormTurUpdateCost();
        }
        private void tbFormTurUpdateExcursionID_Enter(object sender, EventArgs e)
        {
            EntercbFormTurUpdateExcurtionID();
        }
        private void tbFormTurUpdateCountry_Leave(object sender, EventArgs e)
        {
            if (tbFormTurUpdateCountry.Text == string.Empty)
                LoadtbFormTurUpdateCountry();
        }
        private void tbFormTurUpdateCity_Leave(object sender, EventArgs e)
        {
            if (tbFormTurUpdateCity.Text == string.Empty)
                LoadtbFormTurUpdateCity();
        }
        private void tbFormTurUpdateDateO_Leave(object sender, EventArgs e)
        {
            if (tbFormTurUpdateDateO.Text == string.Empty)
                LoadtbFormTurUpdateDateO();
        }
        private void tbFormTurUpdateDateI_Leave(object sender, EventArgs e)
        {
            if (tbFormTurUpdateDateI.Text == string.Empty)
                LoadtbFormTurUpdateDateI();
        }
        private void tbFormTurUpdateD_N_Leave(object sender, EventArgs e)
        {
            if (tbFormTurUpdateD_N.Text == string.Empty)
                LoadtbFormTurUpdateD_N();
        }
        private void tbFormTurUpdateCost_Leave(object sender, EventArgs e)
        {
            if (tbFormTurUpdateCost.Text == string.Empty)
                LoadtbFormTurUpdateCost();
        }
        private void cbFormTurUpdateExcursionID_Leave(object sender, EventArgs e)
        {
            if (cbFormTurUpdateExcursionID.Text == string.Empty)
                LoadcbFormTurUpdateExcursionID();
        }
        private void btnFormTurUpdateExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFormTurUpdateUpdate_Click(object sender, EventArgs e)
        {
            dataBaseFunction.TurUpdate(tbFormTurUpdateCountry.Text, tbFormTurUpdateCity.Text, tbFormTurUpdateDateO.Text,
                tbFormTurUpdateDateI.Text, tbFormTurUpdateD_N.Text, tbFormTurUpdateCost.Text, cbFormTurUpdateExcursionID.Text, choicesell);
            mainMenu2.TableAdapterTur.Fill(mainMenu2.DBDataSet.Tur);
        }
    }
}
