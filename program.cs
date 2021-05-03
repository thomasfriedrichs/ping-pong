using System;
using NumberReplacement.PingPong;

namespace NumberReplacement {
  public class Program {
    
    public static void Main(){
      Input userInput = new Input();
      int inputInteger = userInput.GetInputNumber();

      for (int i = 1; i <= inputInteger; i++)
      {
        if ((i % 5 == 0) && (i % 3 == 0)) {
          Console.WriteLine("Ping-Pong");
        } else if (i % 5 == 0) {
          Console.WriteLine("Pong");
        } else if (i % 3 == 0) {
          Console.WriteLine("Ping");
        } else {
          Console.WriteLine(i);
        }
      }

    }
  }
}