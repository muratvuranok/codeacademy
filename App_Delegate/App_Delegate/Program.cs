/*
  * DELEGATE
  * Bir olay gerçekleştiğinde birden fazla fonksiyonu çağırmak istediğinizi düşünelim. Örneğin kullanıcı bir düğmeye tıkladığında birden fazla method'un otomatik olarak çağrılmasını istiyorsunuz. Bunun için delagate kullanabilirsiniz. Burada amaç şu. Bir olay olduğunda birden fazla yere bu olayı bildirebilmek. Bu olay ile ilgilenler delegate ile olaydan haberleri olur.
  * 
  * yada
  * 
  * Temsilci olarak adlandirilabilecek bu yapi, projeyi asil ayakta tutan nesneleri yormak yerine, onlarin islerini uzerine alarak gerceklestirmekten sorumlu olan tiptir. Bu sayede uygulamamizin her bir kolu, uzerine dusen gorevi eksiksiz yerine getirerek daha uzun sureli ve performansli uygulamalar ortaya koyma sansina sahip olabiliriz.
  * Unutulmamasi gereken nokta ise, delegeler de aslinda birer class'tır.
  * Delege tanimlamak icin;
  * 1) Oncelikle delege tanımlamasi gerceklestirilir (geri donus tipi unutulmamalidir!)
  * 2) Delege'nin calismasi konusunda sorumlu olabilecegi metotlar yazilir...
  * 3) Delege'de instance alindigi asamada ilgili metot delegeye baglanir ve metot yerine delege'nin Invoke() metodu cagrilir...
  */

namespace Sample;

public static class StringExtensionTest
{
    public static string ToMail(this string text)
    {
        return text.Replace(" ", "");
    }
}

internal class Program
{
    public delegate void DefaultLogManager(string message);
    public delegate void LowLogManager(string message);
    public delegate void HighLogManager(string message);


    public delegate void CustomDelegate(string firstName, string lastName);

    static void GetMail(string firstName, string lastName)
    {
        string mail = $"{firstName}.{lastName}@hotmail.com".ToMail();
        Console.WriteLine(mail);
    }

    static void CreateAccount(string firstName, string soyisim)
    {
        Console.WriteLine($"{firstName} {soyisim} Hesabı Oluşturuldu");
    }

    static void PersonelGirisiYap(string adi, string soyadi)
    {
        Console.WriteLine($"{adi} {soyadi} Şirkete Girişi Yapıldı");
    }
    //static void Main(string[] args)
    //{


    //    CustomDelegate @delegate = new CustomDelegate(GetMail); 
    //    @delegate += CreateAccount;
    //    @delegate += PersonelGirisiYap;
    //    @delegate.Invoke("murat", "vuranok");



    //    SetLogger setLogger = new SetLogger();

    //    SSMLogger sMSLogger = new SSMLogger();
    //    XMLLogger xMLLogger = new XMLLogger();
    //    SQLLogger sQLLogger = new SQLLogger();
    //    MailLogger mailLogger = new MailLogger();
    //    PushNotigicationLogger pushNotigicationLogger = new PushNotigicationLogger();


    //    DefaultLogManager defaultLogManager = new DefaultLogManager(setLogger.SetLog);
    //    defaultLogManager.Invoke("DefaultLogManager -> Error Message");


    //    LowLogManager lowLogManager = new LowLogManager(setLogger.SetLog);
    //    lowLogManager += xMLLogger.SetLog;
    //    lowLogManager += mailLogger.SetLog;
    //    lowLogManager.Invoke("Error Message for Low Errors");

    //    HighLogManager highLogManager = new HighLogManager(setLogger.SetLog);
    //    highLogManager += sMSLogger.SetLog;
    //    highLogManager.Invoke("LowLogManager -> Error Message");
    //} 
    static string ClassifyTemperature(double temp) => temp switch
    {
        < -10.0 => "Too low",
        >= -10.0 and < 0 => "Low",
        >= 0 and < 10.0 => "Acceptable",
        >= 10.0 and < 20.0 => "High",
        >= 20.0 and <= 30 => "Perfect",
        >= 30 => "Too high"
    };
    static void Main(string[] args)
    {




        Console.WriteLine(ClassifyTemperature(13));
        Console.WriteLine(ClassifyTemperature(-100));
        Console.WriteLine(ClassifyTemperature(5.7));

    }
}




//sSMLogger.SetLog("Error Message");
//xMLLogger.SetLog("Error Message");
//sQLLogger.SetLog("Error Message");
//mailLogger.SetLog("Error Message");
//setLogger.SetLog("Error Message");
//pushNotigicationLogger.SetLog("Error Message");