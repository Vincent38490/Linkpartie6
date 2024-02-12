// See https://aka.ms/new-console-template for more information
using Linkpartie6;
using System.Text.RegularExpressions;

List<Personne> personnes = new List<Personne>()
 {
 new Personne("Garett", "Ramzy", 45, "M"),
 new Personne("Caire", "Joe", 35, "M"),
 new Personne("Clay", "Alicia", 18, "F"),
 new Personne("Bavette", "Simone", 68, "F"),
 new Personne("Henry", "Thierry", 44, "M"),
 new Personne("Jacquesonne", "Janett", 25, "F"),
 new Personne("Buveur", "Joe", 25, "M"),
 new Personne("Louet", "Karim", 31, "M"),
 new Personne("Louette", "Karima", 31, "F"),
 new Personne("Caire", "Paul", 19, "M"),
 new Personne("Mille", "Camille", 20, "F"),
 new Personne("Cent", "Camille", 40, "F"),
 new Personne("Million", "Camille", 60, "M"),
 new Personne("Gold", "Roger", 17, "M"),
 new Personne("Lion", "Sandra", 8, "F"),
 new Personne("René", "Jean", 6, "M")
 };


//exo1
var grou = from Personne person in personnes
           group person by person.Sexe;




foreach (var person in grou)
{
    Console.WriteLine($"Key: {person.Key}");
    foreach (Personne pers in person)
    {
        Console.WriteLine(pers.Nom + pers.Prenom);
    }
}


//exo2
Console.WriteLine("exo2");
var grou2 = from Personne person in personnes
            orderby person.Age
           group person by person.Age;




foreach (var person in grou2)
{
    Console.WriteLine($"Key: {person.Key}");
    foreach (Personne pers in person)
    {
        Console.WriteLine(pers.Nom + pers.Prenom);
    }
}


//exo3
Console.WriteLine("exo3");
var grou3 = from Personne person in personnes
            orderby person.Prenom descending
            where person.Age > 18
            group person by person.Prenom;




foreach (var person in grou3)
{
    Console.WriteLine($"Key: {person.Key}");
    foreach (Personne pers in person)
    {
        Console.WriteLine(pers.Nom);
    }
}




List<int> nombres = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 11, 13, 12, 14, 18, 17, 16, 14, 14 };

//exo4

var listnum = from int nbr in nombres
               group nbr by nbr%2 ==0 ;



foreach (var lnum in listnum)
{
    Console.WriteLine($"pair : {lnum.Key}");
    foreach (var num in lnum)
    {
        Console.WriteLine(num);
    }
}

//exo5
var individu = from Personne person in personnes
               orderby person.Nom
               group person by person.Nom[0];



foreach (var person in individu)
{
    Console.WriteLine($"Key: {person.Key}");
    foreach (Personne pers in person)
    {
        Console.WriteLine(pers.Nom);
    }
}



/*Ecrire les requêtes LINQ permettant de :
1. Faire un group by sur le genre (sexe) des personnes présentes dans la liste d'objets
Personne(). Ensuite parcourir le résultat et afficher les nom et prénoms des personnes 
classées par genre.
2. Faire un group by sur l'âge des personnes. Faire un tri croissant par âge et afficher les nom, 
prénoms des personnes classées et triées par Age.
3. Faire un group by sur le prénom des personnes, et afficher les noms de famille par prénom.
• Trier les prénoms par ordre décroissant.
• Récupérer les personnes majeures (18 ans et plus)
Exercice 2
Soit la liste des nombres suivante :
List<int> nombres = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 11, 13, 12, 14, 18, 17, 16, 14, 14 };
Ecrire les requêtes LINQ permettant de :
1. Grouper les éléments da la liste des nombres. D'un côté les chiffres/nombres pairs, de l'autre 
ceux impairs.
2. Grouper les individus par la première lettre de leur nom et faire un tri croissant sur l'attribut 
Nom de la classe Personne*/
