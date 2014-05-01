namespace crWordForms
{
    partial class MainFormSourceData
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameStation = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.testingButton = new System.Windows.Forms.StatusStrip();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАРМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЦПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИБПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПреобразователиИнтерфейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulBox
            // 
            this.titulBox.Location = new System.Drawing.Point(26, 52);
            this.titulBox.Name = "titulBox";
            this.titulBox.Size = new System.Drawing.Size(313, 20);
            this.titulBox.TabIndex = 1;
            this.titulBox.Text = "Таблица исходных данных для настройки оборудования по ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Титул";
            // 
            // nameStation
            // 
            this.nameStation.Location = new System.Drawing.Point(355, 52);
            this.nameStation.Name = "nameStation";
            this.nameStation.Size = new System.Drawing.Size(100, 20);
            this.nameStation.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить машину АРМ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addArmClick);
            // 
            // testingButton
            // 
            this.testingButton.Location = new System.Drawing.Point(0, 491);
            this.testingButton.Name = "testingButton";
            this.testingButton.Size = new System.Drawing.Size(983, 22);
            this.testingButton.TabIndex = 6;
            this.testingButton.Text = "statusStrip1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Добавить ЦП";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.addEbiLockClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Добавить ИБП";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.addUpsClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 53);
            this.button5.TabIndex = 9;
            this.button5.Text = "Добавить преобразователи интерфейсов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.addConvertors);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вставкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАРМToolStripMenuItem,
            this.добавитьЦПToolStripMenuItem,
            this.добавитьИБПToolStripMenuItem,
            this.добавитьПреобразователиИнтерфейсовToolStripMenuItem});
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.вставкаToolStripMenuItem.Text = "Вставка";
            // 
            // добавитьАРМToolStripMenuItem
            // 
            this.добавитьАРМToolStripMenuItem.Name = "добавитьАРМToolStripMenuItem";
            this.добавитьАРМToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.добавитьАРМToolStripMenuItem.Text = "Добавить АРМ";
            // 
            // добавитьЦПToolStripMenuItem
            // 
            this.добавитьЦПToolStripMenuItem.Name = "добавитьЦПToolStripMenuItem";
            this.добавитьЦПToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.добавитьЦПToolStripMenuItem.Text = "Добавить ЦП";
            // 
            // добавитьИБПToolStripMenuItem
            // 
            this.добавитьИБПToolStripMenuItem.Name = "добавитьИБПToolStripMenuItem";
            this.добавитьИБПToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.добавитьИБПToolStripMenuItem.Text = "Добавить ИБП";
            // 
            // добавитьПреобразователиИнтерфейсовToolStripMenuItem
            // 
            this.добавитьПреобразователиИнтерфейсовToolStripMenuItem.Name = "добавитьПреобразователиИнтерфейсовToolStripMenuItem";
            this.добавитьПреобразователиИнтерфейсовToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.добавитьПреобразователиИнтерфейсовToolStripMenuItem.Text = "Добавить преобразователи интерфейсов";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 413);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 40);
            this.button7.TabIndex = 14;
            this.button7.Text = "Формирование таблицы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.createFormClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(818, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(153, 399);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(26, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 233);
            this.tabControl1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFormSourceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.testingButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nameStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFormSourceData";
            this.Text = "Ввод данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titulBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameStation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip testingButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАРМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЦПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИБПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПреобразователиИнтерфейсовToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
    }
}

