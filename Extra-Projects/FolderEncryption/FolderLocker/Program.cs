using System.Collections;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

namespace FolderLocker;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("=== Secure Folder Locker ===");

        Console.Write("Enter the full folder path: ");
        var folderPath = Console.ReadLine();

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Error: The specified folder does not exist.");
            return;
        }

        Console.Write("Enter password: ");
        var password = Console.ReadLine();

        Console.Write("Do you want to (L)ock or (U)nlock the folder? ");
        var choice = Console.ReadLine()?.ToUpper();

        if (choice == "L")
        {
            LockFolder(folderPath, password);
            Console.WriteLine($"Folder Locked: {folderPath}");
        }
        else if (choice == "U")
        {
            UnlockFolder(folderPath, password);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }

    [SupportedOSPlatform("windows")]
    private static void LockFolder(string folderPath, string password)
    {
        SavePasswordHash(folderPath, password);

        var directoryInfo = new DirectoryInfo(folderPath);
        var security = directoryInfo.GetAccessControl();

        var everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
        security.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl, AccessControlType.Deny));

        directoryInfo.SetAccessControl(security);

        Console.WriteLine($"Folder Locked: {folderPath}");
    }


    [SupportedOSPlatform("windows")]
    private static void UnlockFolder(string folderPath, string password)
    {
        var hashFile = Path.Combine(folderPath, "password.lock");

        if (!File.Exists(hashFile))
        {
            Console.WriteLine("No password file found. The folder might not be locked.");
            return;
        }

        if (!VerifyPassword(folderPath, password))
        {
            Console.WriteLine("Incorrect password! Access Denied.");
            return;
        }

        var directoryInfo = new DirectoryInfo(folderPath);
        var security = directoryInfo.GetAccessControl();

        var everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
        security.RemoveAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl, AccessControlType.Deny));

        directoryInfo.SetAccessControl(security);

        File.Delete(hashFile);
        Console.WriteLine($"Folder Unlocked: {folderPath}");
        Console.WriteLine("Password file deleted for security.");
    }

    private static void SavePasswordHash(string folderPath, string password)
    {
        var hash = GenerateHash(password);
        File.WriteAllBytes(Path.Combine(folderPath, "password.lock"), hash);
    }

    private static bool VerifyPassword(string folderPath, string inputPassword)
    {
        var hashFile = Path.Combine(folderPath, "password.lock");
        if (!File.Exists(hashFile)) return false;

        var storedHash = File.ReadAllBytes(hashFile);
        var inputHash = GenerateHash(inputPassword);

        return StructuralComparisons.StructuralEqualityComparer.Equals(storedHash, inputHash);
    }

    private static byte[] GenerateHash(string password)
    {
        using var sha256 = System.Security.Cryptography.SHA256.Create();
        return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}