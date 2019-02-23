using LanguageExt;
using static LanguageExt.Prelude;

namespace SilentLux.LanguageExt.Errors
{
    public static class ErrorExtensions
    {
        public static EitherLeft<IError> ToEither(this IError error) =>
            Left(error);
    }
}