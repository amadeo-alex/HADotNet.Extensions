using HADotNet.Core.Clients;
using HADotNet.Core.Models;
using HADotNet.Extension.Contracts;

namespace HADotNet.Extension;

public class Entity : IEntity
{
	protected readonly ServiceClient _serviceClient;
	protected readonly StateObject _stateObject;

	public const string ATTRIBUTE_FRIENDLY_NAME = "friendly_name";
	public const string ATTRIBUTE_ENTITY_ID = "entity_id";

	public string Id => _stateObject.EntityId;
	public string Domain => _stateObject.EntityId.Split('.').FirstOrDefault() ?? string.Empty;
	public string FriendlyName => _stateObject.GetAttributeValue<string>(ATTRIBUTE_FRIENDLY_NAME);
	public string State => _stateObject.State;

	public IDictionary<string, object> Attributes => _stateObject.Attributes;

	public Entity(ServiceClient serviceClient, StateObject stateObject)
	{
		_serviceClient = serviceClient;
		_stateObject = stateObject;
	}

	public async Task<List<StateObject>> CallServiceAsync(string domain, string service, IDictionary<string, object>? fields)
	{
		if(fields == null)
		{ 
			fields = new Dictionary<string, object>()
			{
				[ATTRIBUTE_ENTITY_ID] = Id
			};
		}

		var result = await _serviceClient.CallService(domain, service, fields);

		return result;
	}
}
