using System;

namespace LesVariablesExo2
{

    /*Créer trois variables et leur attribuer des nombres au choix. Afficher les valeurs de ces nombres dans la console dans une phrase. 
    Additionner les deux premiers nombres puis multiplier le résultat avec le dernier nombre. 
    Afficher le résultat dans la console dans une phrase.*/

    class Program
    {
     
        static void Main(string[] args)
        {
            int number1 = 2;
            Console.WriteLine(number1);
            int number2 = 4;
            Console.WriteLine(number2);
            int number3 = 2;
            Console.WriteLine(number3);

            Console.WriteLine("La valeur de ces nombres sont: " + number1 + "," + number2 + "," + number3 );

            int sum = number1 + number2;
            Console.WriteLine("Le résultat de l'addition est " + sum);

            int product = sum * number3;
            Console.WriteLine("Le résultat de la multiplication est " + product);

        }
    }
}
