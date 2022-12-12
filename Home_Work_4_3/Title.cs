using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_Work_4_3
{
    internal class Title : Document
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Write Author name";
            }
            set
            {
                content = value;
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
