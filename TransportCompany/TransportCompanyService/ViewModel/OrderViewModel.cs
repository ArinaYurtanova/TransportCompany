using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompanyService.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string ClientFIO { get; set; }

        public string DateOfCreate { get; set; }

        public string AutoName { get; set; }

        public int Km { get; set; }

        public decimal Summa { get; set; }
    }
}
