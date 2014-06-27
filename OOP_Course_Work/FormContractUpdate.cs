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
    public partial class FormContractUpdate : Form
    {
        int choicecell;
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public MainMenu mainMenu2 = new MainMenu();
        public FormContractUpdate(int choicecell)
        {
            InitializeComponent();
            this.choicecell = choicecell;
        }
        private void btnFormContractUpdateExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormContractUpdate_Load(object sender, EventArgs e)
        {
            LoadtbFormContractUpdateCost();
            LoadcbFormContractUpdateHotelID();
            LoadtbFormContractUpdateNumber();
            LoadcbFormContractUpdateClientID();
            LoadcbFormContractUpdateTurID();
        }
        private void LoadcbFormContractUpdateClientID()
        {
            cbFormContractUpdateClientID.Text = "Выберите клиента";
            cbFormContractUpdateClientID.ForeColor = Color.Gray;
        }
        private void EntercbFormContractUpdateClientID()
        {
            cbFormContractUpdateClientID.Text = string.Empty;
            cbFormContractUpdateClientID.ForeColor = Color.Black;
        }
        private void LoadcbFormContractUpdateTurID()
        {
            cbFormContractUpdateTurID.Text = "Выберите тур";
            cbFormContractUpdateTurID.ForeColor = Color.Gray;
        }
        private void EntercbFormContractUpdateTurID()
        {
            cbFormContractUpdateTurID.Text = string.Empty;
            cbFormContractUpdateTurID.ForeColor = Color.Black;
        }
        private void LoadcbFormContractUpdateHotelID()
        {
            cbFormContractUpdateHotelID.Text = "Выберите отель";
            cbFormContractUpdateHotelID.ForeColor = Color.Gray;
        }
        private void EntercbFormContractUpdateHotelID()
        {
            cbFormContractUpdateHotelID.Text = string.Empty;
            cbFormContractUpdateHotelID.ForeColor = Color.Black;
        }
        private void LoadtbFormContractUpdateNumber()
        {
            tbFormContractUpdateNumber.Text = "Введите количество путевок";
            tbFormContractUpdateNumber.ForeColor = Color.Gray;
        }
        private void EntertbFormContractUpdateNumber()
        {
            tbFormContractUpdateNumber.Text = string.Empty;
            tbFormContractUpdateNumber.ForeColor = Color.Black;
        }
        private void LoadtbFormContractUpdateCost()
        {
            tbFormContractUpdateCost.Text = "Введите стоимость";
            tbFormContractUpdateCost.ForeColor = Color.Gray;
        }
        private void EntertbFormContractUpdateCost()
        {
            tbFormContractUpdateCost.Text = string.Empty;
            tbFormContractUpdateCost.ForeColor = Color.Black;
        }
        private void cbFormContractClientID_Enter(object sender, EventArgs e)
        {
            EntercbFormContractUpdateClientID();
        }
        private void cbFormContractUpdateTurID_Enter(object sender, EventArgs e)
        {
            EntercbFormContractUpdateTurID();
        }
        private void cbFormContractUpdateHotelID_Enter(object sender, EventArgs e)
        {
            EntercbFormContractUpdateHotelID();
        }
        private void tbFormContractUpdateNumber_Enter(object sender, EventArgs e)
        {
            EntertbFormContractUpdateNumber();
        }
        private void tbFormContractUpdateCost_Enter(object sender, EventArgs e)
        {
            EntertbFormContractUpdateCost();
        }
        private void cbFormContractUpdateClientID_Leave(object sender, EventArgs e)
        {
            if (cbFormContractUpdateClientID.Text == string.Empty)
                LoadcbFormContractUpdateClientID();
        }
        private void cbFormContractUpdateTurID_Leave(object sender, EventArgs e)
        {
            if (cbFormContractUpdateTurID.Text == string.Empty)
                LoadcbFormContractUpdateTurID();
        }
        private void cbFormContractUpdateHotelID_Leave(object sender, EventArgs e)
        {
            if (cbFormContractUpdateHotelID.Text == string.Empty)
                LoadcbFormContractUpdateHotelID();
        }
        private void tbFormContractUpdateNumber_Leave(object sender, EventArgs e)
        {
            if (tbFormContractUpdateNumber.Text == string.Empty)
                LoadtbFormContractUpdateNumber();
        }
        private void tbFormContractUpdateCost_Leave(object sender, EventArgs e)
        {
            if (tbFormContractUpdateCost.Text == string.Empty)
                LoadtbFormContractUpdateCost();
        }
        private void btnFormContractUpdateUpdate_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ContractUpdate(cbFormContractUpdateClientID.Text, cbFormContractUpdateTurID.Text,
                cbFormContractUpdateHotelID.Text, tbFormContractUpdateNumber.Text, tbFormContractUpdateCost.Text, choicecell);
            mainMenu2.TableAdapterContract.Fill(mainMenu2.DBDataSet.Contract);
        }        
    }
}

