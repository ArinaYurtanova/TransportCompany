using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompanyService.BindingModel
{
    public class OrderBindingModel
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int Km { get; set; }

        public decimal Summa { get; set; }

        
    }
}
