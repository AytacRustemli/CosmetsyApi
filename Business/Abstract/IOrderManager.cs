using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IOrderManager
    {
        void Add(Order order);
        void Remove(Order order);
        void Update(Order order);
        List<OrderDTO> GetAll(int userId);
        List<OrderDTO> GetAllOrders();
    }
}
