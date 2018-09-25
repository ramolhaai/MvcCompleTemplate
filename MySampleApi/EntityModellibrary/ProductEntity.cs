using System;

namespace EntityModellibrary
{
    public class ProductEntity
    {
        public int RecordID { get; set; }
        public string MarketID { get; set; }
        public string CountryCode { get; set; }
        public string RoleName { get; set; }
        public string CompanyType { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Location { get; set; }
        public string Location1 { get; set; }
    }
}
