using System;

public class PrintResults
{
    public void PrintReport(FineFile fineFile)
    {
        Console.WriteLine("FINES");
        Console.WriteLine("reader_id,name,fine");

        foreach (Fine fine in fineFile.fines)
        {
            Console.WriteLine($"{fine.reader_id},{fine.name},{fine.fine}");
        }

        Console.WriteLine("FLAGGED");
        Console.WriteLine("reader_id,name");

        foreach (Fine flagged in fineFile.Flagged)
        {
            Console.WriteLine($"{flagged.reader_id},{flagged.name}");
        }

        Console.WriteLine("ERRORS");

        foreach (string error in fineFile.Errors)
        {
            Console.WriteLine(error);
        }

        Console.WriteLine($"TOTAL,{fineFile.total_fines}");
    }
}
