using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sharpshooter
{
    [TestFixture]
    public class Variance
    {
        [Test]
        public void Test1()
        {
            Herd<Zebra> zebras = new Herd<Zebra>();
            ICollective<Zebra> zebras2 = new Herd<Zebra>();

        }
    }

    // herd	of	zebras

    public interface ICollective<T>
    {
        int Count { get; set; }
    }

    public class Herd<T> : ICollective<T> { }
    public class Zebra { }
}
