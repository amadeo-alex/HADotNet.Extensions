using HADotNet.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADotNet.Extension.Contracts;
public interface IEntity
{
	public string Id { get; }
	public string Domain { get; }
	public string FriendlyName { get; }
	public string State { get; }
	public IDictionary<string, object> Attributes { get; }


	public Task<List<StateObject>> CallServiceAsync(string domain, string service, IDictionary<string, object>? fields);
}
