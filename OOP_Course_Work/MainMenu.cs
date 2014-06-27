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
    public partial class MainMenu : Form
    {
        public DataBaseFunction dataBaseFunction = new DataBaseFunction();
        public MainMenu()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.TableAdapterExcursion.Fill(this.DBDataSet.Excursion);
            this.TableAdapterTur.Fill(this.DBDataSet.Tur);
            this.TableAdapterClient.Fill(this.DBDataSet.Client);
            this.TableAdapterHotel.Fill(this.DBDataSet.Hotel);
            this.TableAdapterContract.Fill(this.DBDataSet.Contract);
        }
        private void btnFormClientAdd_Click(object sender, EventArgs e)
        {
            FormClientAdd formClientAdd = new FormClientAdd();
            formClientAdd.mainMenu2 = this;
            formClientAdd.ShowDialog();
        }
        private void btnFormTurUpdate_Click(object sender, EventArgs e)
        {
            FormTurUpdate formTurUpdate = new FormTurUpdate(Convert.ToInt32(dataGridViewTur.CurrentRow.Cells[0].Value));
            formTurUpdate.mainMenu2 = this;
            formTurUpdate.ShowDialog();
        }
        private void btnFormTurAdd_Click(object sender, EventArgs e)
        {
            FormTurAdd formTurAdd = new FormTurAdd();
            formTurAdd.mainMenu2 = this;
            formTurAdd.ShowDialog();
        }
        private void btnFormClientUpdate_Click(object sender, EventArgs e)
        {
            FormClientUpdate formClientUpdate = new FormClientUpdate(Convert.ToInt32(dataGridViewClient.CurrentRow.Cells[3].Value));
            formClientUpdate.mainMenu2 = this;
            formClientUpdate.ShowDialog();
        }
        private void btnFormClientDelete_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ClientDelete(Convert.ToInt32(dataGridViewClient.CurrentRow.Cells[3].Value));
            this.TableAdapterClient.Fill(this.DBDataSet.Client);
        }
        private void btnFormContractAdd_Click(object sender, EventArgs e)
        {
            FormContractAdd formContractAdd = new FormContractAdd();
            formContractAdd.mainMenu2 = this;
            formContractAdd.ShowDialog();
        }
        private void btnFormContractUpdate_Click(object sender, EventArgs e)
        {
            FormContractUpdate formContractUpdate = new FormContractUpdate(Convert.ToInt32(dataGridViewContract.CurrentRow.Cells[6].Value));
            formContractUpdate.mainMenu2 = this;
            formContractUpdate.ShowDialog();
        }
        private void btnFormContractDelete_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ContractDelete(Convert.ToInt32(dataGridViewContract.CurrentRow.Cells[6].Value));
            this.TableAdapterContract.Fill(this.DBDataSet.Contract);
        }

        private void btnFormTurDelete_Click(object sender, EventArgs e)
        {
            dataBaseFunction.TurDelete(Convert.ToInt32(dataGridViewTur.CurrentRow.Cells[0].Value));
            this.TableAdapterTur.Fill(this.DBDataSet.Tur);
        }
        private void btnFormHotelAdd_Click(object sender, EventArgs e)
        {
            FormHotelAdd formHotelAdd = new FormHotelAdd();
            formHotelAdd.mainMenu2 = this;
            formHotelAdd.ShowDialog();
        }
        private void btnFormHotelUpdate_Click(object sender, EventArgs e)
        {
            FormHotelUpdate formHotelUpdate = new FormHotelUpdate(Convert.ToInt32(dataGridViewHotel.CurrentRow.Cells[4].Value));
            formHotelUpdate.ShowDialog();
        }
        private void btnFormHotelDelete_Click(object sender, EventArgs e)
        {
            dataBaseFunction.HotelDelete(Convert.ToInt32(dataGridViewHotel.CurrentRow.Cells[4].Value));
            this.TableAdapterHotel.Fill(this.DBDataSet.Hotel);
        }
        private void btnFormExcursionAdd_Click(object sender, EventArgs e)
        {
            FormExcursionAdd formExcursionAdd = new FormExcursionAdd();
            formExcursionAdd.mainMenu2 = this;
            formExcursionAdd.ShowDialog();
        }
        private void btnFormExcursionUpdate_Click(object sender, EventArgs e)
        {
            FormExcursionUpdate formExcursionUpdate = new FormExcursionUpdate(Convert.ToInt32(dataGridViewExcursion.CurrentRow.Cells[6].Value));
            formExcursionUpdate.ShowDialog();
        }
        private void btnFormExcursionDelete_Click(object sender, EventArgs e)
        {
            dataBaseFunction.ExcursionDelete(Convert.ToInt32(dataGridViewExcursion.CurrentRow.Cells[6].Value));
            this.TableAdapterExcursion.Fill(this.DBDataSet.Excursion);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того чтобы редактировать запись из базы данных выберите нужную строку и нажмите на клавишу \"Обновить\". В появившемся диалоговом окне введите новые данные. \n Для того, чтобы удалить запись из базы данных выберите нужную строку и нажмите на клавишу \"Удалить\".");
        }
    }
}
