using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_App2
{
    public class BlogPost
    {
        // Fields

        string _header; // Holds Header value
        string _body; // Holds Body value
        DateTime _posted; // Holds time post was created

        // Highlighted x2 Fields above^ and right clicked and created constructor below:
        // The DateTime will get assigned within the constructor

        // Constructor
        public BlogPost(string header, string body)
        {
            _header = header;
            _body = body;
            _posted = DateTime.Now; // Here we assign the new value for DateTime
        }

        // Properties
        public string Header { get => _header; set => _header = value; }
        public string Body { get => _body; set => _body = value; }
        public DateTime Posted { get => _posted; set => _posted = value; }

        // Methods
        // here we create a method that returns a string.
        public string Post()
        {
            // Date - Header
            // Body

            string date = _posted.ToShortDateString();
            string header = $"{date} - {_header}";
            string space = $"\n\n";
            string body = _body;

            string full = header + space + body;

            return full;
        }



    }
}
