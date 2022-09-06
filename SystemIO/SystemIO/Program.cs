using System.Text;

var user = new string[]
{
    "murat vuranok",
    "murat.vuranok@hotmail.com",
    "+9012345698574"
};

// 1. Örnek
string examplePath1 = @"C:\Users\murat\OneDrive\Desktop\CodeAcademyRepository\example1.txt";
await File.WriteAllLinesAsync(examplePath1, user);

foreach (var line in File.ReadAllLines(examplePath1)
    .Select((value, index) => new { value, index }))
{
    //Console.WriteLine($"{line.index + 1} -> {line.value}");
    // 1 -> murat vuranok
    // 2 -> murat.vuranok@hotmail.com
    // 3 -> +9012345698574
}


// 2. Örnek
string examplePath2 = @"C:\Users\murat\OneDrive\Desktop\CodeAcademyRepository";

DirectoryInfo info = new DirectoryInfo(examplePath2);

FileInfo[] txtFiles = info.GetFiles("*.txt", SearchOption.AllDirectories);

foreach (var item in txtFiles)
{
    //Console.WriteLine(item.Name);
    //Console.WriteLine(item.Length);
    //Console.WriteLine(item.DirectoryName);
}




// Örnek 3
string examplePath3 = @"C:\Users\murat\OneDrive\Desktop\CodeAcademyRepository\example3.txt";
FileStream fs = File.Open(examplePath3, FileMode.Create);
string loremIpsum = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";


byte[] rsByteArray = Encoding.Default.GetBytes(loremIpsum);
fs.Write(rsByteArray, 0, rsByteArray.Length);
fs.Position = 0;
byte[] data = new byte[rsByteArray.Length];
for (int i = 0; i < rsByteArray.Length; i++)
{
    data[i] = (byte)fs.ReadByte();
}
//Console.WriteLine(Encoding.Default.GetString(data));


// Örnek 4 
string examplePath4 = @"C:\Users\murat\OneDrive\Desktop\CodeAcademyRepository\example4.txt";

StreamWriter sw = File.CreateText(examplePath4);
sw.WriteLine("Lorem Ipsum is simply dummy text of the printing and typesetting industry.");
sw.WriteLine("It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.");
sw.WriteLine("It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages");
sw.WriteLine("PageMaker including versions of Lorem Ipsum");
sw.Close();

StreamReader sr = File.OpenText(examplePath4);
Console.Clear();
//Console.WriteLine("Peek : {0} ", Convert.ToChar(sr.Peek())); // Dosya içerisindeki 1. karakter
//Console.WriteLine("1. Eleman {0} ", sr.ReadLine());          // Dosya içerisindeki 1. Satır
//Console.WriteLine("Tüm Elemanlar {0} ", sr.ReadToEnd());     // Dosya içerisindeki tüm satırlar



// Örnek 5
string examplePath5 = @"C:\Users\murat\OneDrive\Desktop\CodeAcademyRepository\example5.txt";

FileInfo dataFile = new FileInfo(examplePath5);
BinaryWriter bw = new BinaryWriter(dataFile.OpenWrite());

string randomText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
int age = 99;
double heiht = 100.0;


bw.Write(randomText);
bw.Write(age);
bw.Write(heiht);

bw.Close();


BinaryReader br = new BinaryReader(dataFile.OpenRead());
 
Console.WriteLine(br.Read());
//Console.WriteLine(br.ReadString());
//Console.WriteLine(br.ReadInt32());
//Console.WriteLine(br.ReadDouble());
br.Close();