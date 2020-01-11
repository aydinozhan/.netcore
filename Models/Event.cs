﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_core_bootcamp_b1_aydinozhan.Models
{
    public class Event
    {

        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public string Address { get; set; }

        public bool IsFree { get; set; }

        public double Price { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }



    }
}
