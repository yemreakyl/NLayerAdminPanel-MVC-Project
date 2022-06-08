﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTİES
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreateTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
