﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Models.API.Requests
{
	internal class GetCookiesInfo
	{
		[JsonProperty("domain")]
		public string Domain { get; set; }
	}
}
