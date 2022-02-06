namespace EventBus.Core.Abstract;

/// <summary>
/// Dinamik olarak olay verilerini yakalar
/// </summary>
public interface IDynamicIntegrationEventHandler
{
    Task Handle(dynamic eventData);
}
