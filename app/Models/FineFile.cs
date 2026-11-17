using System;
using System.Collections.Generic;

public class FineFile
{
    public List<Fine> fines = new List<Fine>();
    public List<Fine> Flagged = new List<Fine>();
    public List<string> Errors = new List<string>();
    public int total_fines = 0;


}
public class Fine
{
    public string reader_id;
    public string name;
    public int fine=0;

}

