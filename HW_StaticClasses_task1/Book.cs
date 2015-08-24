using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StaticClasses_task1
{
    class Book
    {
        private class Notes
        {
            private string _text;

            public Notes(string text)
            {
                _text = text;
            }

            public string Text
            {
                get;
                set;
            }
        }

        private const int NumberOfPages = 200;
        private List<Tuple<string, Notes>> _pages = new List<Tuple<string, Notes>>();

        public Book()
        {
            for (int i = 0; i < NumberOfPages; i++)
            {
                string page = string.Format("Page {0}", i);
                Notes notes = new Notes(string.Format("Notes {0}", i));
                _pages.Add(new Tuple<string, Notes>(page, notes));
            }
        }

    }
}
