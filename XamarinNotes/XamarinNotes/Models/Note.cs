﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNotes.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date{ get; set; }
    }
}
