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
    public partial class FormTur : Form
    {
        public DataBaseFunction dateBaseFunction = new DataBaseFunction();    
        public FormTur()
        {
            InitializeComponent();                    
        }
        private void btnFormTurExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormTur_Load(object sender, EventArgs e)
        {         
            this.TurTableAdapter.Fill(this.TurDataSet.Tur);
        }
        private void btnFormTurRenew_Click(object sender, EventArgs e)
        {
            this.TurTableAdapter.Fill(this.TurDataSet.Tur);
        }
        private void btnFormTurAdd_Click(object sender, EventArgs e)
        {
            FormTurAdd formTurAdd = new FormTurAdd();
            formTurAdd.formTur2 = this;
            formTurAdd.ShowDialog();
        }
        private void btnFormTurDelete_Click(object sender, EventArgs e)
           {
            dateBaseFunction.TurDelete(Convert.ToInt32(dataGridViewTur.CurrentRow.Cells[0].Value));
            this.TurTableAdapter.Fill(this.TurDataSet.Tur);
           }
        private void btnFormTurUpdate_Click(object sender, EventArgs e)
           {
               FormTurUpdate formTurUpdate = new FormTurUpdate(Convert.ToInt32(dataGridViewTur.CurrentRow.Cells[0].Value));
            formTurUpdate.formTur2 = this;
            formTurUpdate.ShowDialog();
           }            
        }
    }

