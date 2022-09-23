﻿using System;
using System.Collections.Generic;

namespace DataTransferToViewAndPartailView.Models
{
    public partial class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}