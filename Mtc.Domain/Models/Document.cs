﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtc.Domain.Models
{
    public class Document
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public Person Author { get; set; }
        public ICollection<Section> Sections { get; set; }
        public DateTime Deadline { get; set; }
        public DocumentState CurrentProgress { get; set; }
        public Person Mentor { get; set; }
    }
}