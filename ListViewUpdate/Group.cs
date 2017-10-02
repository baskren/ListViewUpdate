using System;
using System.Collections.Generic;
namespace ListViewUpdate
{
    public class Group : List<string>
    {
        public string Title
        {
            get;
            set;
        }

        public Group() { }

        public Group(string title)
        {
            Title = title;
        }
    }
}
