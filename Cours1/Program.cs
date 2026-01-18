// See https://aka.ms/new-console-template for more information

// Declarer une variable
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;




/*
if (etudiant || age < AGE_LIMITE)
{
    Console.WriteLine(" ok réduc");
} else
{
    Console.WriteLine("non réduc");
}
*/



// Je veux la table de 5 affiché de la sorte : " 5 x 0 fait 0    5 x 1 fait 5 etc.
/*
int nombre = 5;
int LIMITE = 50;

for (int compteur = 0; compteur*nombre <= LIMITE; compteur++)
{
    Console.WriteLine(nombre + " * " + compteur + " fait " +( compteur * nombre));
} */



/*******************************************************************/

/*                LES FONCTIONS                                   */

Console.WriteLine("De quel nombre on affiche la table ? : ");
tableDeMultiplication(5, 10);

/**
 * Cette fonction prends 2 paramere blabla
 */
static void tableDeMultiplication(int nombreTable, int nombreOccurence)
{
    int resultat = 0;
    for (int compteur = 0; compteur  <= nombreOccurence; compteur++)
    {
        resultat = (compteur * nombreTable);
        Console.WriteLine(nombreTable + " * " + compteur + " fait " + resultat);
    }
}



static int multiplierParDeux(int nombreArgument)
{
    return nombreArgument * 2; 
}


Console.WriteLine("début fonction" + multiplierParDeux(3));

int varialr = multiplierParDeux(8);

Console.WriteLine(varialr);