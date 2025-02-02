﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister.WPF.Models
{
	public class InvoiceItemVM
	{
		public int? Id { get; set; }
		public int InvoiceId { get; set; }
		public string Name { get; set; }
		public int Amount { get; set; }
		public decimal Price { get; set; }
		public int VAT { get; set; }
		public decimal PriceGross { get; set; }
		public decimal ValueNet { get; set; }
		public decimal ValueVAT { get; set; }
	}
}
