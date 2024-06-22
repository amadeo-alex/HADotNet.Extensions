using HADotNet.Core.Models;
using HADotNet.Extension.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADotNet.Extension.Contracts
{
	public interface ILight : IEntity, IOnAbility, IOffAbility, IToggleAbility
	{
		public const string DOMAIN = "light";
	}
}
