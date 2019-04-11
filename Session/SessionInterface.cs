using System;

namespace RW {
    public class SessionInterface {
        public bool InLoop { get; protected set; }
        
        public string Prompt { get; set; }

        protected SessionTransport transport;

        public SessionInterface() {
            this.transport = new SessionTransport();
            this.Prompt = "> ";
        }

        public void BeginLoop() {
            // Reset the loop if applicable.
            if (this.InLoop) {
                this.EndLoop();
            }

            // Set the loop flag.
            this.InLoop = true;

            // Begin the input loop.
            while (this.InLoop) {
                // Write the prompt string.
                Console.Write(this.Prompt);

                // Read command/input.
                string input = Console.ReadLine();

                // Do not accept empty strings.
                if (String.IsNullOrEmpty(input)) {
                    continue;
                }

                // Execute the command.
                string output = this.transport.Run(input);

                // Display the output.
                Console.Write(output);
            }
        }

        public void EndLoop() {
            // Do not continue if loop has not begun.
            if (!this.InLoop) {
                return;
            }

            this.InLoop = false;
        }
    }
}
