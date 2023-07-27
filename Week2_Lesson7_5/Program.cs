public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko 
            posła, premiera, sentarora, prezydenta.
            Dane testowe : 21
            Rezultat w terminalu: Możesz zostać posłem
        */

        Console.WriteLine("Podaj ile masz lat:");

        int userAge = Int32.Parse(Console.ReadLine());

        if (userAge >= 35)
        {
            Console.WriteLine("Możesz zostać: posłem, senatorem, premierem lub prezydentem.");
        }
        else if (userAge >= 30)
        {
            Console.WriteLine("Możesz zostać: posłem, senatorem lub premierem.");
        }
        else if (userAge >= 21)
        {
            Console.WriteLine("Możesz zostać: posłem lub premierem.");
        }
        else
        {
            Console.WriteLine("Masz za mało by ubiegać się o stanowisko posła, senatora, premiera lub prezydenta.");
        }
    }

}
