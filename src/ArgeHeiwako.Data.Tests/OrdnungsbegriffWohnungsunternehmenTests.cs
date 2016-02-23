﻿using Xunit;

namespace ArgeHeiwako.Data.Tests
{
    public class OrdnungsbegriffWohnungsunternehmenTests
    {
        [Fact]
        public void Ctor_TestString_ToStringLength20()
        {
            var ordnungsbegriff = new OrdnungsbegriffWohnungsunternehmen("TestString");
            Assert.Equal(20, ordnungsbegriff.ToString().Length);
        }

        [Fact]
        public void Ctor_TestString_ToStringEqualTestString10Spaces()
        {
            var ordnungsbegriff = new OrdnungsbegriffWohnungsunternehmen("TestString");
            Assert.Equal("TestString          ", ordnungsbegriff.ToString());
        }
    }
}
