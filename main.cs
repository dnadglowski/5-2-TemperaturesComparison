using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
   double MAX_TEMPS= 5;
  double sum = 0;
    
    
     List<double> templist = new List<double>(5);
   while(templist.Count< MAX_TEMPS) {
      Console.WriteLine("Input temp");
       double.TryParse(Console.ReadLine(), out double temp);
       if (temp >= -30 && temp <=130){
          templist.Add(temp);
         sum += temp;
         
         }else{
         Console.WriteLine("This tempature is outside of the range -30 to 130 degrees");
         }
    
     }
  double average = sum / 5;
    Console.WriteLine($"Five day average is {average} degress");
    Console.Write("5 day Temperature: ");
    Console.WriteLine(string.Join(", ", templist));
    
    bool gettingWarmer = true;
    bool gettingCooler = true;

    for (int i = 1; i < templist.Count; i++) {
        if (templist[i] <= templist[i - 1]) {
            gettingWarmer = false;
        }
        if (templist[i] >= templist[i - 1]) {
            gettingCooler = false;
        }
    }

    if (gettingWarmer) {
        Console.WriteLine("Getting warmer.");
    } else if (gettingCooler) {
        Console.WriteLine("Getting cooler.");
    } else {
        Console.WriteLine("It’s a mixed bag.");
      }
  }
}