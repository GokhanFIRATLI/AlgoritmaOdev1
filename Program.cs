Console.WriteLine("1.");
Console.Write("Pozitif bir sayı giriniz: ");
int n = int.Parse(Console.ReadLine());
if (n < 1)
{
    do
    {
        Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
        n = int.Parse(Console.ReadLine());
    } while (n < 1);

}

int[] seri = new int[n];
Console.WriteLine("{0} adet pozitif sayı giriniz: ", n);

for (int i = 0; i < n; i++)
    seri[i] = int.Parse(Console.ReadLine());

Console.Write("Girmiş olduğunuz sayılardan çift olanları: ");

for (int k = 0; k < n; k++)
{
    if (seri[k] % 2 == 0)
        Console.Write(seri[k] + " ");
}


Console.WriteLine();
Console.WriteLine("2.");
Console.Write("Pozitif bir sayı giriniz: ");
int j = int.Parse(Console.ReadLine());
if (j < 1)
{
    do
    {
        Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
        j = int.Parse(Console.ReadLine());
    } while (j < 1);
}

Console.Write("Pozitif bir sayı daha giriniz: ");
int m = int.Parse(Console.ReadLine());

if (m < 1)
{
    do
    {
        Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
        m = int.Parse(Console.ReadLine());
    } while (m < 1);
}

int[] seri2 = new int[j];
Console.WriteLine("{0} adet pozitif sayı giriniz: ", j);

for (int i = 0; i < j; i++)
    seri2[i] = int.Parse(Console.ReadLine());

Console.Write("Girmiş olduğunuz sayılardan {0}'a eşit yada tam bölünebilir olanları: ", m);

for (int k = 0; k < j; k++)
{
    if (seri2[k] % m == 0)
        Console.Write(seri2[k] + " ");
}

Console.WriteLine();
Console.WriteLine("3.");
Console.Write("Pozitif bir sayı giriniz: ");
int l = int.Parse(Console.ReadLine());
if (l < 1)
{
    do
    {
        Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
        l = int.Parse(Console.ReadLine());
    } while (l < 1);
}

string[] seri3 = new string[l];
Console.WriteLine("{0} adet kelime giriniz: ", l);

for (int i = 0; i < l; i++)
    seri3[i] = Console.ReadLine();

for (int g = l - 1; g >= 0; g--)
    Console.Write(seri3[g] + " ");

Console.WriteLine();
Console.WriteLine("4.");
Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();
string[] seri4 = cumle.Split(' ');
string cumle2 = string.Join("",seri4);
char[] seri5 = cumle2.ToCharArray();
Console.WriteLine("Cümledeki toplam kelime sayısı {0}, harf sayısı {1} adettir.", seri4.Length, seri5.Length);
