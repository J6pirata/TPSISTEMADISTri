// See https://aka.ms/new-console-template for more information
using SerializaçãoTP;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");
Voo3 voo3 = new Voo3(); 

voo3.dateTime1 = DateTime.Now;
voo3.Origem = "Venezuela";
voo3.Destino = "Brasil";
voo3.Compania = "Gol";
voo3.Operando = true;

FileStream fs = new FileStream("Voo3.bin", FileMode.Create);
BinaryFormatter bf = new BinaryFormatter();
bf.Serialize(fs, voo3);
fs.Close();
Console.WriteLine("serializado com sucesso");


FileInfo fi = new FileInfo("Voo3.bin");
if (fi.Exists)
{
    FileStream fileclose = new FileStream("Voo3.bin", FileMode.Open);
    BinaryFormatter vooozinho = new BinaryFormatter();
    Voo3 novo = (Voo3)bf.Deserialize(fileclose);
    fileclose.Close();
}
Console.WriteLine("dados do voo");
Console.WriteLine($"Origem :{voo3.Origem}");
Console.WriteLine($"Destino : {voo3.Destino}");
Console.WriteLine($"Compania : {voo3.Compania}");
Console.WriteLine($"dateTime1 : `{voo3.dateTime1}");
Console.ReadKey();

FileStream fileclose2 = new FileStream("voo3.xml", FileMode.Create);
XmlSerializer xs = new XmlSerializer(typeof(Voo3));
xs.Serialize(fileclose2, voo3);
fileclose2.Close();
Console.WriteLine(xs);
Console.WriteLine("feitro com sucesso");
Console.ReadKey();


