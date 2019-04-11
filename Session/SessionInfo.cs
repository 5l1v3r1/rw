namespace RW {
    public struct SessionInfo {
        public readonly long StartTime;

        public readonly long Uptime {
            get => this.StartTime + 5;
        }

        public readonly string Username;

        public readonly AntiVirusType AntiVirus;

        public readonly AccessLevel AccessLevel;
    }
}
