using System;

class Student
{
    public string name;
    byte rollNumber;
        //property
    // get set value is a keyword
    public byte RollNumber //this is property
     {
        get 
        {
            return rollNumber;

        }
        set 
        {
            if(value<=100)
            {
                rollNumber=value;
            }
        }
     }
    string address;
    
    //Auto Implemented property
    public string Address{get; set;} //this is property without logic 
    public DateTime Dob{get;} //this is read only property-> yesko value set garna mildaina
    public Student() // default constructor=> this is a method without return value
    {

    }
    public Student(string n, byte rn) //parameterized constructor
    {
        name= n; //initialized value of name
        RollNumber=rn; //initialized garda nai property use garna sakinxa

    }
     public Student(string n, byte rn, DateTime dob) 
    {
        name= n; //initialized value of name
        RollNumber=rn; 
        Dob = dob;

    }
    
     public virtual void StudentInfo() // this is method ,virtual keyword use garere yeslai overirde gana sakinxa
     {
        Console.WriteLine($"Student name = {name}");
        Console.WriteLine($"Student  rollnumber = {rollNumber}");
        Console.WriteLine($"Student DateOfBirth :{Dob}");
        Console.WriteLine($"Student Address :{Address}");


     }

}