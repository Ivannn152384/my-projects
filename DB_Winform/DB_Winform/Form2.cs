using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB_RieltorCompany;

namespace DB_Winform
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        Flats myFlats;
        Clients myClients;
        types myTypes;
        DataGridView DataGriddd;


        public Form2(Flats myFlats, Clients myClients, types myTypes, Form1 form1, DataGridView dataGrid)
        {
            this.myFlats = myFlats;
            this.myClients = myClients;
            this.myTypes = myTypes;
            this.DataGriddd = dataGrid;
            mainForm = form1;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Добавление недвижимости";
            cmbRealtyTypeAddNedvObject.Items.Add("Квартира");
            cmbRealtyTypeAddNedvObject.Items.Add("Дом");
            cmbRealtyTypeAddNedvObject.Items.Add("Комната");
            cmbRealtyTypeAddNedvObject.Items.Add("Земля");

            for (int i = 0; i < myClients.clientsCount; i++)
            {
                cmbClientAddNedvObject.Items.Add(myClients.getClient(i).Name);
            }
            for (int i = 0; i < 5; i++)
            {
                cmbFloorAddNedvObject.Items.Add(i);
            }

            for (int i = 0; i < myTypes.typesCount; i++)
            {
                cmbLikved.Items.Add(myTypes.getTypes(i).Likved);
            }
            
        }

        

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
            this.Hide();
            e.Cancel = true;
        }

        private bool isDigitsInString(string s)
        {
            //почитать про регулярные выражения!!!!
            //можно проверять адрес на наличие и букв и цифр....!!!
            string checkAlphabet = "0123456789";

            for (int i = 0; i < checkAlphabet.Length; i++)
            {
                if (s.Contains(checkAlphabet[i])) { return true; }
            }
            return false;
        }

        private bool isNumberINString(String s)//проверка на трай парсе
        {
            Int32 z = 0;
            return Int32.TryParse(s, out z);
        }

        public string returnClient(string clientName)
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

        public int returnTipe(string typeN)
        {
            for (int i = 0; i < myTypes.typesCount; i++)
            {
                if (typeN == myTypes.getTypes(i).Likved)
                {
                    return myTypes.getTypes(i).ID;
                }
            }
            return 1;
        }

        public bool getAdress(string adress)
        {
            for (int i = 0; i < myFlats.flatsCount; i++)
            {
                if (adress == myFlats.getFlat(i).Address)
                {
                    return false;
                }
            }
            return true;
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

        private void btnAddNedvObject_Click(object sender, EventArgs e)
        {
            bool allIsGood = false;
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

            else if (getAdress(txtBoxAdressAddNedvObject.Text) == false)
            {
                errorProvider1.SetError(txtBoxAdressAddNedvObject, "Этот адресс уже занят");
                allIsGood = false;
            }

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

            else if (ProverkaNaOtricZnach(Convert.ToInt32(txtBoxRoomsCountAddNedvObject.Text)) == false)
            {
                errorProvider1.SetError(txtBoxRoomsCountAddNedvObject, "Тут не должен быть 0 или отрицательное значение");
                allIsGood = false;
            }


            else if (isNumberINString(txtBoxRoomsCountAddNedvObject.Text) == false)// обработка ошибок КОЛИЧЕСТВО КОМНАТ
            {
                errorProvider1.SetError(txtBoxRoomsCountAddNedvObject, "Тут должны быть цифры");
                allIsGood = false;
            }

            else if (isNumberINString(cmbClientAddNedvObject.Text) == true)// обработка ошибок КЛИЕНТ
            {
                errorProvider1.SetError(cmbClientAddNedvObject, "Здесь не может быть цифр");
                allIsGood = false;
            }

            else if (String.IsNullOrWhiteSpace(cmbClientAddNedvObject.Text))// обработка ошибок КЛИЕНТ
            {
                errorProvider1.SetError(cmbClientAddNedvObject, "Не указан клиент");
                allIsGood = false;
            }



            else if (String.IsNullOrWhiteSpace(cmbRealtyTypeAddNedvObject.Text))// обработка ошибок ТИП НЕДВИЖИМОСТИ
            {
                errorProvider1.SetError(cmbRealtyTypeAddNedvObject, "Не указан тип недвижимости");
                allIsGood = false;
            }

            else if (String.IsNullOrWhiteSpace(cmbLikved.Text))
            {
                errorProvider1.SetError(cmbLikved, "Не указана Ликвидность");
                allIsGood = false;
            }

            else if (String.IsNullOrWhiteSpace(txtBoxAreaAddNedvOjbect.Text))// обработка ошибок ПЛОЩАДЬ
            {
                errorProvider1.SetError(txtBoxAreaAddNedvOjbect, "Не указана площадь");
                allIsGood = false;
            }

            else if (ProverkaNaOtricZnach(Convert.ToInt32(txtBoxAreaAddNedvOjbect.Text)) == false)// обработка ошибок ПЛОЩАДЬ (Не равно 0)
            {
                errorProvider1.SetError(txtBoxAreaAddNedvOjbect, "Площадь не может быть отрицательной или равно 0");
                allIsGood = false;
            }


            else if (String.IsNullOrWhiteSpace(txtBoxOpisanieAddNedvObject.Text))// обработка ошибок ОПИСАНИЕ
            {
                errorProvider1.SetError(txtBoxOpisanieAddNedvObject, "Не указано описание");
                allIsGood = false;
            }

            else
            {
                errorProvider1.Clear();
                allIsGood = true;
            }

            //if (isDigitsInString(txtBoxOpisanieAddNedvObject.Text)==false)// обработка ошибок ОПИСАНИЕ
            //{
            //    errorProvider1.SetError(txtBoxOpisanieAddNedvObject, "В описании должна быть хотя бы одна цифра!!!");
            //    allIsGood = false;
            //}

            if (allIsGood == true)//Добавление недвижимости
            {
                string newDataStringFor = myFlats.nextId + ";" + cmbRealtyTypeAddNedvObject.Text + ";" + txtBoxRoomsCountAddNedvObject.Text + ";" + cmbFloorAddNedvObject.Text + ";" + txtBoxAreaAddNedvOjbect.Text + ";" + txtBoxAddPriceNedvObject.Text + ";" + txtBoxAdressAddNedvObject.Text + ";" + txtBoxOpisanieAddNedvObject.Text + ";" + returnClient(cmbClientAddNedvObject.Text) + ";" + returnTipe(cmbLikved.Text);// последний элемент не подходит!!!!!!!!!!!!!!!!!!!!!

                if (myFlats.flatsCount == 0)
                {
                    newDataStringFor = "1" + ";" + cmbRealtyTypeAddNedvObject.Text + ";" + txtBoxRoomsCountAddNedvObject.Text + ";" + cmbFloorAddNedvObject.Text + ";" + txtBoxAreaAddNedvOjbect.Text + ";" + txtBoxAddPriceNedvObject.Text + ";" + txtBoxAdressAddNedvObject.Text + ";" + txtBoxOpisanieAddNedvObject.Text + ";" + returnClient(cmbClientAddNedvObject.Text);// последний элемент не подходит!!!!!!!!!!!!!!!!!!!!!
                }

                DataGriddd.Rows.Add();
                DataGriddd.Rows[myFlats.nextId-1].Cells[0].Value = myFlats.nextId;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[1].Value = cmbRealtyTypeAddNedvObject.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[2].Value = txtBoxRoomsCountAddNedvObject.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[3].Value = cmbFloorAddNedvObject.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[4].Value = txtBoxAreaAddNedvOjbect.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[5].Value = txtBoxAddPriceNedvObject.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[6].Value = txtBoxAdressAddNedvObject.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[7].Value = txtBoxOpisanieAddNedvObject.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[8].Value = txtBoxOpisanieAddNedvObject.Text;
                DataGriddd.Rows[myFlats.nextId - 1].Cells[8].Value = cmbLikved.Text;



                myFlats.add(new Flat(newDataStringFor, myClients));


                cmbRealtyTypeAddNedvObject.SelectedIndex = -1;
                txtBoxAddPriceNedvObject.ResetText();
                cmbClientAddNedvObject.SelectedIndex = -1;
                cmbFloorAddNedvObject.SelectedIndex = -1;
                txtBoxAreaAddNedvOjbect.ResetText();
                txtBoxRoomsCountAddNedvObject.ResetText();
                txtBoxOpisanieAddNedvObject.ResetText();
                txtBoxAdressAddNedvObject.ResetText();
                cmbLikved.SelectedIndex = -1;
                MessageBox.Show("Добавлено!");
                myFlats.saveFlatsToFile();

            }
        }

       
    }
}
