namespace ShoppingListApp;

public static class Extensions
{
    public static T ToEnumValue<T>(this string value) where T : Enum =>
        (T)Enum.Parse(typeof(T), value);
}