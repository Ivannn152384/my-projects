
namespace DB_Winform
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPreviousRealty = new System.Windows.Forms.Button();
            this.btnNextRealty = new System.Windows.Forms.Button();
            this.chkbxClients = new System.Windows.Forms.CheckedListBox();
            this.btnChangeRealty = new System.Windows.Forms.Button();
            this.grpAddNedvijimost = new System.Windows.Forms.GroupBox();
            this.cmbClientAddNedvObject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbLikved = new System.Windows.Forms.ComboBox();
            this.txtBoxAdressAddNedvObject = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBoxOpisanieAddNedvObject = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBoxRoomsCountAddNedvObject = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxAreaAddNedvOjbect = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBoxAddPriceNedvObject = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbFloorAddNedvObject = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbRealtyTypeAddNedvObject = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteNedvObject = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnAddRealty = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpAddNedvijimost.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreviousRealty
            // 
            this.btnPreviousRealty.Location = new System.Drawing.Point(6, 466);
            this.btnPreviousRealty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreviousRealty.Name = "btnPreviousRealty";
            this.btnPreviousRealty.Size = new System.Drawing.Size(99, 29);
            this.btnPreviousRealty.TabIndex = 8;
            this.btnPreviousRealty.Text = "<<";
            this.btnPreviousRealty.UseVisualStyleBackColor = true;
            this.btnPreviousRealty.Click += new System.EventHandler(this.btnPreviousRealty_Click);
            // 
            // btnNextRealty
            // 
            this.btnNextRealty.Location = new System.Drawing.Point(679, 466);
            this.btnNextRealty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextRealty.Name = "btnNextRealty";
            this.btnNextRealty.Size = new System.Drawing.Size(97, 29);
            this.btnNextRealty.TabIndex = 9;
            this.btnNextRealty.Text = ">>";
            this.btnNextRealty.UseVisualStyleBackColor = true;
            this.btnNextRealty.Click += new System.EventHandler(this.btnNextRealty_Click);
            // 
            // chkbxClients
            // 
            this.chkbxClients.CheckOnClick = true;
            this.chkbxClients.FormattingEnabled = true;
            this.chkbxClients.Location = new System.Drawing.Point(465, 293);
            this.chkbxClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbxClients.Name = "chkbxClients";
            this.chkbxClients.ScrollAlwaysVisible = true;
            this.chkbxClients.Size = new System.Drawing.Size(297, 165);
            this.chkbxClients.TabIndex = 10;
            this.chkbxClients.SelectedIndexChanged += new System.EventHandler(this.chkbxClients_SelectedIndexChanged);
            // 
            // btnChangeRealty
            // 
            this.btnChangeRealty.Location = new System.Drawing.Point(466, 212);
            this.btnChangeRealty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeRealty.Name = "btnChangeRealty";
            this.btnChangeRealty.Size = new System.Drawing.Size(154, 51);
            this.btnChangeRealty.TabIndex = 0;
            this.btnChangeRealty.Text = "Изменить ↻";
            this.btnChangeRealty.UseVisualStyleBackColor = true;
            this.btnChangeRealty.Click += new System.EventHandler(this.btnChangeRealty_Click);
            // 
            // grpAddNedvijimost
            // 
            this.grpAddNedvijimost.BackColor = System.Drawing.Color.LightGray;
            this.grpAddNedvijimost.Controls.Add(this.cmbClientAddNedvObject);
            this.grpAddNedvijimost.Controls.Add(this.label1);
            this.grpAddNedvijimost.Controls.Add(this.label22);
            this.grpAddNedvijimost.Controls.Add(this.cmbLikved);
            this.grpAddNedvijimost.Controls.Add(this.txtBoxAdressAddNedvObject);
            this.grpAddNedvijimost.Controls.Add(this.label21);
            this.grpAddNedvijimost.Controls.Add(this.txtBoxOpisanieAddNedvObject);
            this.grpAddNedvijimost.Controls.Add(this.label20);
            this.grpAddNedvijimost.Controls.Add(this.txtBoxRoomsCountAddNedvObject);
            this.grpAddNedvijimost.Controls.Add(this.label19);
            this.grpAddNedvijimost.Controls.Add(this.txtBoxAreaAddNedvOjbect);
            this.grpAddNedvijimost.Controls.Add(this.label18);
            this.grpAddNedvijimost.Controls.Add(this.txtBoxAddPriceNedvObject);
            this.grpAddNedvijimost.Controls.Add(this.label17);
            this.grpAddNedvijimost.Controls.Add(this.cmbFloorAddNedvObject);
            this.grpAddNedvijimost.Controls.Add(this.label16);
            this.grpAddNedvijimost.Controls.Add(this.cmbRealtyTypeAddNedvObject);
            this.grpAddNedvijimost.Controls.Add(this.label15);
            this.grpAddNedvijimost.Location = new System.Drawing.Point(8, 7);
            this.grpAddNedvijimost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddNedvijimost.Name = "grpAddNedvijimost";
            this.grpAddNedvijimost.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddNedvijimost.Size = new System.Drawing.Size(755, 194);
            this.grpAddNedvijimost.TabIndex = 26;
            this.grpAddNedvijimost.TabStop = false;
            this.grpAddNedvijimost.Text = "Oбъект недвижимости 🏠";
            // 
            // cmbClientAddNedvObject
            // 
            this.cmbClientAddNedvObject.Location = new System.Drawing.Point(100, 144);
            this.cmbClientAddNedvObject.Name = "cmbClientAddNedvObject";
            this.cmbClientAddNedvObject.ReadOnly = true;
            this.cmbClientAddNedvObject.Size = new System.Drawing.Size(351, 26);
            this.cmbClientAddNedvObject.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ликвидность:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Клиент:";
            // 
            // cmbLikved
            // 
            this.cmbLikved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLikved.FormattingEnabled = true;
            this.cmbLikved.Location = new System.Drawing.Point(127, 97);
            this.cmbLikved.Name = "cmbLikved";
            this.cmbLikved.Size = new System.Drawing.Size(136, 28);
            this.cmbLikved.TabIndex = 31;
            // 
            // txtBoxAdressAddNedvObject
            // 
            this.txtBoxAdressAddNedvObject.Location = new System.Drawing.Point(527, 144);
            this.txtBoxAdressAddNedvObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAdressAddNedvObject.Name = "txtBoxAdressAddNedvObject";
            this.txtBoxAdressAddNedvObject.Size = new System.Drawing.Size(196, 26);
            this.txtBoxAdressAddNedvObject.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(457, 147);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "Адрес:";
            // 
            // txtBoxOpisanieAddNedvObject
            // 
            this.txtBoxOpisanieAddNedvObject.Location = new System.Drawing.Point(461, 112);
            this.txtBoxOpisanieAddNedvObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOpisanieAddNedvObject.Name = "txtBoxOpisanieAddNedvObject";
            this.txtBoxOpisanieAddNedvObject.Size = new System.Drawing.Size(262, 26);
            this.txtBoxOpisanieAddNedvObject.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(368, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 20);
            this.label20.TabIndex = 19;
            this.label20.Text = "Описание:";
            // 
            // txtBoxRoomsCountAddNedvObject
            // 
            this.txtBoxRoomsCountAddNedvObject.Location = new System.Drawing.Point(587, 82);
            this.txtBoxRoomsCountAddNedvObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRoomsCountAddNedvObject.Name = "txtBoxRoomsCountAddNedvObject";
            this.txtBoxRoomsCountAddNedvObject.Size = new System.Drawing.Size(136, 26);
            this.txtBoxRoomsCountAddNedvObject.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(457, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 20);
            this.label19.TabIndex = 17;
            this.label19.Text = "Кол-во комнат:";
            // 
            // txtBoxAreaAddNedvOjbect
            // 
            this.txtBoxAreaAddNedvOjbect.Location = new System.Drawing.Point(587, 52);
            this.txtBoxAreaAddNedvOjbect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAreaAddNedvOjbect.Name = "txtBoxAreaAddNedvOjbect";
            this.txtBoxAreaAddNedvOjbect.Size = new System.Drawing.Size(136, 26);
            this.txtBoxAreaAddNedvOjbect.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(495, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "Площадь:";
            // 
            // txtBoxAddPriceNedvObject
            // 
            this.txtBoxAddPriceNedvObject.Location = new System.Drawing.Point(127, 66);
            this.txtBoxAddPriceNedvObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAddPriceNedvObject.Name = "txtBoxAddPriceNedvObject";
            this.txtBoxAddPriceNedvObject.Size = new System.Drawing.Size(136, 26);
            this.txtBoxAddPriceNedvObject.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(69, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Цена:";
            // 
            // cmbFloorAddNedvObject
            // 
            this.cmbFloorAddNedvObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloorAddNedvObject.FormattingEnabled = true;
            this.cmbFloorAddNedvObject.Location = new System.Drawing.Point(587, 19);
            this.cmbFloorAddNedvObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFloorAddNedvObject.Name = "cmbFloorAddNedvObject";
            this.cmbFloorAddNedvObject.Size = new System.Drawing.Size(136, 28);
            this.cmbFloorAddNedvObject.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(527, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Этаж:";
            // 
            // cmbRealtyTypeAddNedvObject
            // 
            this.cmbRealtyTypeAddNedvObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRealtyTypeAddNedvObject.FormattingEnabled = true;
            this.cmbRealtyTypeAddNedvObject.Location = new System.Drawing.Point(127, 32);
            this.cmbRealtyTypeAddNedvObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRealtyTypeAddNedvObject.Name = "cmbRealtyTypeAddNedvObject";
            this.cmbRealtyTypeAddNedvObject.Size = new System.Drawing.Size(136, 28);
            this.cmbRealtyTypeAddNedvObject.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Тип дома:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnDeleteNedvObject);
            this.groupBox2.Location = new System.Drawing.Point(8, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(198, 105);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удалить объект недвижимости 🏠";
            // 
            // btnDeleteNedvObject
            // 
            this.btnDeleteNedvObject.Location = new System.Drawing.Point(14, 43);
            this.btnDeleteNedvObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteNedvObject.Name = "btnDeleteNedvObject";
            this.btnDeleteNedvObject.Size = new System.Drawing.Size(138, 50);
            this.btnDeleteNedvObject.TabIndex = 25;
            this.btnDeleteNedvObject.Text = "Удалить";
            this.btnDeleteNedvObject.UseVisualStyleBackColor = true;
            this.btnDeleteNedvObject.Click += new System.EventHandler(this.btnDeleteNedvObject_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveForm.Location = new System.Drawing.Point(626, 209);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(137, 51);
            this.btnSaveForm.TabIndex = 28;
            this.btnSaveForm.Text = "Сохранить ✓";
            this.btnSaveForm.UseVisualStyleBackColor = false;
            this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(462, 267);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(186, 20);
            this.label23.TabIndex = 30;
            this.label23.Text = "Выберите владельца ↓";
            // 
            // btnAddRealty
            // 
            this.btnAddRealty.Location = new System.Drawing.Point(8, 268);
            this.btnAddRealty.Name = "btnAddRealty";
            this.btnAddRealty.Size = new System.Drawing.Size(198, 84);
            this.btnAddRealty.TabIndex = 33;
            this.btnAddRealty.Text = "Добавить недвижимость";
            this.btnAddRealty.UseVisualStyleBackColor = true;
            this.btnAddRealty.Click += new System.EventHandler(this.btnAddRealty_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(218, 209);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 34;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(-2, 205);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(152, 55);
            this.lblTime.TabIndex = 35;
            this.lblTime.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 535);
            this.tabControl1.TabIndex = 36;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.btnAddRealty);
            this.Page1.Controls.Add(this.label23);
            this.Page1.Controls.Add(this.lblTime);
            this.Page1.Controls.Add(this.btnPreviousRealty);
            this.Page1.Controls.Add(this.chkbxClients);
            this.Page1.Controls.Add(this.groupBox2);
            this.Page1.Controls.Add(this.btnChangeRealty);
            this.Page1.Controls.Add(this.monthCalendar1);
            this.Page1.Controls.Add(this.btnSaveForm);
            this.Page1.Controls.Add(this.btnNextRealty);
            this.Page1.Controls.Add(this.grpAddNedvijimost);
            this.Page1.Location = new System.Drawing.Point(4, 29);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(779, 502);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Основная";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица Недвижимости";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(773, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DB_RieltorCompany.Client);
            // 
            // flatBindingSource
            // 
            this.flatBindingSource.DataSource = typeof(DB_RieltorCompany.Flat);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 532);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Моя база данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.grpAddNedvijimost.ResumeLayout(false);
            this.grpAddNedvijimost.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPreviousRealty;
        private System.Windows.Forms.Button btnNextRealty;
        private System.Windows.Forms.CheckedListBox chkbxClients;
        private System.Windows.Forms.Button btnChangeRealty;
        private System.Windows.Forms.GroupBox grpAddNedvijimost;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBoxAdressAddNedvObject;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBoxOpisanieAddNedvObject;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBoxRoomsCountAddNedvObject;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxAreaAddNedvOjbect;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBoxAddPriceNedvObject;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbFloorAddNedvObject;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbRealtyTypeAddNedvObject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteNedvObject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSaveForm;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLikved;
        private System.Windows.Forms.Button btnAddRealty;
        private System.Windows.Forms.TextBox cmbClientAddNedvObject;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource flatBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

