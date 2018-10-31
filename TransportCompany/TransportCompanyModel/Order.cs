using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompanyModel
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int Km { get; set; }

        public decimal Summa { get; set; }

        public DateTime DateOfCreate { get; set; }

        public DateTime? DateOfImplement { get; set; }

        public virtual Client Client { get; set; }

        public virtual Auto Auto { get; set; }

    }
}
