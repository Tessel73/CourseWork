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
    public partial class FormClient : Form
    {              
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        
        public FormClient()
        {
            InitializeComponent();                    
        }        
        private void btnFormClientExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFormClientAdd_Click(object sender, EventArgs e)
        {
            FormClientAdd formClientAdd = new FormClientAdd();
            formClientAdd.formClient2 = this;
            formClientAdd.ShowDialog();
        }
        private void FormClient_Load(object sender, EventArgs e)
        {           
            this.clientTableAdapter.Fill(this.clientDataSet.Client);
        }
        private void btnFormClientDelete_Click(object sender, EventArgs e)
        {        
            dataBaseFunction.ClientDelete(Convert.ToInt32(dataGridViewClient.CurrentRow.Cells[0].Value));
            this.clientTableAdapter.Fill(this.clientDataSet.Client);
        }  
        public void btnFormClientUpdate_Click(object sender, EventArgs e)
        {                 
            FormClientUpdate formClientUpdate = new FormClientUpdate(Convert.ToInt32(dataGridViewClient.CurrentRow.Cells[0].Value));            
            formClientUpdate.formClient2 = this;
            formClientUpdate.ShowDialog();
        }
    }
}
