using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ngSupplyLogic.Models;
using Newtonsoft.Json;
using System.IO;

namespace ngSupplyLogic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ShakespeareContext _context;

        public CustomersController(ShakespeareContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public List<CustomerRouteCustomer> GetCustomer()
        {
            //SaveCustomerDataToJSON();
            return _context.GetAllCustomers();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public List<CustomerRouteCustomer> GetCustomer(int id)
        {
            var customer = _context.GetGetSalesRepCustomers(id);
            if (customer == null)
            {
                return null;
            }
            return customer;
        }

        // GET: api/customers/totals/{custNum}
        [HttpGet("totals/{custOID}")]
        public Decimal? GetCustomerTotal(int custOID)
        {
            return _context.GetCustomerAccountTotal(custOID);
        }

        // GET: api/customers/reps
        [HttpGet("reps")]
        public List<SalesRep> GetSalesReps()
        {
            return _context.GetAllSalesReps();
        }

        //public void SaveCustomerDataToJSON()
        //{
        //    var customers = _context.GetAllCustomers().ToList();

        //    string json = JsonConvert.SerializeObject(customers);
        //    string fileName = "customerData.json";
        //    var FilePath = Path.Combine("DataStorage", fileName);

        //    //write string to file
        //    System.IO.File.WriteAllText(FilePath, json);
        //}
    }
}
