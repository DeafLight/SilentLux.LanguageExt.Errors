using AutoFixture;
using SilentLux.AutoFixture.Builders;

namespace SilentLux.LanguageExt.Errors.Tests.Builders
{
    public class ErrorBuilder :
        Builder<ErrorBuilder, Error>
    {
        private string _message;

        public ErrorBuilder(IFixture fixture) :
            base(fixture)
        {
            _message = fixture.Create<string>();
        }

        public ErrorBuilder WithMessage(string message) =>
            With(() => _message = message);

        protected override Error NewInstance() =>
            Error.New(_message);
    }
}