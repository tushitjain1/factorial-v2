using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(fact(9));
  }
  public static int fact(int number){
    if (number != 1){
      number = number*fact(number-1);
      return number;
    }
    else {
      return number;
    }
  }
}