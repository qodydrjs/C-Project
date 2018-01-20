using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CostomerManagement.View;


namespace CostomerManagement
{
    public partial class CostomerForm : Form
    {
        private CostomerView costomerview;
       // private event EventHandler<DataGridViewCellMouseEventArgs> costomergrid;
        private string name;
        private string address;
        private string phone;
        private DataTable dataTable;
       

        public CostomerForm()
        {
            InitializeComponent();
            costomerview = new CostomerView();
        }

        private void btn_costomer_Click(object sender, EventArgs e)
        {
            dataTable = costomerview.getCostomerLookup().Tables[0];
            this.dataGridView_costomerLookup.DataSource = dataTable;
        }

        private void btn_rentalLookup_Click(object sender, EventArgs e)
        {
            this.dataGridView_lentalLookup.DataSource = costomerview.getLentalLookup().Tables[0];
        }

        

        private void dataGridView_costomerLookup_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var num = this.dataGridView_costomerLookup.SelectedCells[0].Value;
            name = this.dataGridView_costomerLookup.SelectedCells[1].Value.ToString();
            address = this.dataGridView_costomerLookup.SelectedCells[2].Value.ToString();
            phone = this.dataGridView_costomerLookup.SelectedCells[3].Value.ToString();

            costomerview.setCostomerDialogLabel("회원정보 수정");
            costomerview.setCostomerDialogValue(name,address,phone);
            costomerview._costomerIndex = (int)num;
            costomerview.CostomerView_CellClikck_costomer(null, null);
            btn_costomer_Click(null, null);
        }

        private void CostomerForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_costomerLookup_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void btn_costomerInsert_Click(object sender, EventArgs e)
        {
            costomerview.setCostomerDialogLabel("회원추가");
            costomerview.CostomerView_CellClikck_costomer(null, null);
            btn_costomer_Click(null, null);
            
        }

        private void btn_costomerDelete_Click(object sender, EventArgs e)
        {

            if(this.dataGridView_costomerLookup.SelectedRows.Count > 0)
            {
                var num = this.dataGridView_costomerLookup.SelectedCells[0].Value;

                costomerview.getDeleteCostomer((int)num);
                btn_costomer_Click(null, null);
            }

            
        }

        private void textbox_name_TextChanged(object sender, EventArgs e)
        {

            TextBox textBox = sender as TextBox;



             if (dataTable != null)
                costomerview.setCostomerFilter(dataTable, textBox.Text);
        }

        private void btn_lookupRepair_Click(object sender, EventArgs e)
        {
            this.dataGridView_repair.DataSource = costomerview.getRepairLookup().Tables[0];
        }

        private void btn_LookupManufacture_Click(object sender, EventArgs e)
        {
            this.dataGridView_Manufacture.DataSource = costomerview.getManufactureLookup().Tables[0];
        }

        private void btn_LookupBycicle_Click(object sender, EventArgs e)
        {
            this.dataGridView_Bycicle.DataSource = costomerview.getBycicleLookup().Tables[0];
        }

        private void btn_LookupPart_Click(object sender, EventArgs e)
        {
            this.dataGridView_Part.DataSource = costomerview.getPartLookup().Tables[0];
        }
    }
}
