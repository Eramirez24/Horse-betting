using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_betting
{
    public class Horses
    {
        public int Gate_num { get; }
        public string Horse_name { get; }


        public Horses(int num, string name)
        {
            this.Gate_num = num;
            this.Horse_name = name;
        }

        public override string ToString() => $"{Gate_num}: {Horse_name}";



    }
}
