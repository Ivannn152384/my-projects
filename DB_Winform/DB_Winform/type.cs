using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DB_RieltorCompany;

namespace DB_Winform
{
    public class types
    {
        private List<type> listTypes = new List<type>();
        public int typesCount { get { return listTypes.Count; } }

        public types(string fileName)
        {
            string[] massivStrok = File.ReadAllLines(fileName, Encoding.UTF8);
            for (int i = 0; i < massivStrok.Length; i++)
            {
                listTypes.Add(new type(massivStrok[i]));
            }
        }

        public type getTypes(int number)
        {
            try
            {
                return listTypes[number];
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void saveTypesToFile()
        {
            string sOut = "";
            foreach (type f in this.listTypes)
            {
                sOut = sOut + f.conservation(";") + "\n";
            }

            File.WriteAllText("types.csv", sOut, Encoding.UTF8);


        }

    }

    public class type
    {
        public int id;
        string likved;
        string remontType;

        public type(string stroka)
        {
            string[] ItemsTypes = stroka.Split(';');
            id = Convert.ToInt32(ItemsTypes[0]);
            likved = ItemsTypes[1];
            this.remontType = ItemsTypes[2];
        }

        public string conservation(string delimeter)
        {
            string outS = "";
            //foreach (string item in this.Items)
            //{
            //outS += item + delimeter;
            //}
            outS += id + delimeter + likved + delimeter + remontType;
            return outS;
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Likved
        {
            get
            {
                return likved;
            }
            set
            {
                likved = value;
            }
        }
        public string RemontType
        {
            get
            {
                return remontType;
            }
            set
            {
                remontType = value.ToString();
            }
        }
        public string ToString(string delimeter)
        {
            string outS = "";
            //foreach (string item in this.ItemsClient)
            //{
            //  outS += item + delimeter;
            //}
            outS +=likved;
            return outS;
        }

        public override string ToString()
        {
            return this.ToString(";");
        }
    }
    }
