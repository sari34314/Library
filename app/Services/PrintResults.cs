using System;

public class PrintResults
{
    public void PrintFines(FineFile fineFile)
    {
        Console.WriteLine("FINES");

        foreach (Fine fine in fineFile.fines)
        {
            Console.WriteLine($"{fine.reader_id},{fine.name},{fine.fine}");
        }
    }
}
