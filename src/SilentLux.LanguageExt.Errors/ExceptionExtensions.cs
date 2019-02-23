using System;

namespace SilentLux.LanguageExt.Errors
{
    public static class ExceptionExtensions
    {
        public static ExceptionError ToError(this Exception exception) =>
            ExceptionError.New(exception);
    }
}