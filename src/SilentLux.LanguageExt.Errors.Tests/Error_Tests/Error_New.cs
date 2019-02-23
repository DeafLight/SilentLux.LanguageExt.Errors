using FluentAssertions;
using SilentLux.AutoFixture.Moq.Xunit2;
using System;
using Xunit;
using static LanguageExt.Prelude;

namespace SilentLux.LanguageExt.Errors.Tests.Error_Tests
{
    public class Error_New
    {
        [Fact]
        public void Throws_if_message_is_null()
        {
            act(() => Error.New(null))
                .Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [AutoMoqData]
        public void Generates_an_instance_if_message_is_not_null(string message)
        {
            var res = Error.New(message);

            res.Should().NotBeNull();
        }
    }
}
