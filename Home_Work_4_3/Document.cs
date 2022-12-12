using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_3
{
    abstract class Document
    {
        protected string content;
        public abstract string Content { get; set; }
        public abstract void Show();
    }
}
