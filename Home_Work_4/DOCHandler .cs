using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_1
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("\nOpen DOC File...\n");
        }
        public override void Create()
        {
            Console.WriteLine("\nCreate DOC File...\n");
        }
        public override void Change()
        {
            Console.WriteLine("\nChange DOC File...\n");
        }
        public override void Save()
        {
            Console.WriteLine("\nSave DOC File...\n");
        }
    }
}
