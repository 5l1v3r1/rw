using System;
using System.Net;

namespace RW {
    public class Session {
        public readonly IPAddress Ip;
        
        public bool Active { get; protected set; }

        public Session() {
            this.Active = false;
        }

        public bool Connect() {
            // TODO: Implement.
            throw new NotImplementedException();
        }
    }
}
