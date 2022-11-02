using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] menyval = new string[] { "Registrering", "Köpa bil", "Personal", "Service", "Avsluta" };
        int menyvälja = 0;

        while (true)
        {
            Console.Clear();

            if (menyvälja == 0)
            {
                Console.WriteLine(menyval[0] + "<--");
                Console.WriteLine(menyval[1]);
                Console.WriteLine(menyval[2]);
                Console.WriteLine(menyval[3]);
                Console.WriteLine(menyval[4]);
            }
            else if (menyvälja == 1)
            {
                Console.WriteLine(menyval[0]);
                Console.WriteLine(menyval[1] + "<--");
                Console.WriteLine(menyval[2]);
                Console.WriteLine(menyval[3]);
                Console.WriteLine(menyval[4]);
            }
            else if (menyvälja == 2)
            {
                Console.WriteLine(menyval[0]);
                Console.WriteLine(menyval[1]);
                Console.WriteLine(menyval[2] + "<--");
                Console.WriteLine(menyval[3]);
                Console.WriteLine(menyval[4]);
            }
            else if (menyvälja == 3)
            {
                Console.WriteLine(menyval[0]);
                Console.WriteLine(menyval[1]);
                Console.WriteLine(menyval[2]);
                Console.WriteLine(menyval[3] + "<--");
                Console.WriteLine(menyval[4]);
            }
            else if (menyvälja == 4)
            {
                Console.WriteLine(menyval[0]);
                Console.WriteLine(menyval[1]);
                Console.WriteLine(menyval[2]);
                Console.WriteLine(menyval[3]);
                Console.WriteLine(menyval[4] + "<--");
            }


            //var för att det är en pil. Ingen siffra eller sträng	
            var keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.DownArrow && menyvälja != menyval.Length - 1)
            {
                menyvälja++;
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow && menyvälja >= 1)
            {
                menyvälja--;
            }
            else if (keyPressed.Key == ConsoleKey.Enter)
            {
                switch (menyvälja)
                {
                    case 0:
                        brojjedan();

                        break;
                    case 1:
                        brojdva();
                        break;
                    case 2:
                        brojtri();
                        break;
                    case 3:
                        brojcetiri();
                        break;
                    case 4:
                        brojpet();
                        break;
                }
            }
        }
    }

    public static void brojjedan()
    {
        Console.WriteLine("Registrering");
        //registrera kund hos bilhandlaren
        Console.WriteLine("Skriv in ditt namn ");
        string kund = Console.ReadLine();
        Console.WriteLine("Hej och välkommen till oss " + kund);
        Console.ReadKey();
    }
    public static void brojdva()
    {
        Console.WriteLine("Bilköp");
        Console.WriteLine("De här nya bilarna finns tillgängliga. ");
        string bilar = Console.ReadLine();
        string[] bil = new string[] { " Volvo x40 2015", " BMW x5 2022", " Opel corsa 2000", " Mazda cx3 2010" };
        foreach (string item in bil)
        Console.WriteLine(item);
        Console.ReadKey();
    }
    public static void brojtri()
    {
        Console.WriteLine("Personalhantering");
        string[] personal = new string[5];
        personal[0] = "Johan, VD och har jobbat här sedan 2012";
        personal[1] = "Micke, Säljare och har jobbat här sedan 2018";
        personal[2] = "Daniel, Säljare och har jobbat här sedan 2012";
        personal[3] = "Jakob, Tekniker och har jobbat här sedan 2019";
        personal[4] = "Maria, Tekniker och har jobbat här sedan 2020";

        for (int i = 0; i < personal.Length; i++)
        {
            Console.WriteLine(personal[i]);
            Console.ReadKey();
        }
    }
    public static void brojcetiri()
    {
        Console.WriteLine("Service");
        string service = Console.ReadLine();
        Console.WriteLine("Valen kommer listas här nedan. Var god gör valen med siffrorna");

        //Menyn dyker upp
        Console.WriteLine("Välj ditt val");
        Console.WriteLine("*************");
        Console.WriteLine("[1] Besiktning");
        Console.WriteLine("[2] Kontroll av olja");
        Console.WriteLine("[3] Reperation");
        Console.WriteLine("[4] Lampkontroll\n");
        Console.WriteLine("[5] Avsluta");
        service = Console.ReadLine();


        switch (service)
        {
            case "1":
                Console.WriteLine("Du har valt att besikta din bil");

                Console.ReadLine();
                break;

            case "2":
                Console.WriteLine("Du valde att fylla på oljan");
                Console.ReadLine();
                break;


            case "3":
                Console.WriteLine("Ditt val att reparera gpsen som gått sönder har gjorts");
                Console.ReadLine();
                break;

            case "4":
                Console.WriteLine("Kontrollera dina lampor kommer en tekniker att göra");
                Console.ReadLine();
                break;

            case "5": //stängs av
                Console.WriteLine("Du valde att avsluta");
                Console.ReadLine();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Du valde inget av alternativen och skickas tillbaka");
                Console.ReadLine();
                break;
                Console.ReadKey();
        }
    }
        public static void brojpet()
        {
            Console.WriteLine("Avslutas");
            Console.WriteLine("Du kommer skickas tillbaka till menyn");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }

    