using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_1
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("\nOpen XML File...\n");
        }
        public override void Create()
        {
            Console.WriteLine("\nCreate XML File...\n");
        }
        public override void Change()
        {
            Console.WriteLine("\nChange XML File...\n");
        }
        public override void Save()
        {
            Console.WriteLine("\nSave XML File...\n");
        }
    }
}
