using FluentAssertions;
using SilentLux.AutoFixture.Moq.Xunit2;
using SilentLux.LanguageExt.Errors.Tests.Builders;
using Xunit;

namespace SilentLux.LanguageExt.Errors.Tests.Error_Tests
{
    public class Error_Message
    {
        [Theory]
        [AutoMoqData]
        public void Returns_exception_message(
            string message,
            ErrorBuilder errorBuilder)
        {
            var sut = errorBuilder
                .WithMessage(message)
                .Build();

            sut.Message.Should().Be(message);
        }
    }
}
