using HADotNet.Core;
using HADotNet.Core.Clients;
using HADotNet.Extension;

namespace HADotNet.Extenstion.Tests;

[TestClass]
public class LightTest
{
    [TestMethod]
    public async Task TestLightEntity()
    {
        var instance = new Uri(Environment.GetEnvironmentVariable("HADotNet:Tests:Instance"));
        var apiKey = Environment.GetEnvironmentVariable("HADotNet:Tests:ApiKey");

        ClientFactory.Initialize(instance, apiKey);

        var serviceClient = ClientFactory.GetClient<ServiceClient>();
        var statesClient = ClientFactory.GetClient<StatesClient>();

        var lightObject = await statesClient.GetState("light.broom_reading_light");
        var lightEntity = new Light(serviceClient, lightObject);

        await lightEntity.TurnOn();
        await lightEntity.TurnOff();
        await lightEntity.Toggle();
        await lightEntity.Toggle();
    }
}