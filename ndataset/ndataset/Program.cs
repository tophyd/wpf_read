using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;

namespace ndataset
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            DataSet previewDataSet=new DataSet();
            //previewDataSet.Load(nXmlDocument);
            previewDataSet.ReadXml("mx.xml");
            previewDataSet.ReadXmlSchema("schm.xsd");
            DataSet carsInvenoryDS=new DataSet("Car inventory");
            carsInvenoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInvenoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
            carsInvenoryDS.ExtendedProperties["Company"] = "Мой магазин";

            FillDataSet(carsInvenoryDS);
            PrintDataSet(carsInvenoryDS);
            //PrintTable(carsInvenoryDS);
            carsInvenoryDS.WriteXml("mx.xml");
            carsInvenoryDS.WriteXmlSchema("schm.xsd");
            
            Console.WriteLine("================= load data++++");
            PrintDataSet(previewDataSet);
           
            Console.ReadLine();
        }


        static void PrintTable(DataTable dt)
        {
            // Создание объекта DataTableReader
            DataTableReader dtReader = dt.CreateDataReader();

            while (dtReader.Read())
            {
                for (int i = 0; i < dtReader.FieldCount; i++)
                    Console.Write("{0}\t", dtReader.GetValue(i).ToString().Trim());
                Console.WriteLine();
            }
            dtReader.Close();
        }


        private static void PrintDataSet(DataSet ds)
        {
            // Вывод имени и расширенных свойств
            Console.WriteLine("*** Объекты DataSet ***\n");
            Console.WriteLine("Имя DataSet: {0}", ds.DataSetName);
            foreach (System.Collections.DictionaryEntry de in ds.ExtendedProperties)
                Console.WriteLine("Ключ = {0}, Значение = {1}", de.Key, de.Value);
            Console.WriteLine();
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("=> Таблица: {0}", dt.TableName);

                // Вывод имени столбцов
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    Console.Write(dt.Columns[curCol].ColumnName + "\t");
                Console.WriteLine("\n--------------------------");

                // Выводим содержимое таблицы
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Console.Write(dt.Rows[curRow][curCol] + "\t");

                    }
                    Console.WriteLine();
                }
                PrintTable(dt);
            }
        }

        static void FillDataSet(DataSet ds)
        {
            DataColumn carIDColumn = new DataColumn("CarID", typeof(int));
            carIDColumn.Caption = "Car ID";
            carIDColumn.ReadOnly = true;
            carIDColumn.AllowDBNull = false;
            carIDColumn.Unique = true;
            carIDColumn.AutoIncrement = true;
            carIDColumn.AutoIncrementSeed = 0;
            carIDColumn.AutoIncrementStep = 1;


            DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
            DataColumn carColorColumn = new DataColumn("Color", typeof(string));
            DataColumn carPetName = new DataColumn("PetName", typeof(string));
            carPetName.Caption = "Дружественное имя";


            DataTable inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.AddRange(new DataColumn[] { carIDColumn, carMakeColumn, carColorColumn, carPetName });
            inventoryTable.PrimaryKey = new DataColumn[] { inventoryTable.Columns[0] };
            
            ds.Tables.Add(inventoryTable);

            DataRow carRow = inventoryTable.NewRow();
            carRow["Make"] = "BMW";
            carRow["Color"] = "Black";
            carRow["PetName"] = "Hamlet";
            inventoryTable.Rows.Add(carRow);
            inventoryTable.AcceptChanges();

            carRow = inventoryTable.NewRow();
            carRow[1] = "Saab";
            carRow[2] = "Red";
            carRow[3] = "Sea Breeze";
            inventoryTable.Rows.Add(carRow);
            inventoryTable.AcceptChanges();


        }

    }
}
