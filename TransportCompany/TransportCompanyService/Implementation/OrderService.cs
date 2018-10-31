using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompanyModel;
using TransportCompanyService.BindingModel;
using TransportCompanyService.Interfaces;
using TransportCompanyService.ViewModel;

namespace TransportCompanyService.Implementation
{
    public class OrderService: IOrder
    {
        private TransportCompanyDbContext context;

        public OrderService(TransportCompanyDbContext context)
        {
            this.context = context;
        }

        public OrderViewModel GetElement(int id)
        {
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new OrderViewModel
                {
                    Id = element.Id,
                    ClientId = element.ClientId,
                    Summa = element.Summa,
                    
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<OrderViewModel> GetList(int id)
        {
            List<OrderViewModel> result = context.Orders
                .Where(rec => rec.Client.Id == id)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    DateOfCreate = SqlFunctions.DateName("dd", rec.DateOfCreate) + " " +
                                SqlFunctions.DateName("mm", rec.DateOfCreate) + " " +
                                SqlFunctions.DateName("yyyy", rec.DateOfCreate),
                    Km = rec.Km,
                    Summa = rec.Summa,
                    ClientFIO = rec.Client.ClientFIO,
                    AutoName = rec.Auto.Name
                  
                })
                .ToList();
            return result;
        }

        public List<OrderViewModel> GetList()
        {
            List<OrderViewModel> result = context.Orders
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    DateOfCreate = SqlFunctions.DateName("dd", rec.DateOfCreate) + " " +
                                SqlFunctions.DateName("mm", rec.DateOfCreate) + " " +
                                SqlFunctions.DateName("yyyy", rec.DateOfCreate),
                    Km = rec.Km,
                    Summa = rec.Summa,
                    ClientFIO = rec.Client.ClientFIO,
                    AutoName = rec.Auto.Name
                })
                .ToList();
            return result;
        }

        public void CreateOrder(OrderBindingModel model)
        {
            context.Orders.Add(new Order
            {
                ClientId = model.ClientId,
                DateOfCreate = DateTime.Now,
                Km = model.Km,
                Summa = model.Summa,
               
            });
            context.SaveChanges();
        }

        public void PayOrder(OrderBindingModel model)
        {
            try
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                element.Summa = model.Summa;
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
       

        public void UpdateOrder(OrderBindingModel model)
        {
            try
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                element.Summa = model.Summa;
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

   
