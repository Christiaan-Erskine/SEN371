using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_1.DataAccessLayer
{
    internal class txtFileHandler
    {
        //string path = System.IO.File.ReadAllText(@"../DataLayer/");
        static string path = @"../../DataLayer/Users.txt";
        string[] lines = File.ReadAllLines(path);
        public static int counter;

        public List<BusinessLogicClasses.User> users = new List<BusinessLogicClasses.User>(); 

        public txtFileHandler()
        {
            counter = 0;

            foreach (string line in lines)
            {
                string cut = line;
                counter++;

                //Splits lines by comma as delimmeter into different paramaters
                string username = cut.Split(',')[0];
                cut = line.Remove(0, username.Length +1);
                string password = cut.Split(',')[0];
                cut = line.Remove(0, password.Length +1 +1 +1); // <------- Some logic error occurred, needs +3 too position before it sees a comma?
                string type = cut.Split(',')[0];

                //Create new user object from every line in text file
                users.Add(new BusinessLogicClasses.User(username, password, type));
            }
            //lines = new string[0];
        }

        //Appends new user to the file
        public void AddNewUser(BusinessLogicClasses.User newUser)
        {
            TextWriter tw = new StreamWriter(path);
            string newline = newUser.Username + "," + newUser.Password + "," + newUser.EmployeeType;

            tw.WriteLine(newline);
            tw.Close();

        }

        //Writes the list of users to txt, appends to existing content
        public void WriteToFile()
        {
            TextWriter tw = new StreamWriter(path);

           foreach (BusinessLogicClasses.User user in users)
            {
                string newline = user.Username + "," + user.Password + "," + user.EmployeeType;
                tw.WriteLine(newline);
            }

            for(int i = 0; i < counter; i++)
            {
                BusinessLogicClasses.User user = users[i];
                string newline = user.Username + "," + user.Password + "," + user.EmployeeType;
                tw.WriteLine(newline);
            }

            tw.Close();
        }

        public void MockData()
        {
            TextWriter tw = new StreamWriter(path);

            BusinessLogicClasses.User newuser1 = new BusinessLogicClasses.User("1", "5ecurePassword!", "Client Data Manager");
            BusinessLogicClasses.User newuser2 = new BusinessLogicClasses.User("2", "jim1982", "Technician");
            BusinessLogicClasses.User newuser3 = new BusinessLogicClasses.User("3", "Dave1234", "Callcentre Employee");

            users.Add(newuser1);
            users.Add(newuser2);
            users.Add(newuser3);

            WriteToFile();

            tw.Close();
        }


    }
}
