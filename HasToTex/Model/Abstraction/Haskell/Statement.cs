namespace HasToTex.Model.Abstraction.Haskell
{
    /// <summary>
    /// Any kind of statement from Haskell
    /// </summary>
    public abstract class Statement
    {
        protected Statement (string code) => Code = code;

        /// <summary>
        /// The Haskell Code of this statement
        /// </summary>
        public string Code { get; }
    }
}