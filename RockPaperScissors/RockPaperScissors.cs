using System;

using static System.Console;
class IfElseDecision
{
   static void Main()
   {
      WriteLine("Welcome to rock, paper, scissors game");
      WriteLine("Please choose one of the following options");
      WriteLine("1=rock, 2=paper, 3=scissors");
      Random ranNumberGenerator = new Random();
      int randomNumber;
      randomNumber = ranNumberGenerator.Next(1, 3);
      int rock = 1;
      int paper = 2;
      int scissors = 3;
      int UserDecision = Convert.ToInt32(ReadLine());
      if (UserDecision == randomNumber)
      {
         WriteLine("Tied game");
      }
      if ((UserDecision == rock) && randomNumber == scissors)
      {
         WriteLine("Win");
      }
      if ((UserDecision == paper) && randomNumber == rock)
      {
         WriteLine("Win");
      }
      if ((UserDecision == scissors) && randomNumber == paper)
      {
         WriteLine("Win");
      }
      if ((UserDecision == scissors) && randomNumber == rock)
      {
         WriteLine("Loose, try again");
      }
      if ((UserDecision == rock) && randomNumber == paper)
      {
         WriteLine("Loose, try again");
      }
      if ((UserDecision == paper) && randomNumber == scissors)
      {
         WriteLine("Loose, try again");
      }
   }
}