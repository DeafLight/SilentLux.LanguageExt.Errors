using FluentAssertions;
using SilentLux.AutoFixture.Moq.Xunit2;
using SilentLux.LanguageExt.Errors.Tests.Builders;
using System;
using Xunit;

namespace SilentLux.LanguageExt.Errors.Tests.ExceptionError_Tests
{
    public class ExceptionError_Message
    {
        [Theory]
        [AutoMoqData]
        public void Returns_exception_message(
            Exception exception,
            ExceptionErrorBuilder exceptionErrorBuilder)
        {
            var sut = exceptionErrorBuilder
                .WithException(exception)
                .Build();

            sut.Message.Should().Be(exception.Message);
        }
    }
}
