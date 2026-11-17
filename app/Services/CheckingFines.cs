using System;

public class CheckingFines
{
    public FineFile Check(HashalahFile hashalahFile)
    {
        FineFile fineFile = new FineFile();

        foreach (HashalahFile.Hashalah hashalah in hashalahFile.Hashalahs)
        {
            int endDay = hashalah.return_day == 0
                ? hashalahFile.Report_day
                : hashalah.return_day;
            int days = Math.Max(0, endDay - hashalah.loan_day);

            switch (hashalah.type)
            {
                case Type.student:
                    AddStudentFine(hashalah, days, fineFile);
                    break;
                case Type.teacher:
                    CheckTeacher(hashalah, days, fineFile);
                    break;
                case Type.guest:
                    AddGuestFine(hashalah, days, fineFile);
                    break;
            }
        }

        return fineFile;
    }

    private int CalculateStudentFine(int days)
    {
        if (days <= 15)
        {
            return 0;
        }

        return Math.Min(days - 14, 30);
    }

    private void AddStudentFine(HashalahFile.Hashalah hashalah, int days, FineFile fineFile)
    {
        int fineAmount = CalculateStudentFine(days);

        AddFineRecord(hashalah, fineAmount, fineFile);
    }

    private void CheckTeacher(HashalahFile.Hashalah hashalah, int days, FineFile fineFile)
    {
        AddFineRecord(hashalah, 0, fineFile);

        if (hashalah.return_day == 0 && days > 60)
        {
            fineFile.Flagged.Add(new Fine
            {
                reader_id = hashalah.reader_id,
                name = hashalah.name,
                fine = 0
            });
        }
    }

    private void AddGuestFine(HashalahFile.Hashalah hashalah, int days, FineFile fineFile)
    {
        int fineAmount = CalculateGuestFine(days);
        AddFineRecord(hashalah, fineAmount, fineFile);
    }

    private int CalculateGuestFine(int days)
    {
        if (days <= 7)
        {
            return 0;
        }

        return (int)Math.Ceiling((days - 7) * 2.5);
    }

    private void AddFineRecord(HashalahFile.Hashalah hashalah, int fineAmount, FineFile fineFile)
    {
        fineFile.fines.Add(new Fine
        {
            reader_id = hashalah.reader_id,
            name = hashalah.name,
            fine = fineAmount
        });

        fineFile.total_fines += fineAmount;
    }
}
