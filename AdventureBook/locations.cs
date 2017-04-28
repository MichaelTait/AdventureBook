using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBook
{

    public class Navigation
    {

        public void testLocate()
        {
            List<string> locateList = new List<string>();
            locateList.Add();
        }

       /* public static void testLocate()
        {
            List<List<string>> locate = new List<List<string>>();
            locate.Add(new List<string>() {StartPoint, Rm2});
            locate.Add(new List<string>() {Rm2, Rm3, Rm4 , Rm5});
            locate.Add(new List<string>() {Rm3});
            locate.Add(new List<string>() {Rm4, Rm2});
            locate.Add(new List<string>() {Rm5, Rm2, End});
            locate.Add(new List<string>() {End});

            foreach (List<string> subList in locate)
            {
                foreach (string Room in subList)
                {                   
                    Console.WriteLine(Room);
                }
            }
        } */
    }

    public class FlavourText
    {
        string locate1 = "This is the starting room.";
        string locate2 = "This is the second room.";
        string locate3 = "This is the third room.";
        string locate4 = "This is the fourth room.";
        string locate5 = "This is the fifth room.";
        string locate6 = "This is the end.";
    }

    public class Room1
    {
        public string flavourText()
        {
            string locate1 = "This is the starting room.";
            return locate1;
        }

        public List<string> Attempt()
        {
             
        }
    }
}