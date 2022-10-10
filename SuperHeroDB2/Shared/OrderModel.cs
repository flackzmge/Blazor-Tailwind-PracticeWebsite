using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;




namespace SuperHeroDB.Shared
{
	public class OrderModel
	{
		
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string CCNumber { get; set; } = "4012 8888 8888 1881";
		public AddressModel Address { get; set; } = new AddressModel();
		public List<OrderDetailsModel> OrderDetails = new List<OrderDetailsModel>()
		{
			new OrderDetailsModel()
				{
					Description = "Perform Work order 1",
					Offer = 100
				},
			new OrderDetailsModel()
		};
	}

    
    }
