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
    public partial class FormExcursionUpdate : Form
    {
        int cell;
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public MainMenu mainMenu2 = new MainMenu();
        public FormExcursionUpdate(int cell)
        {
            InitializeComponent();
            this.cell = cell;
        }
        private void btnFormExcursionUpdateExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormExcursionUpdate_Load(object sender, EventArgs e)
        {
            LoadtbFormExcursionUpdateRating();
            LoadtbFormExcursionUpdateName();
            LoadtbFormExcursionUpdateLength();
            LoadtbFormExcursionUpdateTime();
            LoadtbFormExcursionUpdateNote();
            LoadtbFormExcursionUpdateCost();
        }
        private void LoadtbFormExcursionUpdateName()
        {
            tbFormExcursionUpdateName.Text = "Введите имя";
            tbFormExcursionUpdateName.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionUpdateName()
        {
            tbFormExcursionUpdateName.Text = string.Empty;
            tbFormExcursionUpdateName.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionUpdateRating()
        {
            tbFormExcursionUpdateRating.Text = "Введите рейтинг (целое число)";
            tbFormExcursionUpdateRating.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionUpdateRating()
        {
            tbFormExcursionUpdateRating.Text = string.Empty;
            tbFormExcursionUpdateRating.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionUpdateLength()
        {
            tbFormExcursionUpdateLength.Text = "Введите длительность (ЧЧ:ММ)";
            tbFormExcursionUpdateLength.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionUpdateLength()
        {
            tbFormExcursionUpdateLength.Text = string.Empty;
            tbFormExcursionUpdateLength.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionUpdateTime()
        {
            tbFormExcursionUpdateTime.Text = "Введите время начала (ЧЧ:ММ)";
            tbFormExcursionUpdateTime.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionUpdateTime()
        {
            tbFormExcursionUpdateTime.Text = string.Empty;
            tbFormExcursionUpdateTime.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionUpdateCost()
        {
            tbFormExcursionUpdateCost.Text = "Введите стоимость";
            tbFormExcursionUpdateCost.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionUpdateCost()
        {
            tbFormExcursionUpdateCost.Text = string.Empty;
            tbFormExcursionUpdateCost.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionUpdateNote()
        {
            tbFormExcursionUpdateNote.Text = "Введите заметку";
            tbFormExcursionUpdateNote.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionUpdateNote()
        {
            tbFormExcursionUpdateNote.Text = string.Empty;
            tbFormExcursionUpdateNote.ForeColor = Color.Black;
        }
        private void tbFormExcursionUpdateName_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionUpdateName();
        }
        private void tbFormExcursionUpdateRating_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionUpdateRating();
        }
        private void tbFormExcursionUpdateLength_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionUpdateLength();
        }
        private void tbFormExcursionUpdateTime_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionUpdateTime();
        }
        private void tbFormExcursionUpdateCost_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionUpdateCost();
        }
        private void tbFormExcursionUpdateNote_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionUpdateNote();
        }
        private void tbFormExcursionUpdateName_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionUpdateName.Text == string.Empty)
                LoadtbFormExcursionUpdateName();
        }
        private void tbFormExcursionUpdateRating_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionUpdateRating.Text == string.Empty)
                LoadtbFormExcursionUpdateRating();
        }
        private void tbFormExcursionUpdateLength_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionUpdateLength.Text == string.Empty)
                LoadtbFormExcursionUpdateLength();
        }
        private void tbFormExcursionUpdateTime_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionUpdateTime.Text == string.Empty)
                LoadtbFormExcursionUpdateTime();
        }
        private void tbFormExcursionUpdateCost_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionUpdateCost.Text == string.Empty)
                LoadtbFormExcursionUpdateCost();
        }
        private void tbFormExcursionUpdateNote_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionUpdateNote.Text == string.Empty)
                LoadtbFormExcursionUpdateNote();
        }
        private void btnFormExcursionUpdateUpdate_Click(object sender, EventArgs e)
        {           
            dataBaseFunction.ExcurtionUpdate(tbFormExcursionUpdateName.Text, tbFormExcursionUpdateRating.Text,
                tbFormExcursionUpdateLength.Text, tbFormExcursionUpdateTime.Text, 
                tbFormExcursionUpdateCost.Text, tbFormExcursionUpdateNote.Text, cell);
            mainMenu2.TableAdapterExcursion.Fill(mainMenu2.DBDataSet.Excursion);
        }
    }
}
