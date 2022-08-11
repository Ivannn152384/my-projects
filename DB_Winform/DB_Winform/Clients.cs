using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DB_RieltorCompany
{
    public class Clients
    {
        private List<Client> listClient = new List<Client>();
        const string titleConst = "id;Номер телефона;ФИО Клиента;Адрес Клиента;Email Клиента";
        public int clientsCount { get { return listClient.Count; } }
        #region Properties

        public string Title
        { get { return titleConst; } }

        public void remove(Client client)//удаление строки
        {
            try
            {
                this.listClient.Remove(client);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("Ты не то удаляешь, скорее всего такого ID нет..." + e.Data);
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Ошибка индекс за пределами диапазона");
            }
        }

        public Client returnClient(int id)
        {
            int sch = 0;
                for (int j = 0; j < listClient.Count; j++)
                {
                    if (id == listClient[j].id)
                    {
                        sch = j;
                        break;
                    }
                }
            return listClient[sch];
        }
        public void add(Client f)
        {
            this.listClient.Add(f);
        }

        public void saveClientsToFile()
        {
            string sOut = "";
            foreach (Client f in this.listClient)
            {
                sOut = sOut + f.conservation(";") + "\n";
            }

            File.WriteAllText("clients.csv", sOut, Encoding.UTF8);


        }

        public int nextId //поиск нового айди
        {
            get
            {
                int m = int.MinValue;
                foreach (Client f in this.listClient)
                {
                    if (f.id > m)
                    {
                        m = f.id;
                    }
                }
                return m + 1;
            }
        }

        #endregion
        public Clients(string fileName)
        {
            string[] massivStrok = File.ReadAllLines(fileName, Encoding.UTF8);
            for (int i = 0; i < massivStrok.Length; i++)
            {
                listClient.Add(new Client(massivStrok[i]));
            }
        }
        public Client getClient(int number)
        {
            try
            {
                return listClient[number];
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        
    }
}
