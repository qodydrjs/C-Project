using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomerManagement.Model
{
    class Costomer
    {
        private string name;
        private string address;
        private string phonenum;
        private int ID;

        public Costomer(string name, string address, string phonenum, int ID)
        {
            this.name = name;
            this.address = address;
            this.phonenum = phonenum;
            this.ID = ID;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public void setPhonenum(string phonenum)
        {
            this.phonenum = phonenum;
        }

        public Costomer GetCostomer(string ID)
        {


            return this;
        }
    }
}
