using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderTrackingManager : IOrderTrackingManager
    {
        private readonly IOrderTrackingDal _orderTrackingDal;

        public OrderTrackingManager(IOrderTrackingDal orderTrackingDal)
        {
            _orderTrackingDal = orderTrackingDal;
        }

        public void Add(OrderTracking orderTracking)
        {
            _orderTrackingDal.Add(orderTracking);
        }

        public List<OrderTracking> GetAll()
        {
            return _orderTrackingDal.GetAll();
        }

    }
}
