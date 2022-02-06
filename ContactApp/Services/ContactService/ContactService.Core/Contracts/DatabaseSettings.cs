using ContactService.Core.Abstract;

namespace ContactService.Core.Contracts;

public class DatabaseSettings : IDatabaseSettings
{
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
}
