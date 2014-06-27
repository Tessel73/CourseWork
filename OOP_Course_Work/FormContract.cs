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
    public partial class FormContract : Form
    {
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public FormContract()
        {
            InitializeComponent();
        }
        private void btnFormContractExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFormContractDelete_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ContractDelete(Convert.ToInt32(dataGridViewContract.CurrentRow.Cells[0].Value));
            this.ContractTableAdapter.Fill(this.ContractDataSet.Contract);     
        }
        private void FormContract_Load(object sender, EventArgs e)
        {           
            this.ContractTableAdapter.Fill(this.ContractDataSet.Contract);
        }
        private void btnFormContractAdd_Click(object sender, EventArgs e)
        {
            FormContractAdd formContractAdd = new FormContractAdd();
            formContractAdd.formContract2 = this;
            formContractAdd.ShowDialog();
        }
        private void btnFormContractUpdate_Click(object sender, EventArgs e)
        {
            FormContractUpdate formContractUpdate = new FormContractUpdate(Convert.ToInt32(dataGridViewContract.CurrentRow.Cells[0].Value));
            formContractUpdate.formContract2 = this;
            formContractUpdate.ShowDialog();
        }
    }
}
