using System;
using System.Collections.Generic;
class Collection_learn
{
    void Learn()
    {
        // 1-D array

        byte[] ages= [23,21,22,24,6,4,2]; 
        string[] names=["Sapana","Smriti kc", "Priyanka"];

        // 2-D array
        //, is added for 2 dimensional
        int[,] studentsInClassRoom= new int[7,6]; //aghadi ko column pachhadi ko row
        studentsInClassRoom[0,0]=0;
        studentsInClassRoom[0,1]=1;
        studentsInClassRoom[0,2]=2;
        studentsInClassRoom[0,3]=3;
        studentsInClassRoom[0,4]=4;
        studentsInClassRoom[0,5]=5;

        // jagged array
        int[][] studentsInClassRooms= [[1,2,3],[3,4],[3,5,6,7]];

        //  collection list==> list is a generic class
        List<int>ageList=[2,3,4,5];// list of type int
        List<string>nameList=["hello", "hii","byee"];// list of type string //O(n),n=40000000000
        
        // dictionary ==> key-value pair, this is also generic 
        Dictionary<string,long> countryPopulation= new(); //keyy should be unique
        countryPopulation.Add("Nepal",3101111111);
        countryPopulation.Add("India",31044441111);
        countryPopulation.Add("China",310111155111);
        countryPopulation.Add("USA",3101111111);

        var p=countryPopulation["India"];// O(log n)








    }

}