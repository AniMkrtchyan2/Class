using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name ");
            var attendance = new Online_Attendance();
            attendance.BannedName += OnBannedName;
            attendance.Attendance();
        }

        private static void OnBannedName(string obj)
        {
            Console.WriteLine("try again! this UserName is banned");
        }
    }
}
