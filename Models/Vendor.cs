using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Vendor
    {
        public int ObjId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Attention { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int? StateOid { get; set; }
        public string ZipCode { get; set; }
        public string ShipToAttention { get; set; }
        public string ShipToAddressLine1 { get; set; }
        public string ShipToAddressLine2 { get; set; }
        public string ShipToCity { get; set; }
        public int? ShipToStateOid { get; set; }
        public string ShipToZipCode { get; set; }
        public string VendorGroup { get; set; }
        public int? VendorPaymentTermOid { get; set; }
        public string VendorBuyer { get; set; }
        public string FreightTerms { get; set; }
        public string Notes { get; set; }
        public int LeadDays { get; set; }
        public int DeliveryMon { get; set; }
        public int DeliveryTue { get; set; }
        public int DeliveryWed { get; set; }
        public int DeliveryThu { get; set; }
        public int DeliveryFri { get; set; }
        public int DeliverySat { get; set; }
        public int DeliverySun { get; set; }
        public int UpdateFromPo { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string AccountNum { get; set; }
    }
}
