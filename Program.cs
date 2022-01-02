using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List
{
    public class Users
    {
        string firstName;
        string lastName;

        public string FIRSTNAME { get => firstName; set => firstName = value; }
        public string LASTNAME { get => lastName; set => lastName = value; }

    }



    class Program
    {
        static void Main(string[] args)
        {

            Users user = new Users();


            List<Users> userList = new List<Users>();

            userList.Add(new Users()

            {
                FIRSTNAME = "Mutlu",
                LASTNAME ="Fındıkçı"
            }
            );


            user.FIRSTNAME = "Ahmet";
            user.LASTNAME = "Altın";

            userList.Add(user);

            userList.ForEach(name => Console.WriteLine(name.FIRSTNAME+" "+name.LASTNAME));


            Console.ReadKey();
        }
    }
}
