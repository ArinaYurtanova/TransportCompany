using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompanyService.BindingModel;
using TransportCompanyService.ViewModel;

namespace TransportCompanyService.Interfaces
{
    public interface IAuto
    {
        List<AutoViewModel> GetList();

        AutoViewModel GetElement(int id);

        void AddElement(AutoBindingModel model);

        void UpdElement(AutoBindingModel model);

        void DelElement(int id);
    }
}
