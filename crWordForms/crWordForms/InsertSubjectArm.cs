using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using  System.Runtime.Serialization;

namespace crWordForms
{
    public partial class InsertSubjectArm : Form, ISubjectArm {
        private List<IView> seList;
        private RefBuff refBuff;
        private static int count = 0;
        private dataARM arm=new dataARM();
        private readonly MainFormSourceData form;

        private string xmlsave = @"data_arm.xml";
        private FileStream xmlStream;
        private DataSet ds;
        private DataTable table;

        public InsertSubjectArm(dataARM arm, MainFormSourceData form, DataSet ds)
        {
            
            InitializeComponent();
            this.arm = arm;
            this.form = form;
            this.ds = ds;
            //table = ds.Tables["ARMS"];
            //dataGridView1.DataSource = table;
            bindingSource1.DataSource = ds.Tables["ARMS"];
            bindingNavigator1.BindingSource = bindingSource1;
            
            dataGridView1.DataSource = bindingSource1;
            


        }

        private void insertARM_Load(object sender, EventArgs e)
        {

        }

        public void register(IView view) {
            seList.Add(view);

        }

        public void remove(IView view) {
            int i = seList.IndexOf(view);

        }

        public void notify() {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            //refBuff.mess = count.ToString();
            
            
            dataARM toDataArm=new dataARM();
            Dictionary<string, string> lans=new Dictionary<string, string>( );
            lans.Add(lanBox1.Text, ipAddressControl1.Text);
            lans.Add(lanBox2.Text, ipAddressControl2.Text);
            toDataArm.Lan1 = ipAddressControl1.Text;
            toDataArm.Lan2 = ipAddressControl2.Text;
            toDataArm.LAN = "LAN1: "+ipAddressControl1.Text + " LAN2: " + ipAddressControl2.Text;
            toDataArm.nameArm = nameARMBox.Text;
            toDataArm.numberLan = lans;
            //toDataArm.numberLan.Add(textBox2.Text, ipLAN2Box.Text);
            toDataArm.password = passwordBox.Text;
            toDataArm.pwrOn = pwrComboBox.Text;
            toDataArm.senderId = numericUpDown1.Text+"/"+numericUpDown2.Text;
            toDataArm.numberVideo = numericUpDown3.Text+"("+numericUpDown4.Text+")";

            //servicesCheckedListBox.CheckedItems.ToString();

            for (int i = servicesCheckedListBox.Items.Count - 1; i >= 0; i--) {
                if (servicesCheckedListBox.GetItemChecked(i)) {
                    var str = servicesCheckedListBox.Items[i];
                    //MessageBox.Show(str.ToString());
                    toDataArm.servicesRun[str.ToString()] = true;
                }
            }
            //dataGridView1.Rows.Add(toDataArm.nameArm, toDataArm.numberLan.ToString(), toDataArm.password,
            //    toDataArm.pwrOn, toDataArm.senderId, toDataArm.numberVideo, toDataArm.servicesRun.ToString());
            //bindingNavigator1.AddNewItem(toDataArm.nameArm);
            
            subjectARM subject=new subjectARM(toDataArm);
            
            subject.register(form);
            subject.notify();

            arm = toDataArm;

            //DataTable table = this.ds.Tables["ARMS"];
            //DataRow armRow = table.NewRow();
            //armRow["ARMName"] = toDataArm.nameArm;
            //armRow["LAN"] = addLan(arm.numberLan);
            //armRow["Password"] = arm.password;
            //armRow["PowerON"] = arm.pwrOn;
            //armRow["Video"] = arm.numberVideo;
            //armRow["Services"] = addService(arm.servicesRun);
            //try {
            //    table.Rows.Add(armRow);
            //}
            //catch (Exception exception) {
            //    MessageBox.Show(exception.Message);
            //}
            DataContractSerializer ds=new DataContractSerializer(typeof(dataARM) );
            using (Stream s=File.Create("ARM.xml"))
            ds.WriteObject(s, toDataArm);


            
            //Close();


        }
        private string addLan(Dictionary<string, string> numberLan) {
            return numberLan.Aggregate<KeyValuePair<string, string>, string>(null, (current, lan) => current + (lan.Key + " : " + lan.Value));
        }

        private string addService(Dictionary<string, bool> servicesRun)
        {

            return servicesRun.Where(key => key.Value == true).Aggregate("", (current, key) => current + (key.Key + " "));
        }

        private void nameARMBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
