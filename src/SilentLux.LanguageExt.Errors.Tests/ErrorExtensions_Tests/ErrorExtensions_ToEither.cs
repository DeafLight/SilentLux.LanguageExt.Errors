using FluentAssertions;
using LanguageExt;
using LanguageExt.UnitTesting;
using SilentLux.AutoFixture.Moq.Xunit2;
using System;
using Xunit;
using static LanguageExt.Prelude;

namespace SilentLux.LanguageExt.Errors.Tests.ErrorExtensions_Tests
{
    public class ErrorExtensions_ToEither
    {
        [Fact]
        public void Throws_when_error_is_null()
        {
            act(() => ((IError)null).ToEither())
                .Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [AutoMoqData]
        public void Returns_an_either_containing_the_error(IError error)
        {
            var res = error.ToEither();

            ((Either<IError, object>)res).ShouldBeLeft(e =>
                e.Should().Be(error)
            );
        }
    }
}