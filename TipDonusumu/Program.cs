// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
object onRenk = ConsoleColor.Green;
ConsoleColor arkaRenk = ConsoleColor.Red;
Console.ForegroundColor = (ConsoleColor)onRenk;
//Casting 
Console.BackgroundColor = arkaRenk;

float z = 100.25f;
int s = 100;
int toplam = Convert.ToInt32( z ) ;

int tcno = 1212121;
string ad = "duygu";
string soyad = "tezcan";
string fullname = ad +  "" + soyad + "" + tcno.ToString();
Console.WriteLine(fullname);



object x = 100;
x = Convert.ToInt32(x) + 200;
object y = 100.25M;

bool deger = true;
deger = !deger;
object name = "Duygu";
Console.WriteLine("int" + x);
Console.WriteLine("decimal" + y);
Console.WriteLine("Mantıksal" + deger);
Console.WriteLine("Katar" + ad);


