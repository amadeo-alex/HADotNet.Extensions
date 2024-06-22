using HADotNet.Core.Clients;
using HADotNet.Core.Models;
using HADotNet.Extension.Contracts;
using HADotNet.Extension.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADotNet.Extension
{
	public class Light : Entity, ILight
	{
		public Light(ServiceClient serviceClient, StateObject stateObject) : base(serviceClient, stateObject)
		{
		}

		public async Task<List<StateObject>> Toggle()
		{
			return await CallServiceAsync(ILight.DOMAIN, IToggleAbility.SERVICE_TOGGLE, null);
		}

		public async Task<List<StateObject>> TurnOff()
		{
			return await CallServiceAsync(ILight.DOMAIN, IOffAbility.SERVICE_OFF, null);
		}

		public async Task<List<StateObject>> TurnOn()
		{
			return await CallServiceAsync(ILight.DOMAIN, IOnAbility.SERVICE_ON, null);
		}
	}
}
