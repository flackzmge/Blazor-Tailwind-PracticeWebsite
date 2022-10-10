using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;


namespace SuperHeroDB.Shared
{
	public class OrderDetailsModel
	{
		public string Description { get; set; } = string.Empty;
		public decimal Offer { get; set; }
	}

}
