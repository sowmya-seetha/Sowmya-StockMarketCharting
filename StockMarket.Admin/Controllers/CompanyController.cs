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
    public class CompanyController : ControllerBase
    {
        private readonly CompanyRepository repository = new CompanyRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllCompany() //Get the All item
        {
            try
            {
                List<Company> items = repository.GetAllCompany();
                return Ok(items);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetItem/{name}")]
        public IActionResult Get(string name) //Get item using id
        {
            try
            {
                Company item = repository.GetCompanyByName(name);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteItem/{id}")]
        public IActionResult DeleteCompany(string id) //Delete Item using id
        {
            try
            {
                repository.DeleteCompany(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company item) //Add item
        {
            try
            {
                repository.AddCompany(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("EditItem")]
        public IActionResult EditItem(Company item) //Update Item
        {
            try
            {
                repository.UpdateCompany(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
