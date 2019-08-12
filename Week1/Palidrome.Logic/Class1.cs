using System;

namespace Palidrome.Logic
{
    public class Class1
    {
    public string allPlain {get; set;}


    public bool findPlain(){
       string allLower = allPlain.ToLower();
       char[] newChar = allLower.ToCharArray();
       Array.Reverse(newChar);
       string temp = new string(newChar);
       return allLower.Equals(temp);

    }
      public Class1(string myPlain){
        this.allPlain = myPlain;
      }
    }
}
