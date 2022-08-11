using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB_RieltorCompany;
using System.IO;
using System.Text.RegularExpressions;

//при удалении клиентов потом мдёт ошибка - она не может его найти при заполнении формы


namespace DB_Winform
{
    public partial class Form1 : Form
    {

        Clients myClients;
        Flats myFlats;
        types myTypes;


        private Form2 frmAdd;

        int currentFlatNumber;


        public Form1()
        {
            InitializeComponent();
        }
        Size mySize = new Size();
        

        private void FillForm(Flat f)//заполнение главной формы
        {
            chkbxClients.HorizontalScrollbar = true;
            mySize.Height = 1;
            mySize.Width = 1;
            Page1.Size = mySize; 
            timer1.Start();
            this.Text = "Недвижимость номер:" + f.ID;
            cmbRealtyTypeAddNedvObject.Text = f.RealtyType;//заполнение окон формы
            txtBoxAddPriceNedvObject.Text = f.Price.ToString();//заполнение окон формы
            cmbClientAddNedvObject.Text = f.clienttt.Name;
            cmbFloorAddNedvObject.Text = f.Floor.ToString();
            txtBoxAreaAddNedvOjbect.Text = f.Area.ToString();
            txtBoxRoomsCountAddNedvObject.Text = f.RoomsCount.ToString();
            txtBoxOpisanieAddNedvObject.Text = f.Description;
            txtBoxAdressAddNedvObject.Text = f.Address;
            cmbLikved.Text = myTypes.getTypes(f.Likvid-1).ToString();
        }


        private void Form1_Load(object sender, EventArgs e)//загрузка формы
        {
            Form1_Resize(sender, e);
            myClients=new Clients("clients.csv");
            myFlats= new Flats("data.csv", myClients);
            myTypes = new types("types.csv");
            ////////
            dataGridView1.Columns.Add("ID", "Номер недвижимости");
            dataGridView1.Columns.Add("RealtyType", "Тип недвижимости");
            dataGridView1.Columns.Add("Price", "Цена");
            dataGridView1.Columns.Add("clienttt.Name", "ФИО клиента");
            dataGridView1.Columns.Add("Floor", "Этаж");
            dataGridView1.Columns.Add("RoomsCount", "Количество комнат");
            dataGridView1.Columns.Add("Description", "Описание");
            dataGridView1.Columns.Add("Address", "Адресс");
            dataGridView1.Columns.Add("Likvid", "Ликвидность");
            dataGridView1.Rows.Add(myFlats.flatsCount);

            dataGridView1.AllowUserToAddRows = false;

            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = myFlats.getFlat(i).ID;
                dataGridView1.Rows[i].Cells[1].Value = myFlats.getFlat(i).RealtyType;
                dataGridView1.Rows[i].Cells[2].Value = myFlats.getFlat(i).Price;
                dataGridView1.Rows[i].Cells[3].Value = myFlats.getFlat(i).clienttt.Name;
                dataGridView1.Rows[i].Cells[4].Value = myFlats.getFlat(i).Floor;
                dataGridView1.Rows[i].Cells[5].Value = myFlats.getFlat(i).RoomsCount;
                dataGridView1.Rows[i].Cells[6].Value = myFlats.getFlat(i).Description;
                dataGridView1.Rows[i].Cells[7].Value = myFlats.getFlat(i).Address;
                dataGridView1.Rows[i].Cells[8].Value = myTypes.getTypes(myFlats.getFlat(i).Likvid - 1);
            }

            //////////
            cmbRealtyTypeAddNedvObject.Items.Add("Квартира");
            cmbRealtyTypeAddNedvObject.Items.Add("Дом");
            cmbRealtyTypeAddNedvObject.Items.Add("Комната");
            cmbRealtyTypeAddNedvObject.Items.Add("Земля");
            
            for (int i = 0; i < myClients.clientsCount; i++)
            {
                cmbClientAddNedvObject.Text = myClients.getClient(0).Name;
                chkbxClients.Items.Add(myClients.getClient(i));
            }
            for (int i = 0; i < 5; i++)
            {
                cmbFloorAddNedvObject.Items.Add(i);
            }

            for (int i = 0; i < myTypes.typesCount; i++)
            {
                cmbLikved.Items.Add(myTypes.getTypes(i).Likved);
            }

