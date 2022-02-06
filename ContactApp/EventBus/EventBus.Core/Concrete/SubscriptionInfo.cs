namespace EventBus.Core.Concrete;

/// <summary>
/// Olay katılım bilgisi
/// </summary>
public class SubscriptionInfo
{
    /// <summary>
    /// Dinamik katılım mı?
    /// </summary>
    public bool IsDynamic { get; }

    /// <summary>
    /// Handler tipi
    /// </summary>
    public Type HandlerType { get; }

    private SubscriptionInfo(bool isDynamic, Type handlerType)
    {
        IsDynamic = isDynamic;
        HandlerType = handlerType;
    }

    public static SubscriptionInfo Dynamic(Type handlerType) =>
        new SubscriptionInfo(true, handlerType);

    public static SubscriptionInfo Typed(Type handlerType) =>
        new SubscriptionInfo(false, handlerType);
}
