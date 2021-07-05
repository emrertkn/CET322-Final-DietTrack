using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiyetTakip.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calorie { get; set; }
        public int Amount { get; set; }
        public Day Day {get; set;}
        public int DayId {get; set;}
        public bool IsComplete { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
