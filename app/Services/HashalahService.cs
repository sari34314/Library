using System.Collections.Generic;

public static class HashalahService
{
    public static HashalahFile CreateFile(int reportDay, List<string[]> rows)
    {
        HashalahFile file = new HashalahFile(reportDay);

        foreach (string[] row in rows)
        {
            file.Hashalahs.Add(new HashalahFile.Hashalah(row));
        }

        return file;
    }
}
