using System;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            //sut: system under test
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }
    }
}
