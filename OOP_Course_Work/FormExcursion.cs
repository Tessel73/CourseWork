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
    public partial class FormExcursion : Form
    {
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public FormExcursion()
        {
            InitializeComponent();         
        }
        private void btnFormExcursionExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormExcursion_Load(object sender, EventArgs e)
        {
            this.ExcursionTableAdapter.Fill(this.ExcursionDataSet.Excursion);
        }
        private void btnFormExcursionDelete_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ExcursionDelete(Convert.ToInt32(dataGridViewExcursion.CurrentRow.Cells[0].Value));
            this.ExcursionTableAdapter.Fill(this.ExcursionDataSet.Excursion);
        }
        private void btnFormExcursionAdd_Click(object sender, EventArgs e)
        {
           FormExcursionAdd formExcursionAdd = new FormExcursionAdd();
           formExcursionAdd.formExcursion2 = this;
           formExcursionAdd.ShowDialog();
        }
        private void btnFormExcursionUpdate_Click(object sender, EventArgs e)
        {
            FormExcursionUpdate formExcursionUpdate = new FormExcursionUpdate(Convert.ToInt32(dataGridViewExcursion.CurrentRow.Cells[0].Value));
            formExcursionUpdate.ShowDialog();
        }
    }
}

