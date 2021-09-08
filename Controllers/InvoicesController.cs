using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ngSupplyLogic.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ngSupplyLogic.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class InvoicesController : ControllerBase
  {
    private readonly ShakespeareContext _context;

    public InvoicesController(ShakespeareContext context)
    {
      _context = context;
    }

    // GET: api/Customers
    [HttpGet("unposted")]

    public List<UnPostedInvoiceResult> GetInvoices()
    {
      return _context.GetUnPostedOrders();
    }

    [HttpGet("draft")]
    public List<DraftOrdersResult> GetDraftInvoices()
    {
      return _context.GetDraftOrders();
    }

    [HttpGet("date/{selectedDate}")]

    public List<UnPostedInvoiceResult> GetSpecificInvoices(string selectedDate)
    {
      // in this fucntion, we are recieving an ISO string formatted date.
      // we should be able to simple parse the date string into the actuall
      // DateTime object
      return _context.GetOrdersForDate(DateTime.Parse(selectedDate));
    }

    [HttpGet("{invoiceNumber}")]

    public List<InvoiceReportLine> GetInvoiceByInvoiceNumber(int invoiceNumber)
    {
      return _context.GetInvoiceDetails(invoiceNumber);
    }

    [HttpGet("byCustomer/{customerNumber}")]

    public List<UnPostedInvoiceResult> GetInvoiceByCustomerNumber(int customerNumber)
    {
      Debug.WriteLine(customerNumber);
      return _context.GetInvoicesByCustomer(customerNumber);
    }

    [HttpGet("marl/{customerNum}")]

    public int GetMonthlyMarlboroSales(int customerNum)
    {
      Console.WriteLine("Getting invoices for customer #: " + customerNum);
      return _context.GetSalesOrdersForCurrentMonth(customerNum);
    }

    [HttpGet("marl/{customerNum}/{monthNum}")]

    public int GetSelectedMonthMarlboroSales(int customerNum, int monthNum)
    {
      Console.WriteLine("Getting invoices for customer #: " + customerNum);
      return _context.GetSalesOrdersForSelectedMonth(customerNum, monthNum);
    }
  }
}
