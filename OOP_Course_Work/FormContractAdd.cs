using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OOP_Course_Work
{
    public partial class FormContractAdd : Form
    {
        public MainMenu mainMenu2 = new MainMenu();
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public FormContractAdd()
        {
            InitializeComponent();
        }
        private void btnFormContractAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormContractAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contractAddDataSet.Tur". При необходимости она может быть перемещена или удалена.
            this.turTableAdapter.Fill(this.contractAddDataSet.Tur);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contractAddDataSet.Hotel". При необходимости она может быть перемещена или удалена.
            this.hotelTableAdapter.Fill(this.contractAddDataSet.Hotel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contractAddDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.contractAddDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contractAddDataSetClient.Client". При необходимости она может быть перемещена или удалена.
            LoadtbFormContractAddDate();
            LoadtbFormContractAddCost();
            LoadcbFormContractAddHotelID();
            LoadcbFormContractAddClientID();
            LoadcbFormContractAddTurID();
            LoadtbFormContractAddNumber();                               
        }
        private void LoadcbFormContractAddClientID()
        {
            cbFormContractAddClientID.Text = "Выберите клиента";
            cbFormContractAddClientID.ForeColor = Color.Gray;
        }
        private void EntercbFormContractAddClientID()
        {
            cbFormContractAddClientID.Text = string.Empty;
            cbFormContractAddClientID.ForeColor = Color.Black;
        }
        private void LoadcbFormContractAddTurID()
        {
            cbFormContractAddTurID.Text = "Выберите тур";
            cbFormContractAddTurID.ForeColor = Color.Gray;
        }
        private void EntercbFormContractAddTurID()
        {
            cbFormContractAddTurID.Text = string.Empty;
            cbFormContractAddTurID.ForeColor = Color.Black;
        }
        private void LoadcbFormContractAddHotelID()
        {
            cbFormContractAddHotelID.Text = "Выберите отель";
            cbFormContractAddHotelID.ForeColor = Color.Gray;
        }
        private void EntercbFormContractAddHotelID()
        {
            cbFormContractAddHotelID.Text = string.Empty;
            cbFormContractAddHotelID.ForeColor = Color.Black;
        }
        private void LoadtbFormContractAddNumber()
        {
            tbFormContractAddNumber.Text = "Введите количество путевок";
            tbFormContractAddNumber.ForeColor = Color.Gray;
        }
        private void EntertbFormContractAddNumber()
        {
            tbFormContractAddNumber.Text = string.Empty;
            tbFormContractAddNumber.ForeColor = Color.Black;
        }
        private void LoadtbFormContractAddCost()
        {
            tbFormContractAddCost.Text = "Введите стоимость";
            tbFormContractAddCost.ForeColor = Color.Gray;
        }
        private void EntertbFormContractAddCost()
        {
            tbFormContractAddCost.Text = string.Empty;
            tbFormContractAddCost.ForeColor = Color.Black;
        }
        private void LoadtbFormContractAddDate()
        {
            tbFormContractAddDate.Text = "Введите дату заключения договора (ДД.ММ.ГГ)";
            tbFormContractAddDate.ForeColor = Color.Gray;
        }
        private void EntertbFormContractAddDate()
        {
            tbFormContractAddDate.Text = string.Empty;
            tbFormContractAddDate.ForeColor = Color.Black;
        }
        private void cbFormContractClientID_Enter(object sender, EventArgs e)
        {
            EntercbFormContractAddClientID();
        }
        private void cbFormContractAddTurID_Enter(object sender, EventArgs e)
        {
            EntercbFormContractAddTurID();
        }
        private void cbFormContractAddHotelID_Enter(object sender, EventArgs e)
        {
            EntercbFormContractAddHotelID();
        }
        private void tbFormContractAddNumber_Enter(object sender, EventArgs e)
        {
            EntertbFormContractAddNumber();
        }
        private void tbFormContractAddCost_Enter(object sender, EventArgs e)
        {
            EntertbFormContractAddCost();
        }
        private void tbFormContractAddDate_Enter(object sender, EventArgs e)
        {
            EntertbFormContractAddDate();
        }
        private void cbFormContractAddClientID_Leave(object sender, EventArgs e)
        {
            if (cbFormContractAddClientID.Text == string.Empty)
                LoadcbFormContractAddClientID();
        }
        private void cbFormContractAddTurID_Leave(object sender, EventArgs e)
        {
            if (cbFormContractAddTurID.Text == string.Empty)
                LoadcbFormContractAddTurID();
        }
        private void cbFormContractAddHotelID_Leave(object sender, EventArgs e)
        {
            if (cbFormContractAddHotelID.Text == string.Empty)
                LoadcbFormContractAddHotelID();
        }
        private void tbFormContractAddNumber_Leave(object sender, EventArgs e)
        {
            if (tbFormContractAddNumber.Text == string.Empty)
                LoadtbFormContractAddNumber();
        } 
        private void tbFormContractAddCost_Leave(object sender, EventArgs e)
        {
            if (tbFormContractAddCost.Text == string.Empty)
                LoadtbFormContractAddCost();
        }
        private void tbFormContractAddDate_Leave(object sender, EventArgs e)
        {
            if (tbFormContractAddDate.Text == string.Empty)
                LoadtbFormContractAddDate();
        }  
        private void btnFormContractAddAdd_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ContractAdd(cbFormContractAddClientID.Text, cbFormContractAddTurID.Text,
                cbFormContractAddHotelID.Text, tbFormContractAddNumber.Text, tbFormContractAddCost.Text, tbFormContractAddDate.Text);
            mainMenu2.TableAdapterContract.Fill(mainMenu2.DBDataSet.Contract);
        }       
    }
}

