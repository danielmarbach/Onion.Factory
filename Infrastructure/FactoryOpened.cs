namespace Onion.Factory
{
    using System;

    using Onion.Factory.Core.Domain;

    public class FactoryOpened : IFactoryOpened
    {
        public DateTimeOffset At()
        {
            return SystemClock.Now();
        }
    }
}