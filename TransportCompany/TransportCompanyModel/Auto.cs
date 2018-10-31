using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompanyModel
{
    public class Auto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public decimal Summa { get; set; }

        [ForeignKey("AutoId")]
        public virtual List<Order> Orders { get; set; }
    }
}
