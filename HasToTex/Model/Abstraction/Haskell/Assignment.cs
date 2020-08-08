using HasToTex.Model.Exceptions;


namespace HasToTex.Model.Abstraction.Haskell
{
    public class Assignment : Statement
    {
        /// <inheritdoc />
        public Assignment (string code, string name, Statement value) : base (code)
        {
            if (!code.Contains ("<-") ||
                !code.Contains (name) ||
                !code.Contains (Value.Code))
                throw new InvalidCodeException (code, Expected);
            Name  = name;
            Value = value;
        }

        private string    Name  { get; }
        private Statement Value { get; }

        private static string Expected = "[x] <- [y]";
    }
}