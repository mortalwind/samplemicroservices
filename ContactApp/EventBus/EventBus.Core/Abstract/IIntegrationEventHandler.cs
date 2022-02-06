using EventBus.Core.Events;

namespace EventBus.Core.Abstract;

public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
where TIntegrationEvent : IntegrationEvent
{
    Task Handle(TIntegrationEvent inEvent);
}

public interface IIntegrationEventHandler
{
}
