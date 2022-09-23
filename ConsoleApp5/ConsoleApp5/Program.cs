using System.Text;

string[] user =
{
    "Murat Vuranok",
    "murat.vuranok@hotmail.com",
    "+90123525478"
};


string path = @"C:\Users\murat\OneDrive\Desktop\result.txt";

await File.WriteAllLinesAsync(path, user);

foreach (var item in File.ReadAllLines(path))
{
    Console.WriteLine(item);
}


DirectoryInfo info = new DirectoryInfo(@"C:\Users\murat\OneDrive\Desktop");

FileInfo[] txtFiles = info.GetFiles("*.txt", SearchOption.AllDirectories);
foreach (FileInfo file in txtFiles)
{
    Console.WriteLine(file.Name);
}



string path2 = @"C:\Users\murat\OneDrive\Desktop\denemelerim.txt";

FileStream fs = File.Open(path2, FileMode.Create);
string randStr = "Random String Text Value";
byte[] rsByteArray = Encoding.Default.GetBytes(randStr);
fs.Write(rsByteArray, 0, rsByteArray.Length);
fs.Position = 0;
byte[] data = new byte[rsByteArray.Length];
for (int i = 0; i < rsByteArray.Length; i++)
{
    data[i] = (byte)fs.ReadByte();
}

Console.WriteLine(Encoding.Default.GetString(data));





string txtFilPath3 = @"C:\Users\murat\OneDrive\Desktop\denemelerim3.txt";

StreamWriter sw = File.CreateText(txtFilPath3);
sw.Write("Random string value");
sw.WriteLine("text line");
sw.WriteLine("text line 1");

sw.Close();

StreamReader sr = File.OpenText(txtFilPath3);

Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
Console.WriteLine("1. Eleman : {0}", sr.ReadLine());
Console.WriteLine("Tüm Elemanlar : {0}", sr.ReadToEnd());



string txtFilPath4 = @"C:\Users\murat\OneDrive\Desktop\denemelerim4.txt";

FileInfo datFile = new FileInfo(txtFilPath4);
BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

string randText = "Lorem ipsum sample text";
int age = 33;
double height = 6.25;

bw.Write(randText);
bw.Write(age);
bw.Write(height);
bw.Close();



BinaryReader br = new BinaryReader(datFile.OpenRead());
Console.WriteLine(br.ReadString());
Console.WriteLine(br.ReadInt32());
Console.WriteLine(br.ReadDouble());
br.Close();