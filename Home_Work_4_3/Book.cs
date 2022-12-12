using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_3
{
    internal class Book
    {
        Document titleName = null;
        Document text = null;
        Document authorName = null;

        void InitializeDocument()
        {
            this.titleName = new Title();
            this.text = new Body();
            this.authorName = new Author();
        }
        public Book(string title)
        {
            InitializeDocument();
            this.titleName.Content = title;
        }
        public void Show()
        {
            this.titleName.Show();
            this.text.Show();
            this.authorName.Show();
        }
        public string Text
        {
            set
            {
                this.text.Content = value;
            }
        }

        public string AuthorName
        {
            set
            {
                this.authorName.Content = value;
            }
        }
    }
}
