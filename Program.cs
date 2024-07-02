MIT License

Copyright (c) 2024 Talha TEMEL

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


//////////// SYNTAX //


using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}



using System;
using System.Runtime.Serialization.Formatters;

/////////// ÇIKIŞ //

Console.WriteLine("Hello World!");
Console.Write("hello world");



//////////// DEĞİŞKENLER //

var variablename = new ValueTask<string>();
int myNum = 0;
double myDouble = 0.0;
char myLetter = 'A';
bool myBool = false;
string myText = "merba";



//////////// SABİT //

const int num = 5;



/////////// GÖRÜNTÜLEME DEĞİŞKENİ //

string isim = "Talha";
string soyisim = "Temel";
string fullisim = isim + soyisim;
Console.WriteLine(fullisim);



////////// ÇOKLU DEĞİŞKENLER //

int x = 5, y = 5, z = 5;
Console.WriteLine(x + y + z);



/////////// ÖRTÜK (int > double) VE AÇIK DÖKÜM (double > int) //

double büyük = 1.4;
int küçük = (int)büyük;
Console.WriteLine(küçük);



////////// TÜR DÖNÜŞTÜRME //

int mytam = 10;
double mypar = 10.5;
bool mydoğrum = false;


Console.WriteLine(Convert.ToString(mytam));
Console.WriteLine(Convert.ToDouble(mytam));
Console.WriteLine(Convert.ToInt32(mypar));
Console.WriteLine(Convert.ToString(mydoğrum));



///////// KULLANICIDAN VERİ ALMA //

Console.WriteLine("İsmin: ");
string userName = Console.ReadLine();
Console.WriteLine("İsmin: " + userName);

Console.WriteLine("yaşın: ");
int yas = int.Parse(Console.ReadLine()); // Kullanıcının girdisini int olarak okuyun
										 // int yas = Convert.ToInt32(Console.Readline());
Console.WriteLine("yaşın: " + yas);



/*//////////// İŞLEÇ VE ATAMALAR //

 
int x = 10 + 5;
x *= 3; // x = x * 3 operatörler
x &= 3; // atama işleçleri
x |= 3;
x ^= 3;
x >>= 3;
x <<= 3;
*/


Console.WriteLine("*****************");


////////////// KARŞILAŞTIRMA //

// PYTHON İLE AYNI 


Console.WriteLine();


/*/////////// MANTIKSAL İŞLEÇLER //

&&   Her iki ifade de doğruysa True değerini döndürür
||   İfadelerden biri doğruysa True değerini döndürür
!    Terslik, sonuç doğruysa Yanlış değerini döndürür
*/

//////////// MATEMATİĞİ //

Math.Max(5, 10); // en yüksek x ve y
Math.Min(5, 10); // en küçük x ve y
Math.Sqrt(64); // karekökü döndürür
Math.Abs(-4.7); // mutlak pozitif
Math.Round(9.99); // yuvarlar



//////////// DİZELER //

string txt = "Hello";
Console.Write("Uzunluğu: " + txt.Length);
Console.Write(txt.ToUpper());
Console.Write(txt.ToLower());

string txx = "Hi";
string ttx = string.Concat(txt, txx);



///////// DİZE İNTERPOLASYONU //

string asdh = "fgh";
string asdf = "fghj";
string asf = $"interpolasyon :  {asdh} {asdf} ";



//////// ERİŞİM DİZELERİ //

/* buraya bak
string asd = "asd";

// [] kelimeyi verir
Console.WriteLine(asd[0]); // a çıktısını verir pythondaki gibi []

// IndexOf() yolu verir
Console.WriteLine(asd.IndexOf("a"));

// Substring() yolu ve yoldan gerisini keser
string talhat = asd.Substring(1);




///////// DİZELER ÖZEL KARAKTERLER //
string txtuı = "deneme "viking" from the nort.";
/*
 
\' = '
\" = "
\\ = \



\n //new line
\t //tab
\b //backspace

*/



////////// BOOL DEĞER //

Console.WriteLine("Yaşınız kaç: ");
var tem = int.Parse(Console.ReadLine());
int teme = 18;

if (tem >= teme)
	Console.WriteLine(" Oy verebilirsin ");

else
	Console.WriteLine(" Yaşınız tutmuyor ");


///////// İF,  ELSE İF,  ELSE //

if (3 > 2)
	Console.WriteLine("True");

else if (3 < 2)
	Console.WriteLine("False");

else
	Console.WriteLine("ELSE");



///////// SHORT İF's //

string sonuc = (3 > 2) ? "Doğru" : "Yanlış";


///////// SWİTCH CASE'LER //

