using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public class CustomerRouteCustomer
    {
        public int Num { get; set; }
        public int ID { get; set; }
        public int OID { get; set; }
        public string Name { get; set; }
        public List<PhoneNumber> PhoneNumber { get; set; }
        public List<CustomerNote> Notes { get; set; }
        public string City { get; set; }
        public string RepFirstName { get; set; }
        public string RepLastName { get; set; }
        public string Status { get; set; }
        public enum StatusList
        {
            Yes,
            No,
            Cb,
            Na,
            Inactive,
            Blank
        };

        public CustomerRouteCustomer()
        {
            this.Status = "";
        }
    }
}