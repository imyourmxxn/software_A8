using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using HotelMain;

namespace Reserve
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerUI());
            Application.Run(new Reserv_Form());
            Application.Run(new Reservlist_Form());
            Application.Run(new Reservcheck_Form());
        }
    }
}
