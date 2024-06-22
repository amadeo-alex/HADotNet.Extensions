using HADotNet.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADotNet.Extension.Contracts.Services
{
	public interface IOffAbility
	{
		public const string SERVICE_OFF = "turn_off";

		Task<List<StateObject>> TurnOff();
	}
}
