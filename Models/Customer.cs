using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Customer
    {
        public int ObjId { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
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
        public int? PricingGroupOid { get; set; }
        public byte? ExcludeFromAllowances { get; set; }
        public int? TaxJurisdictionOid { get; set; }
        public int? PaymentTermOid { get; set; }
        public int? SalesRepOid { get; set; }
        public byte? AcceptsSubstitutions { get; set; }
        public string PhoneNumber { get; set; }
        public decimal? CreditLimit { get; set; }
        public byte? ExcludeFromLateFees { get; set; }
        public string StatemntCode { get; set; }
        public byte NumberOfInvoices { get; set; }
        public byte? PrintWeCard { get; set; }
        public string TobaccoLicenseNum { get; set; }
        public string ResaleNum { get; set; }
        public byte? UseCustomerItemPricing { get; set; }
        public DateTime? TobaccoLicenseExpirationDate { get; set; }
        public byte? CustomerStatus { get; set; }
        public string CigaretteLicenseNum { get; set; }
        public byte UseEdi { get; set; }
        public string Ediemail { get; set; }
        public byte NotAuth { get; set; }
    }
}
