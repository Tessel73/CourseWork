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
    public partial class FormTurDelete : Form
    {
        public FormTurDelete()
        {
            InitializeComponent();
        }
        private void FormTurDelete_Load(object sender, EventArgs e)
        {
            LoadtbFormTurDeleteDateI();
            LoadtbFormTurDeleteDateO();
            LoadtbFormTurDeletePlace();
            LoadtbFormTurDeleteD_N();
            LoadtbFormTurDeleteCost();
        }
        private void LoadtbFormTurDeletePlace()
        {
            tbFormTurDeletePlace.Text = "Введите город (страну)";
            tbFormTurDeletePlace.ForeColor = Color.Gray;
        }
        private void EntertbFormTurDeletePlace()
        {
            tbFormTurDeletePlace.Text = string.Empty;
            tbFormTurDeletePlace.ForeColor = Color.Black;
        }
        private void LoadtbFormTurDeleteDateI()
        {
            tbFormTurDeleteDateI.Text = "Введите дату прибытия";
            tbFormTurDeleteDateI.ForeColor = Color.Gray;
        }
        private void EntertbFormTurDeleteDateI()
        {
            tbFormTurDeleteDateI.Text = string.Empty;
            tbFormTurDeleteDateI.ForeColor = Color.Black;
        }
        private void LoadtbFormTurDeleteDateO()
        {
            tbFormTurDeleteDateO.Text = "Введите дату отправления";
            tbFormTurDeleteDateO.ForeColor = Color.Gray;
        }
        private void EntertbFormTurDeleteDateO()
        {
            tbFormTurDeleteDateO.Text = string.Empty;
            tbFormTurDeleteDateO.ForeColor = Color.Black;
        }
        private void LoadtbFormTurDeleteD_N()
        {
            tbFormTurDeleteD_N.Text = "Введите количество дней/ночей";
            tbFormTurDeleteD_N.ForeColor = Color.Gray;
        }
        private void EntertbFormTurDeleteD_N()
        {
            tbFormTurDeleteD_N.Text = string.Empty;
            tbFormTurDeleteD_N.ForeColor = Color.Black;
        }
        private void LoadtbFormTurDeleteCost()
        {
            tbFormTurDeleteCost.Text = "Введите стоимость";
            tbFormTurDeleteCost.ForeColor = Color.Gray;
        }
        private void EntertbFormTurDeleteCost()
        {
            tbFormTurDeleteCost.Text = string.Empty;
            tbFormTurDeleteCost.ForeColor = Color.Black;
        }

        private void tbFormTurDeletePlace_Enter(object sender, EventArgs e)
        {
            EntertbFormTurDeletePlace();
        }
        private void tbFormTurDeleteDateO_Enter(object sender, EventArgs e)
        {
            EntertbFormTurDeleteDateO();
        }
        private void tbFormTurDeleteDateI_Enter(object sender, EventArgs e)
        {
            EntertbFormTurDeleteDateI();
        }
        private void tbFormTurDeleteD_N_Enter(object sender, EventArgs e)
        {
            EntertbFormTurDeleteD_N();
        }
        private void tbFormTurDeleteCost_Enter(object sender, EventArgs e)
        {
            EntertbFormTurDeleteCost();
        }
        private void tbFormTurDeletePlace_Leave(object sender, EventArgs e)
        {
            if (tbFormTurDeletePlace.Text == string.Empty)
                LoadtbFormTurDeletePlace();
        }
        private void tbFormTurDeleteDateO_Leave(object sender, EventArgs e)
        {
            if (tbFormTurDeleteDateO.Text == string.Empty)
                LoadtbFormTurDeleteDateO();
        }
        private void tbFormTurDeleteDateI_Leave(object sender, EventArgs e)
        {
            if (tbFormTurDeleteDateI.Text == string.Empty)
                LoadtbFormTurDeleteDateI();
        }
        private void tbFormTurDeleteD_N_Leave(object sender, EventArgs e)
        {
            if (tbFormTurDeleteD_N.Text == string.Empty)
                LoadtbFormTurDeleteD_N();
        }
        private void tbFormTurDeleteCost_Leave(object sender, EventArgs e)
        {
            if (tbFormTurDeleteCost.Text == string.Empty)
                LoadtbFormTurDeleteCost();
        }

        private void btnFormTurDeleteExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFormTurDeleteDelete_Click(object sender, EventArgs e)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                List<Tur> Turs = context.Tur.Where(place => place.Place == tbFormTurDeletePlace.Text).Where
                    (dateO => dateO.DateO == tbFormTurDeleteDateO.Text).ToList();
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Тур удален!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
    }
}
