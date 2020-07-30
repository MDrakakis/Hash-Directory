using System;

namespace HashDirectory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.SetWindowSize(140, 35);
      MainMenu menu = new MainMenu();
      menu.WelcomeMenu();
    }
  }
}
