using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SalesOrder
    {
        public int ObjId { get; set; }
        public byte OrderSource { get; set; }
        public byte OrderType { get; set; }
        public int CustomerOid { get; set; }
        public byte Status { get; set; }
        public int? ShiftOid { get; set; }
        public int? ShiftTransNum { get; set; }
        public int? ReferencedOrderOid { get; set; }
        public string CustomerPonumber { get; set; }
        public string BillToAttention { get; set; }
        public string BillToAddressLine1 { get; set; }
        public string BillToAddressLine2 { get; set; }
        public string BillToCity { get; set; }
        public int? BillToStateOid { get; set; }
        public string BillToZipCode { get; set; }
        public string ShipToAttention { get; set; }
        public string ShipToAddressLine1 { get; set; }
        public string ShipToAddressLine2 { get; set; }
        public string ShipToCity { get; set; }
        public int? ShipToStateOid { get; set; }
        public string ShipToZipCode { get; set; }
        public int? TaxJurisdictionOid { get; set; }
        public int? PricingGroupOid { get; set; }
        public int? PaymentTermOid { get; set; }
        public int? SalesRepOid { get; set; }
        public byte? ExcludeFromAllowances { get; set; }
        public byte? AcceptsSubstitutions { get; set; }
        public int? DefaultCreditReasonOid { get; set; }
        public int? DeliveryRouteOid { get; set; }
        public int? DeliveryRouteStopNumber { get; set; }
        public int? DefaultTaxStampOid { get; set; }
        public DateTime? OrderedDate { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? PickedDate { get; set; }
        public DateTime? AdjustedDate { get; set; }
        public DateTime? InvoicedDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime? LastPricedDate { get; set; }
        public int? NumberOfTotes { get; set; }
        public int? NumberOfPackages { get; set; }
        public string PickedBy { get; set; }
        public int? TotalLines { get; set; }
        public int? TotalQuantity { get; set; }
        public int? TotalOrderedQuantity { get; set; }
        public int? TotalPickedQuantity { get; set; }
        public int? CigaretteQuantity { get; set; }
        public int? OtherQuantity { get; set; }
        public decimal? TotalActualCost { get; set; }
        public decimal? TotalNetCost { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalPriceChanges { get; set; }
        public decimal? TotalSalesTax { get; set; }
        public decimal? TotalCharges { get; set; }
        public decimal? TotalRebates { get; set; }
        public decimal? TotalOrder { get; set; }
        public byte? TenderType { get; set; }
        public decimal? TenderAmount { get; set; }
        public string TenderCheckNum { get; set; }
        public decimal? ChangeAmount { get; set; }
        public int? ManualInvoiceNumber { get; set; }
        public DateTime? Edidate { get; set; }
    }
}
