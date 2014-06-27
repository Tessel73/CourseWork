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
    public partial class FormHotelAdd : Form
    {
        public MainMenu mainMenu2 = new MainMenu();
        public FormHotelAdd()
        {
            InitializeComponent();
        }
        private void btnFormHotelAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormHotelAdd_Load(object sender, EventArgs e)
        {
            LoadtbFormHotelAddRating();
            LoadtbFormHotelAddName();
            LoadtbFormHotelAddCost();
            LoadtbFormHotelAddFood();
        }
        private void LoadtbFormHotelAddName()
        {
            tbFormHotelAddName.Text = "Введите имя";
            tbFormHotelAddName.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelAddName()
        {
            tbFormHotelAddName.Text = string.Empty;
            tbFormHotelAddName.ForeColor = Color.Black;
        }
        private void LoadtbFormHotelAddRating()
        {
            tbFormHotelAddRating.Text = "Введите рейтинг (целое число)";
            tbFormHotelAddRating.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelAddRating()
        {
            tbFormHotelAddRating.Text = string.Empty;
            tbFormHotelAddRating.ForeColor = Color.Black;
        }
        private void LoadtbFormHotelAddFood()
        {
            tbFormHotelAddFood.Text = "Введите рейтинг питания";
            tbFormHotelAddFood.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelAddFood()
        {
            tbFormHotelAddFood.Text = string.Empty;
            tbFormHotelAddFood.ForeColor = Color.Black;
        }
        private void LoadtbFormHotelAddCost()
        {
            tbFormHotelAddCost.Text = "Введите стоимость";
            tbFormHotelAddCost.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelAddCost()
        {
            tbFormHotelAddCost.Text = string.Empty;
            tbFormHotelAddCost.ForeColor = Color.Black;
        }
        private void tbFormHotelAddName_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelAddName();
        }
        private void tbFormHotelAddRating_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelAddRating();
        }
        private void tbFormHotelAddFood_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelAddFood();
        }
        private void tbFormHotelAddCost_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelAddCost();
        }
        private void tbFormHotelAddName_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelAddName.Text == string.Empty)
                LoadtbFormHotelAddName();
        }
        private void tbFormHotelAddRating_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelAddRating.Text == string.Empty)
                LoadtbFormHotelAddRating();
        }
        private void tbFormHotelAddFood_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelAddFood.Text == string.Empty)
                LoadtbFormHotelAddFood();
        }
        private void tbFormHotelAddCost_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelAddCost.Text == string.Empty)
                LoadtbFormHotelAddCost();
        }
        private void btnFormHotelAddAdd_Click(object sender, EventArgs e)
        {
            DataBaseFunction dataBaseFuntion = new DataBaseFunction();
            dataBaseFuntion.HotelAdd(tbFormHotelAddName.Text, tbFormHotelAddRating.Text, tbFormHotelAddFood.Text,
                tbFormHotelAddCost.Text);
            mainMenu2.TableAdapterHotel.Fill(mainMenu2.DBDataSet.Hotel);
        }
    }
}
