using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostomerManagement.Model;
using System.Data;

namespace CostomerManagement.Control
{
    class CostomerControl
    {
     

        public DataTable getCostomerFilter(DataTable datatable, string filterText)
        {

            datatable.DefaultView.RowFilter = string.Format("이름 LIKE '%{0}%'", filterText);

            return datatable;
        }


    }
}
