using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace crWordForms
{
    class CreateReport {
        private readonly List<dataARM> armList;
        private readonly List<dataEBIlock> ebilockList;
        private readonly List<dataConnector> connectorList;
        private readonly List<dataUPS> upsList;
        private readonly Word.Application nWord;
        private Word.Range rng;
        private Word.Document document;
        private object start = 0;
        private object end = 0;
        private object missing = 0;
        private DataSet ds=new DataSet();



        public CreateReport(List<dataARM> armList, List<dataEBIlock> ebilockList, List<dataConnector> connectorList, List<dataUPS> upsList) {
            //throw new NotImplementedException();
            this.armList = armList;
            this.ebilockList = ebilockList;
            this.connectorList = connectorList;
            this.upsList = upsList;
            
            nWord = new Word.Application();
            string path = Environment.CurrentDirectory;
            nWord.Application.Documents.Add(path + "\\mini.dotx");

        }

        public CreateReport(DataSet ds) {
            nWord = new Word.Application();
            string path = Environment.CurrentDirectory;
            nWord.Application.Documents.Add(path + "\\mini.dotx");
            
            this.ds = ds;
            armList=new List<dataARM>();
            ebilockList=new List<dataEBIlock>();
            upsList=new List<dataUPS>();
            connectorList=new List<dataConnector>();
            ImportData();
            

        }

        private void ImportData() {
            foreach (DataTable dt in ds.Tables)
            {
                loadCurent(dt);
            }

        }
        private void loadCurent(DataTable dt)
        {
            var dtReader = dt.CreateDataReader();

            if (dt.TableName == "ARMS")
            {

                //arm.nameArm=d
                while (dtReader.Read())
                {
                    var item = new dataARM ();
                    item.nameArm = dtReader.GetValue(0).ToString().Trim();
                    item.LAN = dtReader.GetValue(1).ToString().Trim();
                    item.password = dtReader.GetValue(2).ToString().Trim();
                    item.senderId = dtReader.GetValue(3).ToString().Trim();
                    item.pwrOn = dtReader.GetValue(4).ToString().Trim();
                    item.numberVideo = dtReader.GetValue(5).ToString().Trim();
                    item.servicesRun.Add(dtReader.GetValue(6).ToString().Trim(), true);
                    armList.Add(item);
                }
            }

            
            dtReader.Close();

        }

        public void Visible() {
            nWord.Visible=true;
        }

        public void AddHeader(string header) {
            foreach (Word.Section wordSection in nWord.ActiveDocument.Sections)
            {
                Word.Range footerRange = wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 11;
                footerRange.Text = "BOMBARDIER " + DateTime.Now;
            }

            document = nWord.ActiveDocument;
            rng = document.Range(ref start, ref end);
            // вносим загловок
            rng.InsertBefore("Таблица исходных данных оборудования по станции " + header);
            rng.Font.Name = "Verdana";
            rng.Font.Size = 16;
            //rng.
            rng.InsertParagraphAfter();
            rng.InsertParagraphAfter();
            rng.SetRange(rng.End, rng.End);

        }
        
        public void Waiting() {
            

            if (armList.Count > 0) {
                AddTable(armList);
            }
            if (ebilockList.Count > 0) {
                AddEBILocks(ebilockList);
            }

            if (connectorList.Count > 0) {
                AddConnecors(connectorList);
            }

            if (upsList.Count > 0) {
                AddUpses(upsList);
            }
        }

        private void AddUpses(List<dataUPS> dataUpss) {
            object endOfdoc = "\\endofdoc";
            object miss = System.Reflection.Missing.Value;
            Word.Paragraph byUPS;
            byUPS = nWord.ActiveDocument.Content.Paragraphs.Add(miss);
            byUPS.Range.Font.Name = "Verdana";
            byUPS.Range.Text = "ИБП";
            byUPS.Range.InsertParagraphAfter();

            // Формируем таблицу UPS
            Word.Table upsTable;
            Word.Range uRange = nWord.ActiveDocument.Bookmarks.get_Item(ref endOfdoc).Range;
            upsTable = nWord.ActiveDocument.Tables.Add(uRange, upsList.Count + 1, 2);
            upsTable.Borders.Enable = 1;
            upsTable.Cell(1, 1).Range.Text = "Тип ИБП";
            upsTable.Cell(1, 2).Range.Text = "IP-адрес";
            int cnt = 2;
            foreach (var dataUps in upsList)
            {
                upsTable.Cell(cnt, 1).Range.Text = dataUps.typeUps;
                upsTable.Cell(cnt, 2).Range.Text = dataUps.ipUps;
                cnt++;
            }

        }

        private void AddConnecors(List<dataConnector> dataConnectors) {
            object endOfdoc = "\\endofdoc";
            object miss = System.Reflection.Missing.Value;
            Word.Paragraph byNext;
            byNext = nWord.ActiveDocument.Content.Paragraphs.Add(miss);
            byNext.Range.Font.Name = "Verdana";
            byNext.Range.Text = "Увязки";
            byNext.Range.InsertParagraphAfter();

            // Формируем таблицу увязок
            Word.Table cTable;
            Word.Range сRange = nWord.ActiveDocument.Bookmarks.get_Item(ref endOfdoc).Range;
            cTable = nWord.ActiveDocument.Tables.Add(сRange, connectorList.Count + 1, 6);
            cTable.Borders.Enable = 1;
            cTable.Cell(1, 1).Range.Text = "Увязка";
            cTable.Cell(1, 2).Range.Text = "Порт";
            cTable.Cell(1, 3).Range.Text = "Sender ID/place id";
            cTable.Cell(1, 4).Range.Text = "Используемый интерфейс";
            cTable.Cell(1, 5).Range.Text = "Скорость обмена";
            cTable.Cell(1, 6).Range.Text = "Примечание";

            int cnt = 2;
            foreach (var dataConnector in connectorList)
            {
                cTable.Cell(cnt, 1).Range.Text = dataConnector.connector;
                cTable.Cell(cnt, 2).Range.Text = dataConnector.port;
                cTable.Cell(cnt, 3).Range.Text = dataConnector.senderid;
                cTable.Cell(cnt, 4).Range.Text = dataConnector.usingIf;
                cTable.Cell(cnt, 5).Range.Text = dataConnector.speedup;
                cTable.Cell(cnt, 6).Range.Text = dataConnector.remark;
                cnt++;
            }

        }

        private void AddEBILocks(List<dataEBIlock> dataEbIlocks) {
            object miss = System.Reflection.Missing.Value;
            Word.Paragraph paragraph;
            paragraph = nWord.ActiveDocument.Content.Paragraphs.Add(miss);
            paragraph.Range.Font.Name = "Verdana";
            paragraph.Range.Text = "ЦП";
            paragraph.Range.InsertParagraphAfter();
            object endOfdoc = "\\endofdoc";
            // Формируем таблицу ЦП
            Word.Table eTable;
            Word.Range wrdRange = nWord.ActiveDocument.Bookmarks.get_Item(ref endOfdoc).Range;
            eTable = nWord.ActiveDocument.Tables.Add(wrdRange, 3, 3);
            eTable.Borders.Enable = 1;
            eTable.Cell(1, 1).Range.Text = "EBILock ID";
            eTable.Cell(1, 2).Range.Text = "EBILock Name";
            eTable.Cell(1, 3).Range.Text = "EBILock IP";

            eTable.Cell(2, 1).Range.Text = ebilockList[0].idEbiLock;
            eTable.Cell(2, 2).Range.Text = ebilockList[0].nameEbiLock;
            eTable.Cell(2, 3).Range.Text = "ESW1: " + ebilockList[0].eswIpEbiLock["ESW1"] + "\n ESW2: " + ebilockList[0].eswIpEbiLock["ESW2"];

            eTable.Cell(3, 1).Range.Text = ebilockList[1].idEbiLock;
            eTable.Cell(3, 2).Range.Text = ebilockList[1].nameEbiLock;
            eTable.Cell(3, 3).Range.Text = "ESW1: " + ebilockList[1].eswIpEbiLock["ESW1"] + "\n ESW2: " + ebilockList[1].eswIpEbiLock["ESW2"];
            
        }

        private void AddTable(List<dataARM> armList) {
            
            rng.Tables.Add(document.Paragraphs[2].Range, armList.Count + 1, 7, ref missing, ref missing);
            Word.Table tbl = document.Tables[1];
            tbl.Range.Font.Size = 11;
            tbl.Columns.DistributeWidth();
            tbl.Borders.Enable = 1;
            tbl.Cell(1, 1).Range.Text = "Имя машины АРМ";
            tbl.Cell(1, 2).Range.Text = "Настройки сетевых интерфейсов";
            tbl.Cell(1, 3).Range.Text = "Пароль администратора";
            tbl.Cell(1, 4).Range.Text = "PWRON After Fail";
            tbl.Cell(1, 5).Range.Text = "Sender ID/Place ID";
            tbl.Cell(1, 6).Range.Text = "Настроено количество мониторов(видеокарт)";
            tbl.Cell(1, 7).Range.Text = "Запущеные службы MultiRcos";

            
            int cnt = 2;
            foreach (var curARM in armList)
            {
                tbl.Cell(cnt, 1).Range.Text = curARM.nameArm;
                tbl.Cell(cnt, 2).Range.Text = "LAN1: " + curARM.Lan1 + " LAN2: " + curARM.Lan2;
                tbl.Cell(cnt, 3).Range.Text = curARM.password;
                tbl.Cell(cnt, 4).Range.Text = curARM.pwrOn;
                tbl.Cell(cnt, 5).Range.Text = curARM.senderId;
                tbl.Cell(cnt, 6).Range.Text = curARM.numberVideo;
                tbl.Cell(cnt, 7).Range.Text = addService(curARM.servicesRun);
                cnt++;
            }
            object miss = System.Reflection.Missing.Value;
        }

        private string addService(Dictionary<string, bool> servicesRun) {
            //throw new NotImplementedException();
            return servicesRun.Where(key => key.Value == true).Aggregate("", (current, key) => current + (key.Key + " "));
        }
    }
}
