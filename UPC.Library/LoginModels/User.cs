﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Library.LoginModels
{
	public class User
	{
		public int Id { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public string Role { get; set; }
	}
}