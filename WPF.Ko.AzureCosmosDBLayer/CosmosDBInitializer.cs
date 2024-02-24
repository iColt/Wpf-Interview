using System.CommandLine;
using WPF.Ko.AzureCosmosDBLayer.Helpers;

namespace WPF.Ko.AzureCosmosDBLayer;

public class CosmosDBInitializer
{
    public async Task CreateEntryAsync(string[] args)
    {
        var command = new RootCommand();

        var nameOption = new Option<string>("--name") { IsRequired = true };
        var emailOption = new Option<string>("--email");
        var stateOption = new Option<string>("--state") { IsRequired = true };
        var countryOption = new Option<string>("--country") { IsRequired = true };

        command.AddOption(nameOption);
        command.AddOption(emailOption);
        command.AddOption(stateOption);
        command.AddOption(countryOption);

        command.SetHandler(
            handle: CosmosHandler.ManageCustomerAsync,
            nameOption,
            emailOption,
            stateOption,
            countryOption
        );

        await command.InvokeAsync(args);
    }
}
