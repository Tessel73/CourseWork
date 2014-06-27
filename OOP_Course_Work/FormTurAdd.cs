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
    public partial class FormTurAdd : Form
    {
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public MainMenu mainMenu2 = new MainMenu();
        public FormTurAdd()
        {
            InitializeComponent();
        }
        private void FormTurAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAddDataSet.Excursion". При необходимости она может быть перемещена или удалена.
            this.excursionTableAdapter.Fill(this.turAddDataSet.Excursion);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAddDataSet.Excursion". При необходимости она может быть перемещена или удалена.
            mainMenu2.TableAdapterExcursion.Fill(mainMenu2.DBDataSet.Excursion);
            LoadtbFormTurAddDateI();
            LoadtbFormTurAddDateO();
            LoadtbFormTurAddCountry();
            LoadtbFormTurAddCity();
            LoadtbFormTurAddD_N();
            LoadtbFormTurAddCost();
            LoadcbFormTurAddExcursionID();
        }
        private void LoadtbFormTurAddCountry()
        {
            tbFormTurAddCountry.Text = "Введите страну";
            tbFormTurAddCountry.ForeColor = Color.Gray;
        }
        private void EntertbFormTurAddCounty()
        {
            tbFormTurAddCountry.Text = string.Empty;
            tbFormTurAddCountry.ForeColor = Color.Black;
        }
        private void LoadtbFormTurAddCity()
        {
            tbFormTurAddCity.Text = "Введите город";
            tbFormTurAddCity.ForeColor = Color.Gray;
        }
        private void EntertbFormTurAddCity()
        {
            tbFormTurAddCity.Text = string.Empty;
            tbFormTurAddCity.ForeColor = Color.Black;
        }
        private void LoadtbFormTurAddDateI()
        {
            tbFormTurAddDateI.Text = "Введите дату прибытия (ДД.ММ.ГГ)";
            tbFormTurAddDateI.ForeColor = Color.Gray;
        }
        private void EntertbFormTurAddDateI()
        {
            tbFormTurAddDateI.Text = string.Empty;
            tbFormTurAddDateI.ForeColor = Color.Black;
        }
        private void LoadtbFormTurAddDateO()
        {
            tbFormTurAddDateO.Text = "Введите дату отправления (ДД.ММ.ГГ)";
            tbFormTurAddDateO.ForeColor = Color.Gray;
        }
        private void EntertbFormTurAddDateO()
        {
            tbFormTurAddDateO.Text = string.Empty;
            tbFormTurAddDateO.ForeColor = Color.Black;
        }
        private void LoadtbFormTurAddD_N()
        {
            tbFormTurAddD_N.Text = "Введите количество дней/ночей";
            tbFormTurAddD_N.ForeColor = Color.Gray;
        }
        private void EntertbFormTurAddD_N()
        {
            tbFormTurAddD_N.Text = string.Empty;
            tbFormTurAddD_N.ForeColor = Color.Black;
        }
        private void LoadtbFormTurAddCost()
        {
            tbFormTurAddCost.Text = "Введите стоимость";
            tbFormTurAddCost.ForeColor = Color.Gray;
        }
        private void EntertbFormTurAddCost()
        {
            tbFormTurAddCost.Text = string.Empty;
            tbFormTurAddCost.ForeColor = Color.Black;
        }
        private void LoadcbFormTurAddExcursionID()
        {
            cbFormTurAddExcursionID.Text = "Выберите экскурсию";
            cbFormTurAddExcursionID.ForeColor = Color.Gray;
        }
        private void EntercbFormTurAddExcursionID()
        {
            cbFormTurAddExcursionID.Text = string.Empty;
            cbFormTurAddExcursionID.ForeColor = Color.Black;
        }
        private void tbFormTurAddCountry_Enter(object sender, EventArgs e)
        {
            EntertbFormTurAddCounty();
        }
        private void tbFormTurAddCity_Enter(object sender, EventArgs e)
        {
            EntertbFormTurAddCity();
        }
        private void tbFormTurAddDateO_Enter(object sender, EventArgs e)
        {
            EntertbFormTurAddDateO();
        }
        private void tbFormTurAddDateI_Enter(object sender, EventArgs e)
        {
            EntertbFormTurAddDateI();
        }
        private void tbFormTurAddD_N_Enter(object sender, EventArgs e)
        {
            EntertbFormTurAddD_N();
        }
        private void cbFormTurAddExcursionID_Enter(object sender, EventArgs e)
        {
            EntercbFormTurAddExcursionID();
        }
        private void tbFormTurAddCost_Enter(object sender, EventArgs e)
        {
            EntertbFormTurAddCost();
        }
        private void tbFormTurAddCountry_Leave(object sender, EventArgs e)
        {
            if (tbFormTurAddCountry.Text == string.Empty)
                LoadtbFormTurAddCountry();
        }
        private void tbFormTurAddCity_Leave(object sender, EventArgs e)
        {
            if (tbFormTurAddCity.Text == string.Empty)
                LoadtbFormTurAddCity();
        }
        private void tbFormTurAddDateO_Leave(object sender, EventArgs e)
        {
            if (tbFormTurAddDateO.Text == string.Empty)
                LoadtbFormTurAddDateO();
        }
        private void tbFormTurAddDateI_Leave(object sender, EventArgs e)
        {
            if (tbFormTurAddDateI.Text == string.Empty)
                LoadtbFormTurAddDateI();
        }
        private void tbFormTurAddD_N_Leave(object sender, EventArgs e)
        {
            if (tbFormTurAddD_N.Text == string.Empty)
                LoadtbFormTurAddD_N();
        }
        private void tbFormTurAddCost_Leave(object sender, EventArgs e)
        {
            if (tbFormTurAddCost.Text == string.Empty)
                LoadtbFormTurAddCost();
        }
        private void btnFormTurAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFormTurAddAdd_Click(object sender, EventArgs e)
        {            
            dataBaseFunction.TurAdd(tbFormTurAddCountry.Text, tbFormTurAddCity.Text, tbFormTurAddDateO.Text,
                tbFormTurAddDateI.Text, tbFormTurAddD_N.Text, tbFormTurAddCost.Text, cbFormTurAddExcursionID.Text);
            mainMenu2.TableAdapterTur.Fill(mainMenu2.DBDataSet.Tur);
        }      
    }
}
