namespace Onion.Factory
{
    using System;

    public static class SystemClock
    {
        static SystemClock()
        {
            Provider = () => DateTimeOffset.Now;
        }

        public static Func<DateTimeOffset> Provider { get; set; }

        public static DateTimeOffset Now()
        {
            return Provider();
        }
    }
}