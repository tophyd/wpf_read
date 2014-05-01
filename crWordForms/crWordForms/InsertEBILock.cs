using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace crWordForms
{
    public partial class InsertEBILock : Form, ISubjectArm {
        //private dataEBIlock dataEbIlock_osn;
        private dataEBIlock dataEbIlock_rez;
        private List<dataEBIlock> list;
        private readonly MainFormSourceData form;
        private DataSet ds;

        public InsertEBILock(dataEBIlock data, MainFormSourceData form, DataSet ds)
        {
            InitializeComponent();
            this.form = form;
            this.dataEbIlock_rez = data;
            this.ds = ds;
            this.ds = ds;
            
            bindingSource1.DataSource = ds.Tables["EBILocks"];
            bindingNavigator1.BindingSource = bindingSource1;

            dataGridViewEBILocks.DataSource = bindingSource1;


        }

        private void InsertEBILock_Load(object sender, EventArgs e) {
            comboBox1.Text = (string) comboBox1.Items[0];
            comboBox2.Text = (string)comboBox1.Items[1];
            list = new List<dataEBIlock>();
            dataEbIlock_rez = new dataEBIlock();

        }

        private void button1_Click(object sender, EventArgs e) {

            var dataEbIlock_osn = new dataEBIlock();
            dataEbIlock_osn.idEbiLock = textBox1.Text;
            dataEbIlock_osn.nameEbiLock = comboBox1.Text;
            dataEbIlock_osn.eswIpEbiLock.Add("ESW1",ipAddressControl1.Text);
            dataEbIlock_osn.eswIpEbiLock.Add("ESW2", ipAddressControl2.Text);
            list.Add(dataEbIlock_osn);
            var subject = new SubjectEBILock(dataEbIlock_osn);
            subject.register(form);
            subject.notify();

            dataEbIlock_rez.idEbiLock = textBox1.Text;
            dataEbIlock_rez.nameEbiLock = comboBox2.Text;
            dataEbIlock_rez.eswIpEbiLock.Add("ESW1", ipAddressControl3.Text);
            dataEbIlock_rez.eswIpEbiLock.Add("ESW2", ipAddressControl4.Text);
            list.Add(dataEbIlock_rez);

            
            
            subject.updateEbilock(dataEbIlock_rez);
            subject.notify();


            DataContractSerializer ds_osn = new DataContractSerializer(typeof(dataEBIlock));
            using (Stream s = File.Create("EBILock_osn.xml"))
                ds_osn.WriteObject(s, dataEbIlock_osn);

            DataContractSerializer ds_rez = new DataContractSerializer(typeof(dataEBIlock));
            using (Stream s = File.Create("EBILock_rez.xml"))
                ds_rez.WriteObject(s, dataEbIlock_rez);
            Close();



        }

        public void register(IView view) {
            throw new NotImplementedException();
        }

        public void remove(IView view) {
            throw new NotImplementedException();
        }

        public void notify() {
            throw new NotImplementedException();
        }
    }
}
