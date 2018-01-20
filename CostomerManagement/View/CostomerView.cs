using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostomerManagement.Control;
using System.Data;
using System.Windows.Forms;

namespace CostomerManagement.View
{
    class CostomerView
    {
        private DbContorl dbc;
        private Form view;
        private CostomerDialog cb;
        private CostomerControl costomerControl;
        private int CostomerIndex;

        public int _costomerIndex
        {
            get
            {
                return CostomerIndex;
            }
            set
            {
                CostomerIndex = value;
            }
        }

        public CostomerView()
        {
            dbc = new DbContorl();
            costomerControl = new CostomerControl();
            viewcreate();
        }


        public DataSet getCostomerLookup()
        {
            return dbc.Select(DbContorl.DbworkName.LookupCostomer);
        }

        public DataSet getLentalLookup()
        {
            return dbc.Select(DbContorl.DbworkName.LookupLental);
        }

        public DataSet getRepairLookup()
        {
            return dbc.LookupRepair();
            
        }

        public DataSet getManufactureLookup()
        {
            return dbc.LookupManufacture();
        }

        public DataSet getBycicleLookup()
        {
            return dbc.LookupBycicle();
        }

        public DataSet getPartLookup()
        {
            return dbc.LookupPart();
        }

        public DataSet getInsertCostomer(string name,string address, string phone)
        {
            dbc.InsertCostomer(name, address, phone);
            return getCostomerLookup();

        }

        public void getDeleteCostomer(int num)
        {
            dbc.DeleteCostomer(num);
        }

        public void getUpdateCostomer(int index , string name, string address, string phone)
        {
            dbc.UpdateCostomer(index, name, address, phone);
        }

        public void CostomerView_CellClikck_costomer(object sender, EventArgs e)
        {
            System.Console.WriteLine("CellClick Event");
            view.ShowDialog();

        }

        public void viewcreate()
        {
            view = new Form();
            view.TopLevel = true;
            view.Size = new System.Drawing.Size(280, 200);
            view.StartPosition = FormStartPosition.CenterParent;
            view.FormBorderStyle = FormBorderStyle.None;

            cb = new CostomerDialog();
   
            System.Windows.Forms.Control[] c = { cb };

            view.Controls.AddRange(c );

            cb.Close_eventhandler += btn_close_Click;
            cb.Insert_eventhandler += btn_insert_Click;


        }

        public void btn_close_Click(object sender, EventArgs e)
        {
            view.Close();
            resetsetCostomerDialogValue();
        }

        public void btn_insert_Click(object sender, EventArgs e)
        {
            if (cb.LableText.Equals("회원추가"))
            {

                getInsertCostomer(cb._name, cb._address, cb._phoen);
                resetsetCostomerDialogValue();
            }

            else if (cb.LableText.Equals("회원정보 수정"))
            {
                getUpdateCostomer(this.CostomerIndex, cb._name, cb._address, cb._phoen);
                resetsetCostomerDialogValue();
            }
               
        }


        public void setCostomerDialogLabel(string text)
        {
            cb.LableText = text;
        }

        public void setCostomerDialogValue(string name, string address, string phoen)
        {
            cb._name = name;
            cb._address = address;
            cb._phoen = phoen;
        }

        public void resetsetCostomerDialogValue()
        {
            setCostomerDialogValue("", "", "");
        }

        public DataTable setCostomerFilter(DataTable dataTable, string filterText)
        {
            return costomerControl.getCostomerFilter(dataTable, filterText);
        }



    }
}
