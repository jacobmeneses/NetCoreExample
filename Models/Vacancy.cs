using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppMvc.Models
{
    public class Vacancy 
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate{ get; set; }
        public string Description{ get; set; }
        public decimal Salary{ get; set; }
    }
}