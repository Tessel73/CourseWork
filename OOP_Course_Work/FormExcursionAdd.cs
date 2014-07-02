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
    public partial class FormExcursionAdd : Form
    {
        public MainMenu mainMenu2 = new MainMenu();
        public FormExcursionAdd()
        {
            InitializeComponent();
        }
        private void btnFormExcursionAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormExcursionAdd_Load(object sender, EventArgs e)
        {
            LoadtbFormExcursionAddRating();
            LoadtbFormExcursionAddName();
            LoadtbFormExcursionAddTime();
            LoadtbFormExcursionAddLength();
            LoadtbFormExcursionAddNote();
            LoadtbFormExcursionAddCost();
        }
        private void LoadtbFormExcursionAddName()
        {
            tbFormExcursionAddName.Text = "Введите имя";
            tbFormExcursionAddName.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionAddName()
        {
            tbFormExcursionAddName.Text = string.Empty;
            tbFormExcursionAddName.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionAddRating()
        {
            tbFormExcursionAddRating.Text = "Введите рейтинг (целое число)";
            tbFormExcursionAddRating.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionAddRating()
        {
            tbFormExcursionAddRating.Text = string.Empty;
            tbFormExcursionAddRating.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionAddLength()
        {
            tbFormExcursionAddLength.Text = "Введите продолжительность (ЧЧ:ММ)";
            tbFormExcursionAddLength.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionAddLength()
        {
            tbFormExcursionAddLength.Text = string.Empty;
            tbFormExcursionAddLength.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionAddTime()
        {
            tbFormExcursionAddTime.Text = "Введите время (ЧЧ:ММ)";
            tbFormExcursionAddTime.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionAddTime()
        {
            tbFormExcursionAddTime.Text = string.Empty;
            tbFormExcursionAddTime.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionAddCost()
        {
            tbFormExcursionAddCost.Text = "Введите стоимость";
            tbFormExcursionAddCost.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionAddCost()
        {
            tbFormExcursionAddCost.Text = string.Empty;
            tbFormExcursionAddCost.ForeColor = Color.Black;
        }
        private void LoadtbFormExcursionAddNote()
        {
            tbFormExcursionAddNote.Text = "Введите заметку (не обязательно)";
            tbFormExcursionAddNote.ForeColor = Color.Gray;
        }
        private void EntertbFormExcursionAddNote()
        {
            tbFormExcursionAddNote.Text = string.Empty;
            tbFormExcursionAddNote.ForeColor = Color.Black;
        }
        private void tbFormExcursionAddName_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionAddName();
        }
        private void tbFormExcursionAddRating_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionAddRating();
        }
        private void tbFormExcursionAddLength_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionAddLength();
        }
        private void tbFormExcursionAddTime_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionAddTime();
        }
        private void tbFormExcursionAddCost_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionAddCost();
        }
        private void tbFormExcursionAddNote_Enter(object sender, EventArgs e)
        {
            EntertbFormExcursionAddNote();
        }
        private void tbFormExcursionAddName_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionAddName.Text == string.Empty)
                LoadtbFormExcursionAddName();
        }
        private void tbFormExcursionAddRating_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionAddRating.Text == string.Empty)
                LoadtbFormExcursionAddRating();
        }
        private void tbFormExcursionAddLength_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionAddLength.Text == string.Empty)
                LoadtbFormExcursionAddLength();
        }
        private void tbFormExcursionAddTime_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionAddTime.Text == string.Empty)
                LoadtbFormExcursionAddTime();
        }
        private void tbFormExcursionAddCost_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionAddCost.Text == string.Empty)
                LoadtbFormExcursionAddCost();
        }
        private void tbFormExcursionAddNote_Leave(object sender, EventArgs e)
        {
            if (tbFormExcursionAddNote.Text == string.Empty)
                LoadtbFormExcursionAddNote();
        }
        private void btnFormExcursionAddAdd_Click(object sender, EventArgs e)
        {
            DataBaseFunction dataBaseFunction = new DataBaseFunction();
            dataBaseFunction.ExcursionAdd(tbFormExcursionAddName.Text,tbFormExcursionAddRating.Text,
            tbFormExcursionAddLength.Text,tbFormExcursionAddTime.Text,tbFormExcursionAddCost.Text,tbFormExcursionAddNote.Text);
            mainMenu2.TableAdapterExcursion.Fill(mainMenu2.DBDataSet.Excursion);
        }
    }
}
