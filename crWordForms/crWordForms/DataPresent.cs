using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace crWordForms
{
    class DataPresent {
        private DataSet ds;

        public DataPresent(DataSet ds) {
            this.ds = ds;
        }

        public DataPresent() {
            ds=new DataSet();
        }

        public DataPresent(string name) {
            this.name = name;

        }

        public DataPresent(string name, DataSet ds) {
            this.name = name;
            this.ds = ds;
            
        }

        public DataSet dsSet { set;  get; }
   

        public string name { get; set; }
    }
}
