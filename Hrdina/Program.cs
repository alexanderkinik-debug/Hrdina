Hrdina h1 = new Hrdina();
h1.meno = "Thor";
Hrdina h2 = new Hrdina();
h2.meno = "Loki";

Random nahoda = new Random();
int kolo = 0;

while (h1.zdravie > 0 && h2.zdravie > 0)
{
    kolo++;
    Console.WriteLine("--- Kolo " + kolo + " ---");

    int sila1 = nahoda.Next(10, 31);
    if (h1.Utok(sila1))
    {
        Console.WriteLine(h1.meno + " zautocil!");
        int zdravie = h2.PrijmiZranenie(sila1);
        Console.WriteLine(h2.meno + " ma zdravie " + zdravie);
    }
    else
    {
        Console.WriteLine(h1.meno + " Musi oddichovat");
    }
    
    int sila2 = nahoda.Next(10, 31);
    if (h2.Utok(sila2))
    {
        Console.WriteLine(h2.meno + " zautocil!");
        int zdravie = h1.PrijmiZranenie(sila2);
        Console.WriteLine(h1.meno + " ma zdravie " + zdravie);
    }
    else
    {
        Console.WriteLine(h2.meno + " Musi oddichovat");
    }

    h1.energia += 5;
    h2.energia += 5;
}

Console.WriteLine();
if (h1.zdravie > 0)
{
    Console.WriteLine("Vyhral" + h1.meno);
}
else if (h2.zdravie > 0)
{
    Console.WriteLine("Vyhral" + h2.meno);
}
else
{
    Console.WriteLine("Remiza obaja zomreli.");
}
class Hrdina
{
    public string meno { get; set; }
    public int zdravie { get; set; } = 100;
    public int energia { get; set; } = 50;
    
    public bool Utok(int cena_energie)
    {
        if (energia >= cena_energie)
        {
            energia -= cena_energie;
            return true; 
        }

        return false;
        }
        public int PrijmiZranenie(int sila)
        {
            zdravie -= sila;
            if (zdravie < 0)
            {
                zdravie = 0;
            }

            return zdravie;
    }
}

