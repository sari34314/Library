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
                    CheckTeacher(hashalah);
                    break;
                case Type.guest:
                    CheckGuest(hashalah);
                    break;
            }
        }

        return fineFile;
    }

    private int CalculateStudentFine(int days)
    {
        if (days <= 14)
        {
            return 0;
        }

        return days - 14;
    }

    private void AddStudentFine(HashalahFile.Hashalah hashalah, int days, FineFile fineFile)
    {
        int fineAmount = CalculateStudentFine(days);

        Fine fine = new Fine
        {
            reader_id = hashalah.reader_id,
            name = hashalah.name,
            fine = fineAmount
        };

        fineFile.fines.Add(fine);
        fineFile.total_fines += fineAmount;
    }

    private void CheckTeacher(HashalahFile.Hashalah hashalah)
    {
    }

    private void CheckGuest(HashalahFile.Hashalah hashalah)
    {
    }
}
