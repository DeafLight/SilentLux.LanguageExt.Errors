using System;

namespace SilentLux.LanguageExt.Errors
{
    public class Error : IError
    {
        public string Message { get; }

        private Error(string message)
        {
            Message = message ??
                throw new ArgumentNullException(nameof(message));
        }

        public static Error New(string message) =>
            new Error(message);
    }
}