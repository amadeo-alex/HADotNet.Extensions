using HADotNet.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADotNet.Extension.Contracts.Services
{
	public interface IToggleAbility
	{
		public const string SERVICE_TOGGLE = "toggle";

		Task<List<StateObject>> Toggle();
	}
}
