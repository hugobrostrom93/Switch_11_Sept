namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad vill du ha att dricka till maten?");
            Console.WriteLine();

            Console.WriteLine("Välj ett av de 5 olika alternativen nedan så ska vi se om det finns!");
            Console.WriteLine();
            Console.WriteLine("1: Cola");
            Console.WriteLine("2: Fanta");
            Console.WriteLine("3: Pepsi");
            Console.WriteLine("4: Vatten");
            Console.WriteLine("5: Öl");

            Console.WriteLine();
            string val = Console.ReadLine();
            Console.WriteLine();

            switch (val)
            {
                case "1":
                    Console.WriteLine("Bra val! Vi har Cola :)");
                    break;
                case "2":
                    Console.WriteLine("Tyvärr har vi inte Fanta just nu...");
                    break;
                case "3": 
                    Console.WriteLine("Pepsi är vår favorit! Kommer strax...");
                    break;
                case "4":
                    Console.WriteLine("Vad nyttig du är! Fixar det på direkten :)");
                    break;
                case "5":
                    Console.WriteLine("Ölen är tyvärr slut idag...");
                    break;
                default: 
                    Console.WriteLine("Du måste välja ett alternativ mellan 1 och 5");
                    break;
            }
        }
    }
}