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
        int counter;

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

        //Writes the list of users to txt, overwrites existing content
        public void WriteToFile()
        {
            TextWriter tw = new StreamWriter(path);
            foreach (BusinessLogicClasses.User user in users)
            {
                string newline = user.Username + "," + user.Password + "," + user.Password;
                tw.WriteLine(newline);
            }
        }


    }
}
