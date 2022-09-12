using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmetsyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderTrackingController : ControllerBase
    {
        private readonly IOrderTrackingManager _orderTrackingManager;

        public OrderTrackingController(IOrderTrackingManager orderTrackingManager)
        {
            _orderTrackingManager = orderTrackingManager;
        }

        [HttpPost("addOrderTracking")]
        public IActionResult AddOrderTracking(OrderTracking orderTracking)
        {
            _orderTrackingManager.Add(orderTracking);
            return Ok(new { status = 200, message = "Elave olundu" });
        }

        [HttpGet("getallordertracking")]
        public async Task<IActionResult> GetAll()
        {
            var order = _orderTrackingManager.GetAll();
            return Ok(new { status = 200, message = order });
        }
    }
}
