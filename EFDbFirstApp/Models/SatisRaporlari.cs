using System;
using System.Collections.Generic;

namespace EFDbFirstApp.Models
{
    public partial class SatisRaporlari
    {
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? Title { get; set; }
        public DateTime? HireDate { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Phone { get; set; }
        public string ProductName { get; set; } = null!;
        public short? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public string CategoryName { get; set; } = null!;
        public decimal Expr1 { get; set; }
        public short Quantity { get; set; }
    }
}
