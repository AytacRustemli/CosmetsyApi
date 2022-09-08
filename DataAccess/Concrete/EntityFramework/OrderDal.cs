using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class OrderDal : EfEntityRepositoryBase<Order, CosmetsyDbContext>, IOrderDal
    {
        public List<OrderDTO> GetAllOrders()
        {
            using var context = new CosmetsyDbContext();

            var orders = context.Orders.Include(x => x.Product).ToList();

            List<OrderDTO> result = new();

            foreach (var order in orders)
            {
                OrderDTO orderDTO = new()
                {
                    Id = order.Id,
                    IsDelivered = order.IsDelivered,
                    UserId = order.UserId,
                    ProductId = order.ProductId,
                    TotalPrice = order.TotalPrice,
                    TotalQuantity = order.TotalQuantity,
                };
                result.Add(orderDTO);
            }

            return result;

        }
        public List<OrderDTO> GetUserOrders(int userId)
        {
            using var context = new CosmetsyDbContext();
            var orderList = context.Orders.Include(X => X.Product).Where(x => x.UserId == userId).ToList();

            List<OrderDTO> list = new();

            foreach (var order in orderList)
            {
                OrderDTO orderDTO = new()
                {
                    UserId = userId,
                    Id = order.Id,
                    ProductId = order.ProductId,
                    IsDelivered = order.IsDelivered,
                    TotalPrice = order.TotalPrice,
                    TotalQuantity = order.TotalQuantity
                };
                list.Add(orderDTO);
            }
            return list;

        }
    }
}
