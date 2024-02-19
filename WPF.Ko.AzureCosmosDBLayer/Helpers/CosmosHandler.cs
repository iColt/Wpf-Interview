using Humanizer;
using Microsoft.Azure.Cosmos;

namespace WPF.Ko.AzureCosmosDBLayer.Helpers;

public static class CosmosHandler
{
    private static readonly CosmosClient _client;

    static CosmosHandler()
    {
        //TODO: read from file
        _client = new CosmosClient(
           accountEndpoint: "<uri>",
           authKeyOrResourceToken: "<primary-key>"
       );
    }

    private static async Task<Container> GetContainer()
    {
        //TODO: read DB name from file
        Database database = _client.GetDatabase("DB-NAME");
        List<string> keyPaths = new()
        {
            "/address/country",
            "/address/state"
        };
        ContainerProperties properties = new(
            id: "customers",
            partitionKeyPaths: keyPaths
        );

        return await database.CreateContainerIfNotExistsAsync(
            containerProperties: properties
        );
    }

    public static async Task ManageCustomerAsync(string name, string email, string state, string country)
    {
        //TODO: write to output
        //await Console.Out.WriteLineAsync($"Hello {name} of {state}, {country}!");
    }
}
