using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema2.ViewModels
{
    class StatisticiVM
    {
        public string RedWinners { get; set; }
        public string WhiteWinners { get; set; }

        public StatisticiVM()
        {
            string[] statistics = File.ReadAllLines("statistics.txt");

            RedWinners = " Castigatori rosii: " + statistics[0] + " ";
            WhiteWinners = " Castigatori albi: " + statistics[1] + " ";
        }

    }
}
