using System.Linq.Expressions;

public delegate void DelegeteVoidV1(string message);
public delegate string DelegateString1(string text);




class Program
{


    public static void DelegateMethodV1(string text) { Console.WriteLine(text); }



    public static string DelegateStringMethodV1(string text) => $"DelegateStringMethodV1 Method -> {text}";
    public static string DelegateStringMethodV2(string text) => $"DelegateStringMethodV2 Method -> {text}";


    public static string FunctionReturnMethod() => "https://contoso.com";


    public static Func<string, bool> CustomControl(string t)
    {
        Console.WriteLine(t);
        return x => x.Length > 10 && x.Length < 20;
    }





    public static void Main()
    {
        var denemeHelper = new DelegeteVoidV1(DelegateMethodV1);
        denemeHelper.Invoke("Parametre Ne ise vermek zorundasınız :)");

        var denememelerim = new DelegateString1(DelegateStringMethodV1);
        denememelerim += DelegateStringMethodV2;
        var result = denememelerim.Invoke("Bu alana'da değer vermen gerekir, istemiyorsan tanımlama :)");


        Console.WriteLine(denememelerim);


        // void Delegate için
        Action action = () => DelegateMethodV1("Bu Alan Çalışacak");
        Action cw = () => Console.WriteLine("Action içerisinde bu alanı çalıştırabilirsiniz");
        cw.Invoke();


        // geriye değer dönecek ise, Func

        Func<string> getDomainName = () => "https://contoso.com";
        Func<string> getMethodDomainName = () => FunctionReturnMethod();

        //Func<int, string, bool, decimal, object> func = () => { }


        List<string> domainNames = new List<string>{

            "Lorem Ipsum is simply dummy",
            "Contrary to popular belief, Lorem Ipsum is not simply random text.",
            "There are many variations of passages of Lorem Ipsum available,",
            "The standard chunk of Lorem Ipsum used since the 1500s",
            "Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text"
        };

        string searchText = "";

        var retVal = domainNames.Where(x => x.Length > 10);
        var ratValV1 = domainNames
            .Where(CustomControl(searchText))
            .Where(x => x.Length == 10)
            .ToList();
        Console.WriteLine("");


        List<int> Numbers = new List<int>
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19
        };
        Predicate<int> predicate = (x) => { return x == 1; };

        //public delegate bool Predicate<in T>(T obj);

        Console.WriteLine(Numbers.Find(predicate));

        var retValNumbers = Numbers.AsQueryable().Where(x => x > 10);





        var s = Numbers.AsQueryable().Where(x => x > 10).ToList();
        var t = Numbers.Where(x => x > 10);
    }
}

// Func / Action


public class DomainHelper
{
    // sadece okunabilir,
    // kendiliğinden static olma özelliği vardır.
    public const string GetDomainName = "https://contoso.com";
}


/*
 
void Main()
{
	var book = new Book();
	book.Name = "Fakirler";
	//Func<Book, object>  expr1 = book => book.Name;
	//expr1.Dump();
	
	Expression<Func<Book, object>> expr = book => book.Name;
	expr.Dump();
}

public class Book{
 public string Name { get; set; }
 public double Price { get; set; }
}


LinqPad -> https://www.linqpad.net/Download.aspx
 */


public interface IRepository
{
    public ICollection<string> GetAll(Func<string, bool> exp);
    public IQueryable<string> GetAll(Expression<Func<string, bool>> exp);
}