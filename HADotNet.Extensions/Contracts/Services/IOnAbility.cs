﻿using HADotNet.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADotNet.Extension.Contracts.Services
{
	public interface IOnAbility
	{
		public const string SERVICE_ON = "turn_on";

		Task<List<StateObject>> TurnOn();
	}
}
