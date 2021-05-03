using System;

namespace NumberReplacement.PingPong {

  public class Input {
    private string _inputNumber;

    public int GetInputNumber()
    {
      Console.WriteLine("Pick a Number!");
      _inputNumber = Console.ReadLine();
      int inputInteger = int.Parse(_inputNumber);
      return inputInteger;

    }
  }
}