using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG_282
{
    internal class Filehandler
    {
        static string thePath = @"../users.txt";
        public static string[] myusers;
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        
        public static void WritUser(string newUser)
        {
            try
            {
                using(fs = new FileStream(thePath, FileMode.Append, FileAccess.Write))
                {
                    using(sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(newUser)
                    }
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
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

                MessageBox.Show(e.Message);
            }
        }

        


    }
}
