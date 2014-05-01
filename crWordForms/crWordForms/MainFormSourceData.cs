using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace crWordForms
{
    public partial class MainFormSourceData : Form, IView, IDisplayView
    {
        private dataARM arm;
        private dataEBIlock ebilock;
        private readonly List<dataConnector> connectors; 
        private readonly List<dataARM> armList;
        private readonly List<dataEBIlock> ebilockList;
        private readonly List<dataUPS> upsList;
        private readonly DataSet dataSet;


        public MainFormSourceData(DataSet dataSet)
        {
            InitializeComponent();
            
            arm=new dataARM();
            armList=new List<dataARM>();
            
            ebilock=new dataEBIlock();
            ebilockList = new List<dataEBIlock>();
            
            connectors=new List<dataConnector>();
            
            upsList=new List<dataUPS>();
            this.dataSet = dataSet;
        }

        private void fillDataSet(Object message) {
            if (message is dataARM) {
                getValueArm(message);
                
            }
            if (message is dataEBIlock) {
                getValueEbiLock(message);
            }
            if (message is dataConnector) {
                getValueConnector(message);
            }
            if (message is dataUPS) {
                getValueUps(message);
            }


        }

        private void getValueUps(object message) {
            var table = dataSet.Tables["UPS"];
            var upsRow = table.NewRow();
            var dataUps = (dataUPS) message;
            upsRow["TypeUPS"] = dataUps.typeUps;
            upsRow["IP"] = dataUps.ipUps;
            table.Rows.Add(upsRow);
            upsList.Add(dataUps);
        }

        private void getValueConnector(object message) {
            var dataConnector = (dataConnector) message;
            var table = dataSet.Tables["Conectors"];
            var connectoRow = table.NewRow();
            connectoRow["Connector"] = dataConnector.connector;
            connectoRow["Port"] = dataConnector.port;
            connectoRow["Interface"] = dataConnector.usingIf;
            connectoRow["SenderID"] = dataConnector.senderid;
            connectoRow["SpeedUp"] = dataConnector.speedup;
            connectoRow["Remark"] = dataConnector.remark;
            table.Rows.Add(connectoRow);
            connectors.Add(dataConnector);
        }

        private void getValueEbiLock(object message) {
            var dataEbIlock = (dataEBIlock) message;
            var table = dataSet.Tables["EBILocks"];
            var ebilockRow = table.NewRow();
            ebilockRow["NameEBILock"] = dataEbIlock.nameEbiLock;
            ebilockRow["IDEBILock"] = dataEbIlock.idEbiLock;
            ebilockRow["ESW"] = addLan(dataEbIlock.eswIpEbiLock);
            try {
                table.Rows.Add(ebilockRow);
                ebilockList.Add(dataEbIlock);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void getValueArm(object message) {
            var item = (dataARM) message;
            var table = dataSet.Tables["ARMS"];
            var armRow = table.NewRow();
            armRow["ARMName"] = item.nameArm;
            armRow["LAN"] = item.LAN;
            armRow["Password"] = item.password;
            armRow["PowerON"] = item.pwrOn;
            armRow["Video"] = item.numberVideo;
            armRow["Services"] = addService(item.servicesRun);
            try {
                table.Rows.Add(armRow);
                armList.Add(item);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private string addLan(Dictionary<string, string> numberLan) {
            return numberLan.Aggregate<KeyValuePair<string, string>, string>(null, (current, lan) => current + (lan.Key + lan.Value));
        }

        

        private void addArmClick(object sender, EventArgs e)
        {
            
            var insertSubject=new InsertSubjectArm(arm, this, dataSet);
            insertSubject.ShowDialog();
            setDataGridToMes("ARMS");
  
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void update(object mes) {

            if (mes is dataARM) {
                arm = (dataARM)mes;
                fillDataSet(arm);
               
            }

            var ilock = mes as dataEBIlock;
            if (ilock != null) {
                ebilock = ilock;
                fillDataSet(ilock);
                
            }

            if (mes is dataConnector) {
                fillDataSet(mes);
            }

            if (mes is dataUPS) {
                fillDataSet(mes);
            }
        }

        public void display() {
            //throw new NotImplementedException();
        }

        private void addEbiLockClick(object sender, EventArgs e)
        {
            var insertEbiLock=new InsertEBILock(ebilock, this, dataSet);
            insertEbiLock.ShowDialog();
            setDataGridToMes("EBILocks");
            
        }

        
       

        private string addService(Dictionary<string, bool> servicesRun) {
            
            return servicesRun.Where(key => key.Value).Aggregate("", (current, key) => current + (key.Key + " "));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            //SerializeTreeView(treeView1,"all.xml");
            var xmlDialog = new SaveFileDialog {Filter = @"xml files | *.xml", DefaultExt = "xml"};
            var result = xmlDialog.ShowDialog();
            if (result == DialogResult.OK) {
                dataSet.WriteXml(xmlDialog.OpenFile());
            }
        }

        

   
        

        

        private void createFormClick(object sender, EventArgs e) {
            
            var lCreateReport=new CreateReport(armList, ebilockList, connectors, upsList);
            lCreateReport.AddHeader(nameStation.Text);
            lCreateReport.Waiting();
            lCreateReport.Visible();


        }

        private void addConvertors(object sender, EventArgs e)
        {
            var insertConvertors=new InsertConvertors(this);
            insertConvertors.ShowDialog();
            setDataGridToMes("Conectors");
            

            
        }

        private void addUpsClick(object sender, EventArgs e)
        {
            var insertUps=new InsertUPS(this);
            insertUps.ShowDialog();

            setDataGridToMes("UPS");
        }

        private void setDataGridToMes(string bind) {
           
            
                var dataGrid = new DataGridView
                {
                    DataSource = dataSet.Tables[bind],
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                };

                dataGrid.AutoResizeColumns();

                var tabPage = new TabPage(bind);
                tabPage.Controls.Add(dataGrid);

                tabControl1.TabPages.Add(tabPage);
           
            
        }


        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e) {
            //dataSet.ReadXml();
            var openFileDialog = new OpenFileDialog {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = @"xml files (*.xml)|*.xml|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    dataSet.ReadXml(openFileDialog.OpenFile());
                    //loadLists(dataSet);
                    setDataGridToMes("ARMS");
                    setDataGridToMes("Conectors");
                    setDataGridToMes("UPS");
                    setDataGridToMes("EBILocks");
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message,"from load");
                }
            }
        }

        private void loadLists(DataSet ds) {
            //ds.Tables
            //armList.Clear();
            foreach (DataTable dt in ds.Tables) {
                loadCurent(dt);
            }
            
        }

        private void loadCurent(DataTable dt) {
            var dtReader = dt.CreateDataReader();
            
            if (dt.TableName == "ARMS")
            {
                
                //arm.nameArm=d
                while (dtReader.Read()) {
                    var item = new dataARM {nameArm = dtReader.GetValue(0).ToString().Trim()};
                    item.numberLan.Add(dtReader.GetValue(1).ToString().Trim(), "");
                    item.password = dtReader.GetValue(2).ToString().Trim();
                    item.senderId = dtReader.GetValue(3).ToString().Trim();
                    item.pwrOn = dtReader.GetValue(4).ToString().Trim();
                    item.numberVideo = dtReader.GetValue(5).ToString().Trim();
                    item.servicesRun.Add(dtReader.GetValue(6).ToString().Trim(), true);
                    armList.Add(item);
                }
            }

            while (dtReader.Read())
            {
                var item = new dataARM {nameArm = dtReader.GetValue(0).ToString().Trim()};
                item.LAN=dtReader.GetValue(1).ToString().Trim();
                item.password = dtReader.GetValue(2).ToString().Trim();
                item.senderId = dtReader.GetValue(3).ToString().Trim();
                item.pwrOn = dtReader.GetValue(4).ToString().Trim();
                item.numberVideo = dtReader.GetValue(5).ToString().Trim();
                item.servicesRun.Add(dtReader.GetValue(6).ToString().Trim(),true);
                armList.Add(item);

                for (var i = 0; i < dtReader.FieldCount; i++) {
                    Console.Write("{0}\t", dtReader.GetValue(i).ToString().Trim());
                    //dtReader.GetName()
                   // Console.WriteLine();
                   // arm.nameArm

                }
                Console.WriteLine();
            }
            dtReader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateReport cr = new CreateReport(dataSet);
            cr.AddHeader(titulBox.Text);
            cr.Waiting();
            cr.Visible();

        }

        
    }
}
