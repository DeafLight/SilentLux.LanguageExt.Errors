using FluentAssertions;
using SilentLux.AutoFixture.Moq.Xunit2;
using System;
using Xunit;
using static LanguageExt.Prelude;

namespace SilentLux.LanguageExt.Errors.Tests.ExceptionExtensions_Tests
{
    public class ExceptionExtensions_ToError
    {
        [Fact]
        public void Throws_when_exception_is_null()
        {
            act(() => ((Exception)null).ToError())
                .Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [AutoMoqData]
        public void Returns_an_error(Exception exception)
        {
            var res = exception.ToError();

            res.Should().BeOfType<ExceptionError>();
            res.Message.Should().Be(exception.Message);
        }
    }
}