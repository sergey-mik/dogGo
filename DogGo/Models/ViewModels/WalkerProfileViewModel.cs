﻿using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
	public class WalkerProfileViewModel
	{
		public Walker Walker { get; set; }
		public List<Walk> Walk { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}