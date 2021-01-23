using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngSupplyLogic.Models
{
  public class InvoiceReportLine
  {
    public int? OrderQty { get; set; }
    public decimal? LineTotal { get; set; }
    public string ItemName { get; set; }
    public int? ItemCatOID { get; set; }
    public string ItemCategory { get; set; }
    public decimal? CostPrice { get; set; }
    public decimal? UnitNetCost { get; set; }
    public decimal? UnitPrice { get; set; }
    public byte? Unit { get; set; }
    public bool isGeneralGoods { get; set; }
    public decimal itemProfit {get; set;}
    public string UnitName { get; set; }
    public decimal? NetCost { get; set; }
  }
}
