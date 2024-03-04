//LING-> Language Integrated Query
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

class LINQLearner
{
    void Learn()
    {
        int[] numbers=[3,4,5,6,7,12,78,89,98,123];
        List<string> names=["Sapana","Smriti","Anjana","Seema","Jenu","Iliya"];

        var S1 = new Student("Sapana", 2, new DateTime(1998,12,12));
        var S2 = new Student("Ram", 23, new DateTime(2000,1,30));
        var S3 = new Student("Hari", 12, new DateTime(1988,11,1));
        var S4 = new Student("Buddha", 1, new DateTime(2008,12,1));
        var S5 = new Student("krishna", 17, new DateTime(2001,1,12));

        List<Student> students = [S1, S2, S3, S4, S5]; 

        //get odd numbers from "numbers"
        var oddNumbers=numbers.Where(number=>number%2==1); //lamba Expression/arrow function
        //"=>" this is read as goes to

        //get squares of all items in "numbers"
        //yesma filter aauni wala xaina sabai each and every number ma operation garna parni xa so we have projection opertator

        var squares =numbers.Select(num=> num*num);
        //this is a collection jaha numbers ko square baseko xa

        //Get squares of even numbers only
         var evenSquares=numbers.Where(evenNumber=>evenNumber%2==0).Select(evenSquare=>evenSquare*evenSquare);
         // first ma whrer lagayera filter out garni even numbers,ani tyo even numbers ma select layera

         //Query Syntax or expression
         // from in this case is a contextual keyword
         //mathi ko ra yo same ho
         evenSquares= from x in numbers
                      where x%2==0
                      select x*x;

         //Get all name initials
         var initials = names.Select(name=>name[0]); //{'S','S','S','S','J'}  

         //Order names in ascending order

         var namesOrder = names.OrderBy(x => x);

         //Find Students wtih names starting with 'B'

         var bStudent= students.Where(student=>student.name.ToLower().StartsWith('b'));
         
         //Group Students by  birth month

         var dobGroups= students.GroupBy(student=>student.Dob.Month);

         // Get youngest Student

         var youngest = students.OrderByDescending(x => x.Dob).First(); 
         // first finds haru le yeuta matra item dinxa

         youngest = students.MaxBy(x => x.Dob);// testo element liney jasko dob maximun hunxa

        //youngest = students.FirstOrDefault( x => DateTime.Now- x.Dob);
         
         


    }

}