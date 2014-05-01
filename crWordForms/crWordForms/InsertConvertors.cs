using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace crWordForms
{
    public partial class InsertConvertors : Form, ISubjectArm {
        //private DataTable dt;
        private readonly MainFormSourceData form;
        private readonly List<dataConnector> dataConnectors; 
        public InsertConvertors(MainFormSourceData form)
        {
            InitializeComponent();
            this.form = form;
            dataConnectors=new List<dataConnector>();
        }

        private void insertConvertors_Load(object sender, EventArgs e) {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // dataConnector local=new dataConnector();
            int countRows = dataGridView1.RowCount-1;
            //MessageBox.Show(countRows.ToString(CultureInfo.InvariantCulture));
            for (int i = 0; i < countRows; i++) {
               // dataGridView1.Rows[i].Cells[0].Value.ToString();
                var local = new dataConnector {
                    connector = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    port = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    senderid = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    usingIf = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    speedup = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    remark = dataGridView1.Rows[i].Cells[5].Value.ToString()
                };

                var subject = new subjectConnectors(local);
                subject.register(form);
                subject.notify();

                dataConnectors.Add(local);
                for (int j = 0; j < dataGridView1.ColumnCount; j++) {
                    //dataConnector local = new dataConnector();
                    Dictionary<string, string> localDictionary=new Dictionary<string, string>();
                    localDictionary[dataGridView1.Rows[0].ToString()] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }


            }

            DataContractSerializer dc_osn = new DataContractSerializer(typeof(List<dataConnector>));
            using (Stream s = File.Create("connectors.xml"))
                dc_osn.WriteObject(s, dataConnectors);

            Close();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            }

            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) {
            string connector = comboBox1.Text;
            string port = comboBox2.Text+"(" +comboBox3.Text+")";
            string senderid = numericUpDown1.Text + "/("+numericUpDown2.Text+")";
            string using_if = comboBox4.Text;
            string speedup = comboBox5.Text;
            dataGridView1.Rows.Add(connector, port, senderid, using_if,speedup, textBox1.Text);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            //comboBox2.Enabled = false;
            //comboBox3.Enabled = false;

            if (comboBox2.Enabled && comboBox3.Enabled) {
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Text = "";
                comboBox3.Text = "";
            }
            else {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            comboBox5.Text = "";
            comboBox5.Enabled = !comboBox5.Enabled;
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
