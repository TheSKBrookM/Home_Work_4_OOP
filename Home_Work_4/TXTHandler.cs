using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_1
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("\nOpen TXT File...\n");
        }
        public override void Create()
        {
            Console.WriteLine("\nCreate TXT File...\n");
        }
        public override void Change()
        {
            Console.WriteLine("\nChange TXT File...\n");
        }
        public override void Save()
        {
            Console.WriteLine("\nSave TXT File...\n");
        }
    }
}
