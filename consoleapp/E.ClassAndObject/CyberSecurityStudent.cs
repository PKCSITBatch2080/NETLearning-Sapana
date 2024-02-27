//this is multilevel inheritance 
using System;

class CyberSecurityStudent:CSStudent
{
    public CyberSecurityStudent(string name, byte rn, string pTitle,string certification):base(name,rn,pTitle)//inherit from csstudent
    {
        SecurityCertification= certification;
    }
    public string EthicalHackingCourseTitle { get; set; }
    public string SecurityCertification { get; set; }
    public string CertifiedDate { get; set; }
    public override void StudentInfo()
    {
        base.StudentInfo();
        Console.WriteLine($"Certification: {SecurityCertification}");
        Console.WriteLine($"Certified Date: {CertifiedDate}");
    }


}