using AutoFixture;
using SilentLux.AutoFixture.Builders;
using System;

namespace SilentLux.LanguageExt.Errors.Tests.Builders
{
    public class ExceptionErrorBuilder :
        Builder<ExceptionErrorBuilder, ExceptionError>
    {
        private Exception _exception;

        public ExceptionErrorBuilder(IFixture fixture) :
            base(fixture)
        {
            _exception = fixture.Create<Exception>();
        }

        public ExceptionErrorBuilder WithException(Exception exception) =>
            With(() => _exception = exception);

        protected override ExceptionError NewInstance() =>
            ExceptionError.New(_exception);
    }
}