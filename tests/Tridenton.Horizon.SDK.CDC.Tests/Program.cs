using Tridenton.Core.Utilities;
using Tridenton.Horizon.SDK.CDC.Models;
using Tridenton.Horizon.SDK.CDC.Models.DataConnectors;

var dataConnectorSettings = new DataConnectorSettings()
{
    Connector = DataConnector.PostgreSQL,
    Settings = new PostgreSQLSettings()
    {
        Url = "localhost",
        Username = "postgres",
        Password = "postgres",
        Database = "postgres",
    },
};

var json = Serializer.ToJson(dataConnectorSettings);

Console.WriteLine(json);

dataConnectorSettings =  Serializer.FromJson<DataConnectorSettings>(json);

Console.WriteLine(dataConnectorSettings);