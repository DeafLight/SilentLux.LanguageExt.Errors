using FluentAssertions;
using SilentLux.AutoFixture.Moq.Xunit2;
using System;
using Xunit;
using static LanguageExt.Prelude;

namespace SilentLux.LanguageExt.Errors.Tests.ExceptionError_Tests
{
    public class ExceptionError_New
    {
        [Fact]
        public void Throws_if_message_is_null()
        {
            act(() => ExceptionError.New(null))
                .Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [AutoMoqData]
        public void Generates_an_instance_if_exception_is_not_null(Exception exception)
        {
            var res = ExceptionError.New(exception);

            res.Should().NotBeNull();
        }
    }
}
