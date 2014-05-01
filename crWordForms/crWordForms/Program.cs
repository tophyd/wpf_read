using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace crWordForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            DataSet ds=new DataSet("StationData");
            
            ds.ExtendedProperties["TimeStamp"] = DateTime.Now;
            ds.ExtendedProperties["ID"] = Guid.NewGuid();
            ds.ExtendedProperties["Company"] = "BOMBARDIER";
            FillDataset(ds);
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormSourceData(ds));
            ds.WriteXml("save\\last.xml");
            ds.WriteXmlSchema("conf\\baseschm.xml");
        }

        private static void FillDataset(DataSet ds) {
            DataColumn armColumn=new DataColumn("ARMName", typeof(string));
            
            armColumn.Caption = "Имя машины АРМ";
            armColumn.AllowDBNull = false;
            //armColumn.Unique = true;

            DataColumn idARM=new DataColumn("idARM", typeof(int));
            idARM.Unique = true;
            idARM.AutoIncrementSeed = 0;
            idARM.AutoIncrement = true;

            DataColumn lanColumn = new DataColumn("LAN", typeof(string));
            //DataColumn ipColumn = new DataColumn("IP", typeof(string));
            DataColumn passwordColumn = new DataColumn("Password", typeof(string));
            DataColumn pwrOnColumn = new DataColumn("PowerON", typeof(string));
            DataColumn senderIDColumn = new DataColumn("SenderID", typeof(string));
            DataColumn videoColumn = new DataColumn("Video", typeof(string));
            DataColumn servicesRunColumn = new DataColumn("Services", typeof(string));

            DataTable armTable=new DataTable("ARMS");
            armTable.Columns.AddRange( new[] {
                armColumn, lanColumn,  passwordColumn, senderIDColumn, pwrOnColumn, videoColumn,
                servicesRunColumn, idARM
            });
            armTable.PrimaryKey=new DataColumn[] {idARM};
            

            DataColumn nameEbiLockColumn=new DataColumn("NameEBILock",typeof(string));
            DataColumn idEbiLockColumn=new DataColumn("IDEBILock", typeof(string));
            DataColumn eswEBILock=new DataColumn("ESW",typeof(string));
            DataTable ebiLockTable = new DataTable("EBILocks");
            ebiLockTable.Columns.AddRange(new[] {
                nameEbiLockColumn, idEbiLockColumn, eswEBILock
            });
            
            DataColumn connectorColumn=new DataColumn("Connector", typeof(string));
            DataColumn portColumn=new DataColumn("Port", typeof(string));
            DataColumn usingifColumn=new DataColumn("Interface", typeof(string));
            DataColumn senderidColumn = new DataColumn("SenderID", typeof(string));
            DataColumn speedupColumn = new DataColumn("SpeedUp", typeof(string));
            DataColumn remarkColumn = new DataColumn("Remark", typeof(string));
            
            DataTable connectorTable=new DataTable("Conectors");


            


            connectorTable.Columns.AddRange(new [] {
                connectorColumn, portColumn, senderidColumn, usingifColumn, speedupColumn, remarkColumn
            });

            DataColumn typeUpsColumn = new DataColumn("TypeUPS", typeof(string));
            DataColumn ipUpsColumn = new DataColumn("IP", typeof(string));
            DataTable upsTable = new DataTable("UPS");
            upsTable.Columns.AddRange(new[] { typeUpsColumn, ipUpsColumn });
            
            //Добавление таблиц
            ds.Tables.Add(upsTable);
            ds.Tables.Add(armTable);
            ds.Tables.Add(ebiLockTable);
            ds.Tables.Add(connectorTable); 

        }
    }
}
