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
    public partial class FormHotelUpdate : Form
    {
        int choicecell;
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public MainMenu mainMenu2 = new MainMenu();
        public FormHotelUpdate(int choicecell)
        {
            InitializeComponent();
            this.choicecell = choicecell;
        }
        private void btnFormHotelUpdateExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormHotelUpdate_Load(object sender, EventArgs e)
        {
            LoadtbFormHotelUpdateRating();
            LoadtbFormHotelUpdateName();
            LoadtbFormHotelUpdateCost();
            LoadtbFormHotelUpdateFood();
        }
        private void LoadtbFormHotelUpdateName()
        {
            tbFormHotelUpdateName.Text = "Введите имя";
            tbFormHotelUpdateName.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelUpdateName()
        {
            tbFormHotelUpdateName.Text = string.Empty;
            tbFormHotelUpdateName.ForeColor = Color.Black;
        }
        private void LoadtbFormHotelUpdateRating()
        {
            tbFormHotelUpdateRating.Text = "Введите рейтинг (целое число)";
            tbFormHotelUpdateRating.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelUpdateRating()
        {
            tbFormHotelUpdateRating.Text = string.Empty;
            tbFormHotelUpdateRating.ForeColor = Color.Black;
        }
        private void LoadtbFormHotelUpdateFood()
        {
            tbFormHotelUpdateFood.Text = "Введите рейтинг питания";
            tbFormHotelUpdateFood.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelUpdateFood()
        {
            tbFormHotelUpdateFood.Text = string.Empty;
            tbFormHotelUpdateFood.ForeColor = Color.Black;
        }
        private void LoadtbFormHotelUpdateCost()
        {
            tbFormHotelUpdateCost.Text = "Введите стоимость";
            tbFormHotelUpdateCost.ForeColor = Color.Gray;
        }
        private void EntertbFormHotelUpdateCost()
        {
            tbFormHotelUpdateCost.Text = string.Empty;
            tbFormHotelUpdateCost.ForeColor = Color.Black;
        }
        private void tbFormHotelUpdateName_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelUpdateName();
        }
        private void tbFormHotelUpdateRating_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelUpdateRating();
        }
        private void tbFormHotelUpdateFood_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelUpdateFood();
        }
        private void tbFormHotelUpdateCost_Enter(object sender, EventArgs e)
        {
            EntertbFormHotelUpdateCost();
        }
        private void tbFormHotelUpdateName_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelUpdateName.Text == string.Empty)
                LoadtbFormHotelUpdateName();
        }
        private void tbFormHotelUpdateRating_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelUpdateRating.Text == string.Empty)
                LoadtbFormHotelUpdateRating();
        }
        private void tbFormHotelUpdateFood_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelUpdateFood.Text == string.Empty)
                LoadtbFormHotelUpdateFood();
        }
        private void tbFormHotelUpdateCost_Leave(object sender, EventArgs e)
        {
            if (tbFormHotelUpdateCost.Text == string.Empty)
                LoadtbFormHotelUpdateCost();
        }
        private void btnFormHotelUpdateUpdate_Click(object sender, EventArgs e)
        {          
            dataBaseFunction.HotelUpdate(tbFormHotelUpdateName.Text, tbFormHotelUpdateRating.Text,
                tbFormHotelUpdateFood.Text, tbFormHotelUpdateCost.Text, choicecell);
            mainMenu2.TableAdapterHotel.Fill(mainMenu2.DBDataSet.Hotel);
        }
    }
}