int gün = 3;
switch (gün)
{
	case 1:
		Console.WriteLine("PZT");
		break;
	case 2:
		Console.WriteLine("SALI");
		break;
	case 3:
		Console.WriteLine("Çarşamba");
		break;
	case 4:
		Console.WriteLine("Perşembe");
		break;
	case 5:
		Console.WriteLine("Cuma");
		break;
	case 6:
		Console.WriteLine("Cumartesi");
		break;
	case 7:
		Console.WriteLine("Pazar");
		break;
}



/////////// DO-WHİLE DÖNGÜSÜ //


int i = 0;
do
{
	Console.WriteLine(i);
	i++;
}
while (i < 5);



/////////// FOR DÖNGÜSÜ //
for (int o = 0; o <= 10; o = o + 2)
{
	Console.Write(o + " ");
}




////////// İÇ İÇE DÖNGÜLER //

for (int ü = 1; ü <= 2; ++ü)
{
	Console.WriteLine("iç içe " + ü);
	for (int j = 1; j <= 3; j++)
	{
		Console.WriteLine("iç içe " + j);
	}
}



//////////// LİSTE YAPISI //

string[] os = { "win", "macos", "elementery", "redhat" };




/////////// FOREACH DÖNGÜSÜ //


string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Array.Sort(cars);
foreach (string k in cars)
{
	Console.WriteLine(k);

}


string[] ka = { "Volvo", "BMW", "Ford", "Mazda" };
for (int il = 0; il < cars.Length; il++)
{
	Console.WriteLine(cars[il]);
}


////////// Break ve Continue deyimi //

for (int l = 0; l < 10; l++)
{
	if (l == 4)
	{
		break;
	}
	Console.WriteLine(l);
}

for (int c = 0; c < 10; i++)
{
	if ( c == 4)
	{
		continue;
	}
	Console.WriteLine(c);
}


int v = 0;
while (v < 10)
{
	Console.WriteLine(v);
	v++;
	if ( v == 4)
	{
		break;
	}
}


int n = 0;
while (n < 10)
{
	if (n == 4)
	{
		n++;
		continue;
	}
	Console.WriteLine(n);
	n++;
}

/*
 System.Linq Ad Alanı
diğer yararlı dizi yöntemleri ad alanında bulunabilir: Min Max SumSystem.Linq

using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    }
  }
}

*/



/////////// İKİ BOYUTLU DİZELER //

/*
int[,] numbes = { { 1, 4, 2 }, { 3, 6, 8 } };
int po = numbes[0, 2];
numbes[0, 0] = 5; //öğe değiştirme
*/

int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

foreach (int ğ in numbers) //2b dizede döngü
{
	Console.WriteLine(ğ);
}

int[,] numbes = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int iğ = 0; iğ < numbes.GetLength(0); iğ++)
{
	for (int jğ = 0; jğ < numbes.GetLength(1); jğ++)
	{
		Console.WriteLine(numbes[iğ, jğ]);
	}
}




/////////// METHODLAR //

class Program
{
	static void Methodum()
	{
		Console.WriteLine("I just got executed!");
	}

	static void Main(string[] args)
	{
		Methodum();
	}

}



///////// YÖNTEM METHODLARI //
 
class Program
{
	static void temel(string isim, int yaş)
	{
		Console.WriteLine(isim + "yaşı" + yaş);
	}

	static void Main(string[] args)
	{
		temel("Temel", 19);
		temel("Mehmed", 18);
		temel("Fatih" , 21);
	}
}



/////////// VARSAYILAN PARAMETRE //

static void MyMethod(string ülke = "Türkiye")
{
	Console.WriteLine(ülke);
}

static void Main(string[] args)
{
	MyMethod("Rusya");
	MyMethod("ABD");
	MyMethod();
	MyMethod("Çin");
}



///////////// DÖNÜŞ DEĞERLERİ //

static int değer(int x, int y)
{
	return x + y;
}

static void Main(string[] args)
{
	int z = değer(5, 3);
	Console.WriteLine(z);
}

// çıktısı 8 (5 + 3)



///////////// ADLANDIRILMIŞ BAĞIMSIZ DEĞİŞKENLER //

static void MyMethod(string ç1, string ç2, string ç3)
{
	Console.WriteLine("en genç çocuk: " + ç3);
}

static void Main(string[] args)
{
	MyMethod(ç3: "Temel", ç1: "Tembel", ç2: "Temele");
}

// en genci Temel



//////////////// YÖNTEMİ AŞIRI YÜKLEME //

int d1(int a)
float d2(float s)
double d3(double x, double d)


static int aşırıyükleme(int v, int b)
{
	return a + s;
}

static double aşırıyükleme(double n, double m
{
	return a + s;
}

static void Main(string[] args)
{
	int numara1 = aşırıyükleme(8, 5);
	double numara2 = aşırıyükleme(4.3, 6.26);
	Console.WriteLine("Int: " + numara1);
	Console.WriteLine("Double: " + numara2);
}