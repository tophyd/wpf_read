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
using System.Xml;

namespace crWordForms
{
    public partial class InsertUPS : Form, ISubjectArm {
        private readonly List<dataUPS> dataUps;
        private dataUPS localUps;
        private readonly MainFormSourceData form;
        public InsertUPS(MainFormSourceData form)
        {
            InitializeComponent();
            localUps=new dataUPS();
            dataUps=new List<dataUPS>();
            this.form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++) {
                dataUPS local=new dataUPS();
                local.typeUps = dataGridView1.Rows[i].Cells[0].Value.ToString();
                local.ipUps = dataGridView1.Rows[i].Cells[1].Value.ToString();
                dataUps.Add(local);

                var subject = new subjectUPS(local);
                subject.register(form);
                subject.notify();
            }


            DataContractSerializer ups_osn = new DataContractSerializer(typeof(List<dataUPS>));
            var settings = new XmlWriterSettings { Indent = true };
            using (var w = XmlWriter.Create("ups.xml", settings))
            ups_osn.WriteObject(w,dataUps);
            
            //using (Stream s = File.Create("ups.xml"))
            //    ups_osn.WriteObject(s, dataUps);
            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //localUps.typeUps=
            string typeups = textBox1.Text+ "("+numericUpDown1.Text+comboBox2.Text+") "+comboBox1.Text+numericUpDown2.Text;
            string ip = ipAddressControl1.Text;
            dataGridView1.Rows.Add(typeups, ip);
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
