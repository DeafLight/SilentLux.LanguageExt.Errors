using System;

namespace SilentLux.LanguageExt.Errors
{
    public class ExceptionError : IError
    {
        private readonly Exception _exception;

        public string Message => _exception.Message;

        private ExceptionError(Exception exception)
        {
            _exception = exception ??
                throw new ArgumentNullException(nameof(exception));
        }

        public static ExceptionError New(Exception exception) =>
            new ExceptionError(exception);
    }
}