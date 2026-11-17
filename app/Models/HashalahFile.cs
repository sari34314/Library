using System;
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
        //public Hashalah(string reader_id, string name, Type type, string book, int loan_day, int return_day)
        //{
        //    this.reader_id = reader_id;
        //    this.name = name;
        //    this.type = type;
        //    this.book = book;
        //    this.loan_day = loan_day;
        //    this.return_day = return_day;
        //}
        public Hashalah(string[] data)
        {
            
        }
    }
    public HashalahFile(int report_day) 
    { 
        Report_day = report_day;
        Hashalahs=new List<Hashalah> ();
    }
}
