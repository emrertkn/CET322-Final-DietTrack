﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiyetTakip.Models
{
    public class Day
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CalorieAmount { get; set; }
        public bool CaloriePassorFail { get; set; }
        public List<Food> Foods {get; set;}
        
    }
}
