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

/*                LES FONCTIONS                                   

Console.WriteLine("De quel nombre on affiche la table ? : ");
tableDeMultiplication(5, 10);

/**
 * Cette fonction prends 2 paramere blabla

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


// Nouvelle modif

int mavar = 3;
*/
/*
int Blabla1 = 6;
int Blabla2 = -3;
float Test1 = 5.0f;
float Test2 = 4.0f;

Console.WriteLine(Blabla2 % Blabla1);
Console.WriteLine(Test1 / Test2);

int Nombre = 0;
Console.WriteLine(Nombre % 5);


int Test1 = 3;
Test1 += 7;
Console.WriteLine(Test1);

bool Henri = true;
bool Nina = true;

if (!(Henri && Nina));
{

    Console.WriteLine("Attendre tous les participants");
}

Console.WriteLine(Henri ^ Nina);

int Lolo1 = 5;
int Lolo2 = 9;

int resultat = 5 ^ 9;
Console.WriteLine(resultat);
*/



/* Exercice n°1:Faire la somme de tous les nombre entre 0 et 1000 qui sont multiples de 3 ou de 5.
*/
// Remarque : essai avec modulo = echec 

int somme = 0;
int LIMITE = 1000;

// Ajouter les multiples de 3
for (int i = 3; i <= LIMITE; i+=3) // Attention pas 2 fois int dans la parenthèse

{  
    somme += i;
}
   // Ajouter les multiples de 5
for ( int i = 5; i <= LIMITE; i+=5) // Attention pas de ; après parenthèse
{ 
    somme += i; 
}

// Enlever les doublons 
for ( int i= 15;  i <= LIMITE; i+=15)
{ 
    somme -= i; 
}
Console.WriteLine("la somme de ces nombre est " + somme); // Ne pas inclure le Writeline dans la boucle
                                                          // sinon ça affiche les résultats au fur et à mesure