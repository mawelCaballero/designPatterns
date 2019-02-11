using System;

namespace ConsoleApp1
{
    public class Document
    {
        private string name;

        private string content;

        private int pages;

        public string Details()
        {
            return this.ToString();
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Content
        {
            get { return  content; }
            set { content = value; }
        }

        public  int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public override string ToString()
        {
            return $"<name> { Name } " +
                $"<pages> { Pages } " +
                $"<content> { Content }  ";
        }
    }
}