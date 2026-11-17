using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public  class HashalahService
{
    public  HashalahFile EnteringDataIntoTheModel(int reportDay, List<string[]> rows)
    {
        HashalahFile file = new HashalahFile(reportDay);

        foreach (string[] row in rows)
        {
            file.Hashalahs.Add(new HashalahFile.Hashalah(row));
        }
        return file;
    }
}
