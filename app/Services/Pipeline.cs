using System.Collections.Generic;

public class Pipeline
{
    public void Run(int reportDay, List<string[]> rows)
    {
        HashalahFile hashalahFile = new HashalahService()
            .EnteringDataIntoTheModel(reportDay, rows);

        FineFile fineFile = new CheckingFines().Check(hashalahFile);

        new PrintResults().PrintReport(fineFile);
    }
}
