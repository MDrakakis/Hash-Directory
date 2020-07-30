using Serilog;
using Serilog.Core;
using System;
using System.IO;
using System.Security.Cryptography;

namespace HashDirectory
{
  class ComputeHash
  {
    #region Logger

    /// <summary>
    /// Logger
    /// </summary>
    private Logger log = new LoggerConfiguration()
      .MinimumLevel.Debug()
      .WriteTo.Console()
      .WriteTo.File("C:\\ComputeHashErrorLog.txt", rollingInterval: RollingInterval.Day)
      .CreateLogger();

    #endregion Logger

    #region Computes

    /// <summary>
    /// Returns MD5 Hash. See
    /// <see cref="ComputeHash"/>
    /// for more details
    /// </summary>
    public void ReturnMD5(string directory)
    {

      // Create a DirectoryInfo object representing the specified directory.
      var dir = new DirectoryInfo(directory);
      // Get the FileInfo objects for every file in the directory.
      FileInfo[] files = dir.GetFiles();
      // Initialize a SHA256 hash object.
      using (MD5 mD5 = MD5.Create())
      {
        // Compute and print the hash values for each file in directory.
        foreach (FileInfo fInfo in files)
        {
          try
          {
            // Create a fileStream for the file.
            FileStream fileStream = fInfo.OpenRead();
            fileStream.Position = 0;

            // Compute the hash of the fileStream.
            byte[] hashValue = mD5.ComputeHash(fileStream);
            Console.Write($"{fInfo.Name}: ");
            PrintByteArray.Print(hashValue);

            fileStream.Close();
          }
          catch (IOException e)
          {
            log.Error($"I/O Exception: {e.Message}");
          }
          catch (UnauthorizedAccessException e)
          {
            log.Error($"Access Exception: {e.Message}");
          }
        }
      }
    }

    /// <summary>
    /// Returns SHA-1 Hash. See
    /// <see cref="ComputeHash"/>
    /// for more details
    /// </summary>
    public void ReturnSHA1(string directory)
    {
      // Create a DirectoryInfo object representing the specified directory.
      var dir = new DirectoryInfo(directory);
      // Get the FileInfo objects for every file in the directory.
      FileInfo[] files = dir.GetFiles();
      // Initialize a SHA256 hash object.
      using (SHA1 sha1 = SHA1.Create())
      {
        // Compute and print the hash values for each file in directory.
        foreach (FileInfo fInfo in files)
        {
          try
          {
            // Create a fileStream for the file.
            FileStream fileStream = fInfo.OpenRead();
            fileStream.Position = 0;

            // Compute the hash of the fileStream.
            byte[] hashValue = sha1.ComputeHash(fileStream);
            Console.Write($"{fInfo.Name}: ");
            PrintByteArray.Print(hashValue);

            fileStream.Close();
          }
          catch (IOException e)
          {
            log.Error($"I/O Exception: {e.Message}");
          }
          catch (UnauthorizedAccessException e)
          {
            log.Error($"Access Exception: {e.Message}");
          }
        }
      }
    }

    /// <summary>
    /// Returns SHA-256 Hash. See
    /// <see cref="ComputeHash"/>
    /// for more details
    /// </summary>
    public void ReturnSHA256(string directory)
    {
      // Create a DirectoryInfo object representing the specified directory.
      var dir = new DirectoryInfo(directory);
      // Get the FileInfo objects for every file in the directory.
      FileInfo[] files = dir.GetFiles();
      // Initialize a SHA256 hash object.
      using (SHA256 sha256 = SHA256.Create())
      {
        // Compute and print the hash values for each file in directory.
        foreach (FileInfo fInfo in files)
        {
          try
          {
            // Create a fileStream for the file.
            FileStream fileStream = fInfo.OpenRead();
            fileStream.Position = 0;

            // Compute the hash of the fileStream.
            byte[] hashValue = sha256.ComputeHash(fileStream);
            Console.Write($"{fInfo.Name}: ");
            PrintByteArray.Print(hashValue);

            fileStream.Close();
          }
          catch (IOException e)
          {
            log.Error($"I/O Exception: {e.Message}");
          }
          catch (UnauthorizedAccessException e)
          {
            log.Error($"Access Exception: {e.Message}");
          }
        }
      }
    }

    /// <summary>
    /// Returns SHA-512 Hash. See
    /// <see cref="ComputeHash"/>
    /// for more details
    /// </summary>
    public void ReturnSHA512(string directory)
    {
      // Create a DirectoryInfo object representing the specified directory.
      var dir = new DirectoryInfo(directory);
      // Get the FileInfo objects for every file in the directory.
      FileInfo[] files = dir.GetFiles();
      // Initialize a SHA256 hash object.
      using (SHA512 sha512 = SHA512.Create())
      {
        // Compute and print the hash values for each file in directory.
        foreach (FileInfo fInfo in files)
        {
          try
          {
            // Create a fileStream for the file.
            FileStream fileStream = fInfo.OpenRead();
            fileStream.Position = 0;

            // Compute the hash of the fileStream.
            byte[] hashValue = sha512.ComputeHash(fileStream);
            Console.Write($"{fInfo.Name}: ");
            PrintByteArray.Print(hashValue);

            fileStream.Close();
          }
          catch (IOException e)
          {
            log.Error($"I/O Exception: {e.Message}");
          }
          catch (UnauthorizedAccessException e)
          {
            log.Error($"Access Exception: {e.Message}");
          }
        }
      }
    }

    #endregion Computes
  }
}
