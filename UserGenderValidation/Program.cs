// See https://aka.ms/new-console-template for more information

//rakenudus küsib kasutaja sugu (M/F)
//rakendus küsib kasutajal sisestada ta perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. (perekonnanimi)" / "Welcome Ms. (perekonnanimi)"

Console.WriteLine("Please, select your gender (m/f).");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string ehk sõna formaadis

Console.WriteLine("Please, eneter your last name.");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome,{userLastName}!");
}
