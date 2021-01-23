using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ngSupplyLogic.Models;

namespace ngSupplyLogic.Controllers
{
    public class TransactionController : ControllerBase
    {
        private readonly ShakespeareContext _context;
        public TransactionController(ShakespeareContext context)
        {
            _context = context;
        }

        // GET: api/transactions
        [HttpGet("transactions/{type}")]
        public List<ArResult> GetTransactionsByType(int type)
        {
            return _context.GetTransactionType(type);
        }

        [HttpGet("transactions/date/{date}")]
        public List<ArResult> GetTransactionsByDate(DateTime date)
        {
            return _context.GetTransactionsByDate(date);
        }
    }
}
