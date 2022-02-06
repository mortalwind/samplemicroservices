namespace EventBus.Core.Extensions;

public static class HandlerTypeExtensions
{
    public static string GetHandlerTypeName(this Type type)
    {
        var typeName = string.Empty;

        if (type.IsGenericType)
        {
            var genericTypes = string.Join(",", type.GetGenericArguments().Select(t => t.Name).ToArray());
            typeName = $"{type.Name.Remove(type.Name.IndexOf('`'))}<{genericTypes}>";
        }
        else
        {
            typeName = type.Name;
        }

        return typeName;
    }

    public static string GetHandlerTypeName(this object @object)
    {
        return @object.GetType().GetHandlerTypeName();
    }
}
