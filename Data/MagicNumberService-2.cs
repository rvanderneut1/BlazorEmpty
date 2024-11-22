
/*
Andere namespace geen problemen. Als je nu bijvoorbeeld de namespace veranderd naar BlazorEmpty.Data .
Dan krijg je de volgende error CS0101: The namespace 'BlazorEmpty.Data' already contains a de 
finition for 'MagicNumberService .
*/
namespace BlazorEmpty.Data2;
//namespace BlazorEmpty.Data;

public class MagicNumberService {

    public List<int> GetMagicNumbers()
    {
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