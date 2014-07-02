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
    public partial class FormContractPDF : Form
    {
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public FormContractPDF()
        {
            InitializeComponent();
        }

        private void btnFormContractPDFExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFormContractPDF_Click(object sender, EventArgs e)
        {
            dataBaseFunction.SelectContract(Convert.ToDateTime(tbFormContractPDFDate1.Text), 
                Convert.ToDateTime(tbFormContractPDFDate2.Text));
        }
        private void LoadtbFormContractPDFDate1()
        {
            tbFormContractPDFDate1.Text = "Введите дату начала (ДД.ММ.ГГ)";
            tbFormContractPDFDate1.ForeColor = Color.Gray;
        }
        private void EntertbFormContractPDFDate1()
        {
            tbFormContractPDFDate1.Text = string.Empty;
            tbFormContractPDFDate1.ForeColor = Color.Black;
        }
        private void LoadtbFormContractPDFDate2()
        {
            tbFormContractPDFDate2.Text = "Введите дату окончания (ДД.ММ.ГГ)";
            tbFormContractPDFDate2.ForeColor = Color.Gray;
        }
        private void EntertbFormContractPDFDate2()
        {
            tbFormContractPDFDate2.Text = string.Empty;
            tbFormContractPDFDate2.ForeColor = Color.Black;
        }

        private void FormContractPDF_Load(object sender, EventArgs e)
        {
            LoadtbFormContractPDFDate1();
            LoadtbFormContractPDFDate2();
        }

        private void tbFormContractPDFDate1_Enter(object sender, EventArgs e)
        {
            EntertbFormContractPDFDate1();
        }

        private void tbFormContractPDFDate1_Leave(object sender, EventArgs e)
        {
            if (tbFormContractPDFDate1.Text == string.Empty)
            LoadtbFormContractPDFDate1();
        }

        private void tbFormContractPDFDate2_Leave(object sender, EventArgs e)
        {
            if (tbFormContractPDFDate2.Text == string.Empty)
            LoadtbFormContractPDFDate2();
        }

        private void tbFormContractPDFDate2_Enter(object sender, EventArgs e)
        {
            EntertbFormContractPDFDate2();
        }
    }
}
