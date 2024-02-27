// Single Inheritance -> one base class one derived class 

class CSStudent: Student, IGradable  //inherit from Student class and implement IGradable interface
// Multiple Inheritance
{
    public string ProjectTitle { get; set; }
    public string InternWork { get; set; }
    public double GetGrade()=>34;
    public CSStudent(string name, byte rn, string pTitle):base(name,rn)// base class ko constructor lai call garna we use base keyword
    {
        ProjectTitle=pTitle;
    }
}