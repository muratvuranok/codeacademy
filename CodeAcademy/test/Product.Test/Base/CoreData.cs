namespace Product.Test.Base;

public class CoreData
{
    public static IEnumerable<object[]> String256
    {
        get
        {
            yield return new object[] { "" };
            yield return new object[] { " " };
            yield return new object[] { null };
            yield return new object[] { new String('*', 256) };
        }
    }
}
