using System;
using System.Collections.Generic;
using System.Text;

namespace SqlCrud
{
    class Customer
    {
       public static void Insert(string name,string surname,int age)
       {
            Sql.Execute($"INSERT INTO Customer VALUES('{name}','{surname}','{age}')");
       }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE FROM CUSTOMER WHERE Id ={id}");
        }
        public static void GetAll()
        {
            Sql.Select("SELECT * FROM CUSTOMER");
        }
        public static void Update(string query)
        {
            Sql.Execute(query);
        }


    }
}
