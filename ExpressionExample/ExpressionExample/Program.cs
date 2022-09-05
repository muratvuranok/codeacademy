using System.Linq.Expressions;

public class MyCustomClass
{
    public string Text { get; set; }
    public int Number { get; set; }
}





class Program
{

    public static void Main()
    {

        var selectedProperty = "number";
        var exampleClass = new MyCustomClass
        {
            Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since 2022",
            Number = 10
        }; var exampleClass2 = new MyCustomClass
        {
            Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since 2022",
            Number = 10
        }; var exampleClass3 = new MyCustomClass
        {
            Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since 2022",
            Number = 10
        };

        //if (selectedProperty == "text")
        //{
        //    Console.WriteLine(exampleClass.Text);
        //}
        //else if (selectedProperty == "number")
        //{
        //    Console.WriteLine(exampleClass.Number);
        //}




        var d = new MyCustomClass().GetType().GetProperty(selectedProperty);
        //var accessor = Expression.PropertyOrField(parameters, selectedProperty);

        var parameters = Expression.Parameter(typeof(MyCustomClass));
        var accessor = Expression.PropertyOrField(parameters, selectedProperty);
        var lambda = Expression.Lambda(accessor, parameters);
        var result = lambda.Compile().DynamicInvoke(exampleClass);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}