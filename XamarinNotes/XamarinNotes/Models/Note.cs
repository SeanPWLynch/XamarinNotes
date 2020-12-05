using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNotes.Models
{
    class Note
    {
        public string fileName { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
    }
}
