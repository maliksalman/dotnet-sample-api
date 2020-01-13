using System;

namespace SampleApi
{
    public class Payload
    {
        public DateTime time { get; set; }

        public string host { get; set; }

        public string msg { get; set; }

        public Payload(DateTime t, string h, string m) {
            time = t;
            host = h;
            msg = m;
        }
    }
}