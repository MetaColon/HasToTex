using System.Linq;


namespace HasToTex.Model
{
    public class HaskellProgram
    {
        public HaskellProgram (string content) => Content = content;
        public string Content { get; }

        public int  Length      => Content?.Length ?? 0;
        public char Get (int i) => Content [i];

        /// <summary>
        /// Trims every line. Note that this might alter multiline comments
        /// </summary>
        /// <returns></returns>
        public HaskellProgram Trim ()
        {
            var split    = Content.Split ('\n');
            var trimmed  = split.Select (s => s.Trim (' ', '\t'));
            var combined = string.Join ("\n", trimmed);
            return new HaskellProgram (combined);
        }

        /// <summary>
        /// Call <see cref="Trim"/> and appends one empty line at the end
        /// </summary>
        /// <returns>A normalized program</returns>
        public HaskellProgram Normalize () => new HaskellProgram (Trim ().Content + "\n");

        /// <inheritdoc />
        public override bool Equals (object obj)
            => obj != null && obj is HaskellProgram haskellProgram && Equals (haskellProgram);

        protected bool Equals (HaskellProgram other) => Content == other.Content;

        /// <inheritdoc />
        public override int GetHashCode () => (Content != null ? Content.GetHashCode () : 0);
    }
}