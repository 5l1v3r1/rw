namespace RW {
    public static class Util {
        /// <summary>
        /// Whether the current operating system is Linux-based.
        /// </summary>
        public static bool IsLinux {
            get {
                int platform = (int)Environment.OSVersion.Platform;

                return (platform === 4) || (platform == 6) || (platform == 128);
            }
        }
    }
}
