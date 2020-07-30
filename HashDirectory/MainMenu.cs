using System;
using System.IO;

namespace HashDirectory
{
  class MainMenu
  {
    public void WelcomeMenu()
    {
      bool menu = true;
      while (menu)
      {
        string directory;
        string userInput;

        Console.Clear();
        Console.Write(Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(@"  
         __      __       .__                               ._.
        /  \    /  \ ____ |  |   ____  ____   _____   ____  | |
        \   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \ | |
         \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/ | |
          \__/\  /  \___  >____/\___  >____/|__|_|  /\___ > |_|
               \/       \/          \/            \/     \/ 
                                                            [ ]
        ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Use Current directory? (Y/N): ");
        userInput = Console.ReadLine().ToUpper();
        if (userInput == "Y")
        {
          directory = Environment.CurrentDirectory;
          Menu(directory);
        }
        else if (userInput == "N")
        {
          Console.Write("Please enter the full directory path: ");
          directory = Console.ReadLine();
          if (Directory.Exists(directory))
          {
            Console.Clear();
            Menu(directory);
          }
          else
          {
            Console.WriteLine("The directory doesn't exist.");
            Console.Write("Please enter the full directory path: ");
            directory = Console.ReadLine().ToUpper();
            if (Directory.Exists(directory))
            {
              Console.Clear();
              Menu(directory);
            }
            else
            {
              Console.WriteLine("Current directory will be used!...");
              Console.WriteLine("Press any key to continue");
              Console.ReadLine();
              Console.Clear();
              Menu(Environment.CurrentDirectory);
            }
          }
        }
        else
        {
          Console.WriteLine("Current directory will be used!...");
          Console.WriteLine("Press any key to continue");
          Console.ReadLine();
          Console.Clear();
          Menu(Environment.CurrentDirectory);
        }
      }
    }

    public void Menu(string directory)
    {
      Console.Clear();
      Console.Write(Environment.NewLine);
      Console.ForegroundColor = ConsoleColor.DarkGray;
      Console.Write($" Directory used: ");
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.Write($"{ directory}");
      Console.Write(Environment.NewLine);
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write(Environment.NewLine);
      Console.WriteLine(" 1. Display MD5 hashes.");
      Console.WriteLine(" 2. Display SHA-1 hashes.");
      Console.WriteLine(" 3. Display SHA-256 hashes.");
      Console.WriteLine(" 4. Display SHA-512 hashes.");
      Console.WriteLine(" 5. Return to Main Menu.");
      Console.WriteLine(" Q. Press (Q) to exit...");
      Console.WriteLine(" ============================= ");
      Console.Write(" > ");
      string userInput = Console.ReadLine().ToUpper();
      SwitchMenu(userInput, directory);
    }

    public void SwitchMenu(string userInput, string directory)
    {
      ComputeHash computeHash = new ComputeHash();

      switch (userInput)
      {
        case "1":
          Console.Clear();
          Console.WriteLine(Environment.NewLine);
          computeHash.ReturnMD5(directory);
          Console.Write(Environment.NewLine);
          Console.Write("Press any key to continue...");
          Console.ReadLine();
          break;
        case "2":
          Console.Clear();
          Console.WriteLine(Environment.NewLine);
          computeHash.ReturnSHA1(directory);
          Console.Write(Environment.NewLine);
          Console.Write("Press any key to continue...");
          Console.ReadLine();
          break;
        case "3":
          Console.Clear();
          Console.WriteLine(Environment.NewLine);
          computeHash.ReturnSHA256(directory);
          Console.Write(Environment.NewLine);
          Console.Write("Press any key to continue...");
          Console.ReadLine();
          break;
        case "4":
          Console.Clear();
          Console.WriteLine(Environment.NewLine);
          computeHash.ReturnSHA512(directory);
          Console.Write(Environment.NewLine);
          Console.Write("Press any key to continue...");
          Console.ReadLine();
          break;
        case "5":
          Console.Clear();
          WelcomeMenu();
          break;
        case "Q":
          Environment.Exit(0);
          break;
        default:
          Console.WriteLine(Environment.NewLine);
          Console.WriteLine("Please give a correct menu item...");
          Console.ReadLine();
          break;
      }
    }
  }
}
