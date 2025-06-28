using Tridenton.Core.Utilities;
using Tridenton.Horizon.SDK.CDC.Models;
using Tridenton.Horizon.SDK.CDC.Models.DataConnectors;
using Tridenton.Horizon.SDK.CDC.Models.OutputChannels;

var dataConnectorSettings = new DataConnectorSettings
{
    Connector = DataConnector.PostgreSQL,
    Settings = new PostgreSQLSettings
    {
        Url = "localhost",
        Username = "postgres",
        Password = "postgres",
        Database = "postgres",
    },
};

var json = Serializer.ToJson(dataConnectorSettings);

Console.WriteLine(json);

dataConnectorSettings = Serializer.FromJson<DataConnectorSettings>(json);

Console.WriteLine(dataConnectorSettings);

var outputChannelSettings = new OutputChannelSettings
{
    Channel  = OutputChannel.Webhooks,
    Settings = new WebhookSettings
    {
        HttpMethod = WebhookHttpMethod.Post,
        Url = "localhost",
    },
};

json = Serializer.ToJson(outputChannelSettings);

Console.WriteLine(json);

outputChannelSettings = Serializer.FromJson<OutputChannelSettings>(json);

Console.WriteLine(dataConnectorSettings);