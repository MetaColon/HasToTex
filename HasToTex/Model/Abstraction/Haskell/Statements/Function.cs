using System.Collections.Generic;
using System.Linq;

using HasToTex.Model.Exceptions;


namespace HasToTex.Model.Abstraction.Haskell.Statements
{
    /// <summary>
    /// A function declaration, like f x y = x + y
    /// Note that the function is not treat like returning a function (i.e. not how it actually works, like
    ///     f :: a -> b -> c, but rather like f :: a, b -> c
    /// Also note that we interpret all functions as prefix functions and later use infix notations when appropriate
    /// </summary>
    public class Function : Statement
    {
        /// <inheritdoc />
        public Function (string code, string name, List <string> parameters, Statement body) : base (code)
        {
            if (!code.Contains ("=") ||
                !code.Contains (name) ||
                parameters.Any (p => !code.Contains (p)) ||
                !code.Contains (body.Code))
                throw new InvalidCodeException (code, Expected);
            Name       = name;
            Parameters = parameters;
            Body       = body;
        }

        public string        Name       { get; }
        public List <string> Parameters { get; }
        public Statement     Body       { get; }

        private static string Expected { get; } = "[f] [x1] [x_2] ... = [y]";
    }
}