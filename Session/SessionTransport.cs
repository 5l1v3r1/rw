using System;
using System.Diagnostics;

namespace RW {
    public class SessionTransport {
        public SessionTransport() {
            // TODO
        }

        /// <summary>
        /// Run a command and retrieve its output.
        /// </summary>
        public string Run(string command) {
            Process process = new Process();

            // Escape command.
            string escapedCommand = command.Replace("\"", "\\\"");

            // Prepare process.
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            // Do not show any window.
            process.StartInfo.CreateNoWindow = true;

            // Use command prompt if in Windows.
            if (!Util.IsLinux) {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c {escapedCommand}";
            }
            // Otherwise use a Linux shell (Bash).
            else {
                process.StartInfo.FileName = "/bin/bash";
                process.StartInfo.Arguments = $"-c \"{escapedCommand}\"";
            }

            // Run the process.
            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            return output;
        }
    }
}
