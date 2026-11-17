using App;
using System.Collections.Generic;

public class HashalahFile
{
    public int Report_day;
    public List<Hashalah> Hashalahs;
    public class Hashalah
    {
        public string reader_id;
        public string name;
        public Type type;
        public string book;
        public int loan_day;
        public int return_day;

        public Hashalah(string[] data)
        {
            reader_id = data[0];
            name = data[1];
            switch (data[2])
            {
                case "student":
                    type = Type.student;
                    break;
                case "teacher":
                    type = Type.teacher;
                    break;
                case "guest":
                    type = Type.guest;
                    break;
                default:
                    throw new App.NotFoundInEnums(data[2]);
            }
            book = data[3];
            loan_day = int.Parse(data[4]);
            return_day = string.IsNullOrWhiteSpace(data[5]) ? 0 : int.Parse(data[5]);
        }
    }
    public HashalahFile(int report_day) 
    { 
        Report_day = report_day;
        Hashalahs=new List<Hashalah> ();
    }
}
