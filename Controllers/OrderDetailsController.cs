﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Data;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailsController : Controller
    {
        private readonly PortalDbContext _portalDbContext;

        public OrderDetailsController(PortalDbContext portalDbContext)
        {
            _portalDbContext = portalDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _portalDbContext.OrderDetails.ToListAsync();
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrders( [FromBody] OrderDetails orderReq)
        {
           orderReq.Id = Guid.NewGuid();
           await _portalDbContext.OrderDetails.AddAsync(orderReq);   
           await _portalDbContext.SaveChangesAsync();
           return Ok(orderReq);
        }
    }
}
