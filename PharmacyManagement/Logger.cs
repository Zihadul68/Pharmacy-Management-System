using System;
using System.IO;

namespace PharmacyManagement
{
    internal static class Logger
    {
        private static readonly object SyncRoot = new object();
        private static readonly string LogPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "PharmacyManagement",
            "pharmacy-management.log");

        internal static void Error(string message, Exception exception)
        {
            try
            {
                lock (SyncRoot)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(LogPath));
                    File.AppendAllText(LogPath,
                        string.Format("{0:u} ERROR {1}: {2}{3}", DateTime.UtcNow, message, exception, Environment.NewLine));
                }
            }
            catch (IOException)
            {
                // Logging must never prevent the application from reporting its original error.
            }
            catch (UnauthorizedAccessException)
            {
                // Logging must never prevent the application from reporting its original error.
            }
        }
    }
}
