using System;
using System.Collections.Generic;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAttendance
{
    public class Online_Attendance
    {
        public event Action<string> BannedName;
        public List<string> UserName = new List<string>();

        public void Attendance()
        {
            var random = new Random();
            for (int i=0;i< random.Next(0,15);++i)
            {
                //Users input their name and it check if names are banned for the organization
                UserName.Add(Console.ReadLine());

                if ((UserName[i] == "Jack" || UserName[i] == "Steven" || UserName[i] == "Mathew") && BannedName!=null)
                {
                    this.BannedName(UserName[i]);
                   

                }
                else Console.WriteLine("Welcome to {0}", UserName[i]);
            }
        }


    }
}
