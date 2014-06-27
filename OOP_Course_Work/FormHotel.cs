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
    public partial class FormHotel : Form
    {
        
        public FormHotel()
        {
            InitializeComponent();
        }
        private void FormHotel_Load(object sender, EventArgs e)
        {           
            this.HotelTableAdapter.Fill(this.HotelDataSet.Hotel);
        }
        private void btnFormHotelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFormHotelDelete_Click(object sender, EventArgs e)
        {           
            this.HotelTableAdapter.Fill(this.HotelDataSet.Hotel);
        }
        private void btnFormHotelAdd_Click(object sender, EventArgs e)
        {
            FormHotelAdd formHotelAdd = new FormHotelAdd();
            formHotelAdd.formHotel2 = this;
            formHotelAdd.ShowDialog();
        }
        private void btnFormHotelUpdate_Click(object sender, EventArgs e)
        {
            FormHotelUpdate formHotelUpdate = new FormHotelUpdate(Convert.ToInt32(dataGridViewHotel.CurrentRow.Cells[0].Value));
            formHotelUpdate.ShowDialog();
        }
    }
}
