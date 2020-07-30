using System;

namespace HashDirectory
{
  class PrintByteArray
  {
    // Display the byte array in a readable format.
    public static void Print(byte[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]:X2}");
        if ((i % 4) == 3) Console.Write("");
      }
      Console.WriteLine();
    }
  }
}
