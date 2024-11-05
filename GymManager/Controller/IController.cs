using GymManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Controller
{
    internal interface IController
    {
        List<IModel> models { get; }
        bool GetAllItem();
        bool GetOneItem(Object id);
        bool CreateItem(IModel model);
        bool UpdateItem(IModel model);
        bool DeleteItem(Object id);
        bool ItemExist(Object id);
    }
}
