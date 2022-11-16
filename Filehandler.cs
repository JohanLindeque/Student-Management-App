using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG_282
{
    internal class Filehandler
    {
        static string thePath = @"../users.txt";
        public static string[] myusers;
        
        public static void WritUser(string newUser)
        {
            try
            {
                File.AppendAllText(thePath, newUser);

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        public static void ReadUsers()
        {
            try
            {
                myusers= File.ReadAllLines(thePath);
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        


    }
}
