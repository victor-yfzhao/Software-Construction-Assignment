using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("order/")]
    public class OrderApiController : ControllerBase
    {
        private readonly OrderDbContext orderDb;

        public OrderApiController(OrderDbContext context)
        {
            orderDb = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetOrders()
        {
            var orders = await orderDb.Orders
                .Select(
                    order => new OrderModel
                    {
                        OrderId = order.OrderId,
                        CreatedDate = order.CreatedDate,
                        CustomerName = order.CustomerName
                    }
                )
                .ToListAsync();

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderModel>> GetOrder(int id)
        {
            var order = await orderDb.Orders
                .Where(order => order.OrderId == id)
                .Include(order => order.OrderDetails)
                .FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                order.OrderId,
                order.CreatedDate,
                order.CustomerName,
                OrderDetails = order.OrderDetails.Select(
                    detail => new
                    {
                        detail.DetailId,
                        detail.ItemName,
                        detail.ItemValue,
                        detail.ItemQuantity
                    }
                )
            });
        }

        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(OrderModel order)
        {
            orderDb.Orders.Add(order);
            await orderDb.SaveChangesAsync();
            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, OrderModel order)
        {
            if (id != order.OrderId)
            {
                return BadRequest("Not the SAME order");
            }
            orderDb.Entry(order).State = EntityState.Modified;
            await orderDb.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await orderDb.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            orderDb.Orders.Remove(order);
            await orderDb.SaveChangesAsync();
            return NoContent();
        }
    }
}
