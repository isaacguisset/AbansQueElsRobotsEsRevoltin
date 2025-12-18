public class Program
{
    public static void Main()
    {
        List<string> electrodomestics = new List<string> { "Roomba", "Thermomix", "Cafetera", "Microones" };
        int[] numeros = new int[] { 5, 2, 3 };
         QuinsRobotsEliminar(electrodomestics, numeros);
    }

    public static void QuinsRobotsEliminar(List<string> electrodomestics, int[] numeros)
    {
        //son index per poder recorrer larray de nums i la llista de noms
        int elec = 0;    
        int num = 0; 

        //mentres quedi més d'un electrodomestic a la llista
        while (electrodomestics.Count > 1)
        {
            // en el primer cas seria 0+ 5-1 = 4 4 % 4 = 0 = Posicio que hem d'eliminar
            elec = (elec + numeros[num] - 1) % electrodomestics.Count;
            //eliminem el robot amb elecIndex (en el primer cas seria 0 per tant = Roomba)
            Console.WriteLine($"Eliminem el robot {electrodomestics[elec]}"); //  no fa falta peró ajuda a entendre com treballa el programa
            electrodomestics.RemoveAt(elec);
            // Pasem al següent número
            num = (num + 1) % numeros.Length;
        }

        //Ara ja només queda un robot
        Console.WriteLine(electrodomestics[0]);
    }
}
