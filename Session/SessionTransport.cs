using System;

namespace RW {
    public class SessionTransport {
        public SessionTransport() {

        }

        /// <summary>
        /// Run a command and retrieve its output.
        /// </summary>
        public string Run(string command) {
            Process process = new Process();

            // Prepare process.
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            // Do not show any window.
            process.StartInfo.CreateNoWindow = true;
            process.WindowStyle = ProcessWindowStyle.Hidden;

            // Use command prompt if in Windows.
            if (!Util.IsLinux) {
                process.StartInfo.FileName = "cmd.exe";
            }
            // Otherwise use a Linux shell.
            else {
                // TODO: Implement.
                throw new NotImplementedException();
            }

            // Run the process.
            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            process.WaitForExit();

            return output;
        }
    }
}
