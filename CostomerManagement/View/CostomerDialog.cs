using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostomerManagement.View
{
    public partial class CostomerDialog : UserControl
    {
        public event EventHandler Close_eventhandler;
        public event EventHandler Insert_eventhandler;
        

        public CostomerDialog()
        {
            InitializeComponent();
            
        }


        public string LableText
        {
            get
            {
                return label1.Text.ToString();
            }
            set
            {
                label1.Text = value;
            }
        }

        public string _name
        {
            get
            {
                return tb_name.Text;
            }
            set
            {
                tb_name.Text = value;
            }
        }
        public string _address
        {
            get
            {
                return tb_address.Text;
            }
            set
            {
                tb_address.Text = value;
            }
        }
        public string _phoen
        {
            get
            {
                return tb_phone.Text;
            }
            set
            {
                tb_phone.Text = value;
            }
        }

        public void btn_close_Click(object sender, EventArgs e)
        {
            Close_eventhandler(null, null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Insert_eventhandler(null, null);
            Close_eventhandler(null, null);
        }
    }
}
