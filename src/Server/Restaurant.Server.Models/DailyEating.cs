﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Server.Models
{
	[Table("DailyEatings")]
	public class DailyEating : BaseEntity
	{
		public DateTime DateTime { get; set; }

		public decimal AdditionalAmount { get; set; }

		public decimal Amount { get; set; }

		public string Decsription { get; set; }

		public string Reciept { get; set; }
        
		[NotMapped]
		public virtual decimal TotalAmount => AdditionalAmount + Amount;
	}
}