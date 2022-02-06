using System.Text.Json.Serialization;

namespace EventBus.Core.Events;

/// <summary>
/// RabbitMq, Kafka vb entegrasyonlar için event modeli
/// </summary>
public class IntegrationEvent
{

    [JsonInclude]
    public Guid Id { get; internal set; }

    [JsonInclude]
    public DateTime DateCreated { get; internal set; }

    public IntegrationEvent()
    {
        Id = Guid.NewGuid();
        DateCreated = DateTime.Now;
    }

    public IntegrationEvent(Guid id)
    {
        Id = id;
        DateCreated = DateTime.Now;
    }
    [JsonConstructor]
    public IntegrationEvent(Guid id, DateTime dateCreated)
    {
        Id = id;
        DateCreated = dateCreated;
    }
}