            if (myFlats.flatsCount > 0)//?????????????????????
            {
                this.currentFlatNumber = 0;
                FillForm(myFlats.getFlat(currentFlatNumber));
                for (int i = 0; i < chkbxClients.Items.Count; i++)
                {
                    chkbxClients.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            btnNextRealty.Left = this.Width - btnNextRealty.Width-30;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myFlats.saveFlatsToFile();
                myClients.saveClientsToFile();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnPreviousRealty_Click(object sender, EventArgs e)//предыдущая страница
        {
            if (myFlats.flatsCount == 0)
            {
                MessageBox.Show(
                "Переход не может быть выполнен!",
                "Сообщение",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            }
            else
            {
                currentFlatNumber -= 1;
                if (currentFlatNumber < 0) { currentFlatNumber = myFlats.flatsCount - 1; }
                FillForm(myFlats.getFlat(currentFlatNumber));
                for (int i = 0; i < chkbxClients.Items.Count; i++)
                {
                    chkbxClients.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

        }

        private void btnNextRealty_Click(object sender, EventArgs e)//следующая страница
        {
            if (myFlats.flatsCount == 0)
            {
                MessageBox.Show(
                "Переход не может быть выполнен!",
                "Сообщение",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            }
            else
            {
                currentFlatNumber += 1;
                if (currentFlatNumber > myFlats.flatsCount - 1)
                {
                    currentFlatNumber = 0;
                }
                FillForm(myFlats.getFlat(currentFlatNumber));
                for (int i = 0; i < chkbxClients.Items.Count; i++)
                {
                    chkbxClients.SetItemCheckState(i, CheckState.Unchecked);
                    //if (chkbxClients == myClients.getClient(i).ToString())
                    //{
                    //    chkbxClients.SetItemCheckState(i , CheckState.Checked);
                    //    break;
                    //}
                }
            }
        }

        public bool ProverkaNaOtricZnach(int r)
        {
            bool bln = true;
            if (r <= 0)
            {
                bln = false;
                return bln;
            }
            return bln;
        }

        //public bool getAdress(string adress) // проверка адреса на повторение
        //{
        //    for (int i = 0; i < myFlats.flatsCount; i++)
        //    {
        //        if (adress == myFlats.getFlat(i).Address)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        private void btnChangeRealty_Click(object sender, EventArgs e)//кнопка изменить и обработка ерор провайдер
        {
            if (myFlats.flatsCount == 0)
            {
                MessageBox.Show(
                "Тут нечего изменять!",
                "Сообщение",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                txtBoxAreaAddNedvOjbect.Clear();
                cmbFloorAddNedvObject.ResetText();
                txtBoxAddPriceNedvObject.Clear();
                txtBoxOpisanieAddNedvObject.Clear();
                txtBoxAdressAddNedvObject.Clear();
                txtBoxRoomsCountAddNedvObject.Clear();
                cmbRealtyTypeAddNedvObject.ResetText();
            }
            else
            {
                for (int i = 0; i < myClients.clientsCount; i++)
                {
                    if (chkbxClients.GetItemChecked(i))
                    {
                        myFlats.changeClientOnFlat(currentFlatNumber, myClients.getClient(i));
                        myFlats.getFlat(currentFlatNumber).ClientID = myClients.getClient(i).ID;
                        cmbClientAddNedvObject.Text = myClients.getClient(i).Name;

                        break;
                        //if (i == myClients.clientsCount - 1)
                        //{
                        //    myFlats.changeClientOnFlat(currentFlatNumber, myFlats.getFlat(currentFlatNumber).clienttt);///////////////////////////!!!!!!!!!
                        //    myFlats.getFlat(currentFlatNumber).ClientID = myFlats.getFlat(currentFlatNumber).clienttt.ID;
                        //}
                    }
                }
                bool allIsGood;
                errorProvider1.Clear();
                //string patternAdress = @"^[а-яА-ЯёЁa-zA-Z0-9]+$";
                //string patternAdressletters = @"^[а-яА-ЯёЁa-zA-Z]+$";
                //string patternAdressnumbers = @"^[0 - 9] +$";

                if (isNumberINString(txtBoxAddPriceNedvObject.Text) == false) // обработка ошибок ЦЕНА
                {
                    errorProvider1.SetError(txtBoxAddPriceNedvObject, "Не указана цена");
                    allIsGood = false;
                }

                else if (ProverkaNaOtricZnach(Convert.ToInt32(txtBoxAddPriceNedvObject.Text)) == false) // обработка цены на отрицательное число
                {
                    errorProvider1.SetError(txtBoxAddPriceNedvObject, "Цена не может быть отрицательной или равно 0");
                    allIsGood = false;
                }

                /////////////
                else if (isDigitsInString(txtBoxAdressAddNedvObject.Text) == false || isNumberINString(txtBoxAdressAddNedvObject.Text) == true)//обработка ошибок АДРЕСС
                {
                    errorProvider1.SetError(txtBoxAdressAddNedvObject, "Тут должны быть цифры и буквы");
                    allIsGood = false;
                }

                else if (cmbRealtyTypeAddNedvObject.Text == "Земля" && cmbFloorAddNedvObject.Text != "0")
                {
                    errorProvider1.SetError(cmbFloorAddNedvObject, "Тут должен быть 0");
                    allIsGood = false;
                }

                else if (cmbRealtyTypeAddNedvObject.Text == "Земля" && txtBoxRoomsCountAddNedvObject.Text != "0")
                {
                    errorProvider1.SetError(txtBoxRoomsCountAddNedvObject, "Тут должен быть 0");
                    allIsGood = false;

                }

                else if (ProverkaNaOtricZnach(Convert.ToInt32(txtBoxRoomsCountAddNedvObject.Text)) == false)
                {
                    errorProvider1.SetError(txtBoxRoomsCountAddNedvObject, "Тут должен быть 0 или отрицательное значение");
                    allIsGood = false;

                }

                else if (isNumberINString(txtBoxAreaAddNedvOjbect.Text) == false)// обработка ошибок ПЛОЩАДЬ
                {
                    errorProvider1.SetError(txtBoxAreaAddNedvOjbect, "Не верные данные");
                    allIsGood = false;
                }
                ////////////////
                else if (String.IsNullOrWhiteSpace(txtBoxAdressAddNedvObject.Text))// обработка ошибок АДРЕСС
                {
                    errorProvider1.SetError(txtBoxAdressAddNedvObject, "Не указан адресс");
                    allIsGood = false;
                }

                //else if (getAdress(txtBoxAdressAddNedvObject.Text) == false) // проверка адреса на повторение
                //{
                //    errorProvider1.SetError(txtBoxAdressAddNedvObject, "Этот адресс уже занят");
                //    allIsGood = false;
                //}

                else if (String.IsNullOrWhiteSpace(cmbFloorAddNedvObject.Text))// обработка ошибок ЭТАЖ
                {
                    errorProvider1.SetError(cmbFloorAddNedvObject, "Не указан этаж");
                    allIsGood = false;
                }

                else if (isNumberINString(cmbFloorAddNedvObject.Text) == false)// обработка ошибок ЭТАЖ
                {
                    errorProvider1.SetError(cmbFloorAddNedvObject, "Тут должны быть цифры");
                    allIsGood = false;
                }

                else if (String.IsNullOrWhiteSpace(txtBoxRoomsCountAddNedvObject.Text))// обработка ошибок КОЛИЧЕСТВО КОМНАТ
                {
                    errorProvider1.SetError(txtBoxRoomsCountAddNedvObject, "Пустое поле");
                    allIsGood = false;
                }

                else if (isNumberINString(txtBoxRoomsCountAddNedvObject.Text) == false)// обработка ошибок КОЛИЧЕСТВО КОМНАТ
                {
                    errorProvider1.SetError(txtBoxRoomsCountAddNedvObject, "Тут должны быть цифры");
                    allIsGood = false;
                }

                //else if (isNumberINString(cmbClientAddNedvObject.Text) == false)// обработка ошибок КЛИЕНТ
                //{
                //    errorProvider1.SetError(cmbClientAddNedvObject, "Здесь должен быть номер клиента");
                //    allIsGood = false;
                //}

                //else if (String.IsNullOrWhiteSpace(cmbClientAddNedvObject.Text))// обработка ошибок КЛИЕНТ
                //{
                //    errorProvider1.SetError(cmbClientAddNedvObject, "Не указан клиент");
                //    allIsGood = false;
                //}

                //else if (searchClient(cmbClientAddNedvObject.Text) == false)// обработка ошибок КЛИЕНТ
                //{
                //    errorProvider1.SetError(cmbClientAddNedvObject, "Такой клиент не найден");
                //    allIsGood = false;
                //}

                else if (String.IsNullOrWhiteSpace(cmbRealtyTypeAddNedvObject.Text))// обработка ошибок ТИП НЕДВИЖИМОСТИ
                {
                    errorProvider1.SetError(cmbRealtyTypeAddNedvObject, "Не указан тип недвижимости");
                    allIsGood = false;
                }

                else if (serchNedvijimost(cmbRealtyTypeAddNedvObject.Text) == false)// обработка ошибок ТИП НЕДВИЖИМОСТИ
                {
                    errorProvider1.SetError(cmbRealtyTypeAddNedvObject, "Такого типа недвижимости не существует");
                    allIsGood = false;
                }

                else if (String.IsNullOrWhiteSpace(txtBoxAreaAddNedvOjbect.Text))// обработка ошибок ПЛОЩАДЬ
                {
                    errorProvider1.SetError(txtBoxAreaAddNedvOjbect, "Не указана площадь");
                    allIsGood = false;
                }

                else if (ProverkaNaOtricZnach(Convert.ToInt32( txtBoxAreaAddNedvOjbect.Text))==false)// обработка ошибок ПЛОЩАДЬ (Не равно 0)
                {
                    errorProvider1.SetError(txtBoxAreaAddNedvOjbect, "Площадь не может быть отрицательной или равно 0");
                    allIsGood = false;
                }

                else if (String.IsNullOrWhiteSpace(txtBoxOpisanieAddNedvObject.Text))// обработка ошибок ОПИСАНИЕ
                {
                    errorProvider1.SetError(txtBoxOpisanieAddNedvObject, "Не указано описание");
                    allIsGood = false;
                }

                else if (isNumberINString(cmbLikved.Text) == true)
                {
                    errorProvider1.SetError(cmbLikved, "Не верные данные");
                    allIsGood = false;
                }


                else
                {
                    errorProvider1.Clear();
                    allIsGood = true;
                }

                ///////////////////
                if (allIsGood == true)
                {
                    myFlats.getFlat(currentFlatNumber).RoomsCount = Convert.ToInt32(txtBoxRoomsCountAddNedvObject.Text);
                    myFlats.getFlat(currentFlatNumber).Area = Convert.ToInt32(txtBoxAreaAddNedvOjbect.Text);
                    myFlats.getFlat(currentFlatNumber).Price = Convert.ToInt32(txtBoxAddPriceNedvObject.Text);
                    myFlats.getFlat(currentFlatNumber).Description = txtBoxOpisanieAddNedvObject.Text;
                    myFlats.getFlat(currentFlatNumber).Address = txtBoxAdressAddNedvObject.Text;
                    myFlats.getFlat(currentFlatNumber).Floor = Convert.ToInt32(cmbFloorAddNedvObject.Text);
                    myFlats.getFlat(currentFlatNumber).RealtyType = cmbRealtyTypeAddNedvObject.Text;
                    myFlats.getFlat(currentFlatNumber).Likvid = getLikvid(cmbLikved.Text);

                    dataGridView1.Rows[currentFlatNumber].Cells[1].Value = cmbRealtyTypeAddNedvObject.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[2].Value = txtBoxRoomsCountAddNedvObject.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[3].Value = cmbFloorAddNedvObject.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[4].Value = txtBoxAreaAddNedvOjbect.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[5].Value = txtBoxAddPriceNedvObject.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[6].Value = txtBoxAdressAddNedvObject.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[7].Value = txtBoxOpisanieAddNedvObject.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[8].Value = txtBoxOpisanieAddNedvObject.Text;
                    dataGridView1.Rows[currentFlatNumber].Cells[8].Value = cmbLikved.Text;

                    //myFlats.getFlat(currentNumber).ID = rbClients.First(x.Checked== true).Tag;

                    ////////////////////////////myFlats.getFlat(currentFlatNumber).ClientID = chkbxClients.SelectedIndex;

                    myFlats.saveFlatsToFile();
                    //myClients.saveClientsToFile();



                    //string checkedRadioTag="";
                    //foreach (RadioButton rb in rbClients)
                    //{
                    //    if (rb.Checked==true)
                    //    {
                    //        checkedRadioTag = rb.Tag.ToString(); ;
                    //    }
                    //}




                    //MessageBox.Show("Test");

                }
                


            }

        }
        
        public int getLikvid(string likvid)//вспомогательное свойсвтво
        {
            for (int i = 0; i < myTypes.typesCount; i++)
            {
                if (likvid == myTypes.getTypes(i).Likved)
                {
                    return myTypes.getTypes(i).ID;
                }
            }
            return 1;
        }

        private void chkbxClients_SelectedIndexChanged(object sender, EventArgs e)//чекбокс
        {
            string s = "";

            for (int i = 0; i < chkbxClients.Items.Count; i++)
            {
                s = s + chkbxClients.GetItemChecked(i).ToString() + "\n";
                chkbxClients.SetItemCheckState(i, CheckState.Unchecked);
            }
            try
            {
                chkbxClients.SetItemCheckState(chkbxClients.SelectedIndex, CheckState.Checked); 
            }
            catch
            {
                chkbxClients.SetItemCheckState(0, CheckState.Checked); 
            }
                
        }



        private void btnDeleteNedvObject_Click(object sender, EventArgs e)//кнопка удалить
        {
            if (myFlats.flatsCount == 1)
            {
                MessageBox.Show(
                "Тут нечего удалять!",
                "Сообщение",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
               if (myFlats.flatsCount == 1)
               {
                 this.Text = "";
                 cmbRealtyTypeAddNedvObject.Text = "";
                 cmbFloorAddNedvObject.Text = "";
                 cmbClientAddNedvObject.Text = "";
                 txtBoxAdressAddNedvObject.Text = "";
                 txtBoxAddPriceNedvObject.Text = "";
                 txtBoxOpisanieAddNedvObject.Text = "";
                 txtBoxRoomsCountAddNedvObject.Text = "";
                 txtBoxAreaAddNedvOjbect.Text = "";
                    //cmbType.SelectedItem = "";
                    //cmbFloor.SelectedItem = "";
                    //cmbDeleteNedvObject.Items.RemoveAt(i);
                    //cmbDeleteNedvObject.ResetText();
               }
               else
               {
                myFlats.remove(myFlats.getFlat(currentFlatNumber));
                    dataGridView1.Rows.RemoveAt(currentFlatNumber);

                btnPreviousRealty_Click(sender, e);
                //FillForm(myFlats.getFlat(0));
               }

            }
            
            
        }

        public string returnClient(string clientName)//вспомогательный метод
        {
            for (int i = 0; i < myClients.clientsCount; i++)
            {
                if (clientName == myClients.getClient(i).Name)
                {
                    return myClients.getClient(i).ID.ToString();
                }
            }
            return "a";
        }

        public bool serchNedvijimost(string stroka) //поиск введенных в строку значений с объектами комбо бокса
        {
            for (int i = 0; i < cmbRealtyTypeAddNedvObject.Items.Count; i++)
            {
                if (stroka == cmbRealtyTypeAddNedvObject.Items[i].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public bool searchClient(string name)// поиск имеющихся клиентов по id
        {
            for (int i = 0; i < myClients.clientsCount; i++)
            {
                if (myClients.getClient(i).Name == cmbClientAddNedvObject.Text)
                {
                    return true;
                }
            }
            return false;
        }


        //^[а-яА-ЯёЁa-zA-Z0-9]+$
        /// <summary>
        /// Определяет есть ли в строке хотя бы одна цифра
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool isDigitsInString(string s)
        {
            //можно проверять адрес на наличие и букв и цифр
            string checkAlphabet = "0123456789";

            for (int i = 0; i < checkAlphabet.Length; i++)
            {
                if (s.Contains(checkAlphabet[i])) {return true;}
            }
            return false;
        }

        private bool isNumberINString(String s)//проверка на трай парсе
        {
            Int32 z=0;
            return Int32.TryParse(s,out z);
        }


        private void btnSaveForm_Click(object sender, EventArgs e)//кнопка сохранить
        {
            myFlats.saveFlatsToFile();
            myClients.saveClientsToFile();
        }

        //private void button1_Click(object sender, EventArgs e)//кнопка добавить
        //{
        //    this.Visible = false;
        //    if (frmAdd == null)
        //    { frmAdd = new Form2(myFlats, myClients, myTypes, this); }
        //    frmAdd.Show();
        //}

        private void btnAddRealty_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (frmAdd == null)
            { frmAdd = new Form2(myFlats, myClients, myTypes, this, dataGridView1); }
            frmAdd.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        //private void append(ref Flats flatsTable, Clients clients)//добавить строку



    }
}
