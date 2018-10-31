using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompanyService.BindingModel;
using TransportCompanyService.ViewModel;

namespace TransportCompanyService.Interfaces
{
    public interface IOrder
    {
        List<OrderViewModel> GetList(int id);

        List<OrderViewModel> GetList();

        void CreateOrder(OrderBindingModel model);

        void PayOrder(OrderBindingModel model);

        OrderViewModel GetElement(int id);
    }
}
