using System.Xml.Schema;

Console.Clear();

// En metod som summerar två värden
static int Summa(int tal1, int tal2) {
    int svar = tal1 + tal2;

    return svar;
}

int summa = Summa(15, 28);
Console.WriteLine(summa);

static string Längst(string text1, string text2) {
    if (text1.Length > text2.Length) {
        return text1;
    } else {
        return text2;
    }
}

string LängstString = Längst("Hallo", "Goddag");
Console.WriteLine(LängstString);



Console.Write("Ange ett heltal");
int tal = LäsInHeltal();

static int LäsInHeltal()
{
    int heltal = 0;
    while (!int.TryParse(Console.ReadLine(), out heltal)) {
        Console.WriteLine("Felaktig inmatning");
    }
    return heltal;
}