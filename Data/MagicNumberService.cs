
/*
 namespace is een logische container om klasse in te groeperen. Om naamconflicten te voorkomen.
 vb. ik kan bijvoorbeeld nog een MagicNumberService class aanmaken. Als deze een andere namespace 
 heeft dan geeft de code geen error. Kijk maar naar MagicNumberService-2.
*/
namespace BlazorEmpty.Data;

//public geeft aan dat ik deze klasse overal in de code mag aanroepen
public class MagicNumberService {

    //GetmagicNumbers methode verwacht geen parameters. Maar geeft wel een list met int retour.
    public List<int> GetMagicNumbers()
    {
        //Hier maak ik direct een list met ints aan. Dit wordt een Object initializers genoemd in c#
        return new List<int>()
        {
            Random.Shared.Next(1, 100),
            Random.Shared.Next(1, 100),
            Random.Shared.Next(1, 100),
            Random.Shared.Next(101, 200),
            Random.Shared.Next(101, 200),
            Random.Shared.Next(101, 200)
        };
    }
}