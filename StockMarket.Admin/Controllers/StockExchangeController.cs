using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Admin.Entities;
using StockMarket.Admin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockExchangeController : ControllerBase
    {
        private readonly StockExchangeRepository repository=new StockExchangeRepository();
        [HttpPost]
        [Route("AddStockExchange")]
        public IActionResult AddStockExchange(StockExchange a)
        {
            try
            {
                repository.AddStockExchange(a);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteStockExchangeById/{id}")]
        public IActionResult DeleteStockExchange(int id)
        {
            try
            {
                repository.DeleteStockExchange(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStockExchanges")]
        public IActionResult GetStockExchanges()
        {
            try
            {
                List<StockExchange> items = repository.GetStockExchanges();
                return Ok(items);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStockExchange/{id}")]
        public IActionResult GetStockExchange(int id) //Get item using id
        {
            try
            {
                StockExchange item = repository.GetStockExchange(id);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("EditStockExchange")]
        public IActionResult EditStockExchange(StockExchange item) //Update Item
        {
            try
            {
                repository.UpdateStockExchange(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
