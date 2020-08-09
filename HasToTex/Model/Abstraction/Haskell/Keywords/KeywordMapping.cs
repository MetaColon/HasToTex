using System.Collections.Generic;


namespace HasToTex.Model.Abstraction.Haskell.Keywords
{
    public static class KeywordMapping
    {
        public static Dictionary <string, KeywordEnum> KeywordToEnum = new Dictionary <string, KeywordEnum>
        {
            {"!", KeywordEnum.S_Exclamation},
            {"'", KeywordEnum.S_SingleQuote},
            {"\"", KeywordEnum.S_DoubleQuote},
            {"-", KeywordEnum.S_Dash},
            {"--", KeywordEnum.S_DoubleDash},
            {"-<", KeywordEnum.S_DashLt},
            {"-<<", KeywordEnum.S_DashDoubleLt},
            {"->", KeywordEnum.S_DashGt},
            {"::", KeywordEnum.S_DoubleColon},
            {";", KeywordEnum.S_Semicolon},
            {"<-", KeywordEnum.S_LtDash},
            {",", KeywordEnum.S_Comma},
            {"=", KeywordEnum.S_Equals},
            {"=>", KeywordEnum.S_EqualsGt},
            {">", KeywordEnum.S_Gt},
            {"?", KeywordEnum.S_Question},
            {"#", KeywordEnum.S_Hash},
            {"*", KeywordEnum.S_Star},
            {"@", KeywordEnum.S_At},
            {"[|,|]", KeywordEnum.S_BracketsPipes},
            {"\\", KeywordEnum.S_Backslash},
            {"_", KeywordEnum.S_Underscore},
            {"`", KeywordEnum.S_Apostrophe},
            {"{,}", KeywordEnum.S_Braces},
            {"{-,-}", KeywordEnum.S_BracesDashes},
            {"|", KeywordEnum.S_Pipe},
            {"~", KeywordEnum.S_Tilde},
            {"as", KeywordEnum._as},
            {"case", KeywordEnum._case},
            {"of", KeywordEnum._of},
            {"class", KeywordEnum._class},
            {"data", KeywordEnum._data},
            {"data family", KeywordEnum._data_family},
            {"data instance", KeywordEnum._data_instance},
            {"default", KeywordEnum._default},
            {"deriving", KeywordEnum._deriving},
            {"deriving instance", KeywordEnum._deriving_instance},
            {"do", KeywordEnum._do},
            {"forall", KeywordEnum._forall},
            {"foreign", KeywordEnum._foreign},
            {"hiding", KeywordEnum._hiding},
            {"if", KeywordEnum._if},
            {"then", KeywordEnum._then},
            {"else", KeywordEnum._else},
            {"import", KeywordEnum._import},
            {"infix", KeywordEnum._infix},
            {"infixl", KeywordEnum._infixl},
            {"infixr", KeywordEnum._infixr},
            {"instance", KeywordEnum._instance},
            {"let", KeywordEnum._let},
            {"in", KeywordEnum._in},
            {"mdo", KeywordEnum._mdo},
            {"module", KeywordEnum._module},
            {"newtype", KeywordEnum._newtype},
            {"proc", KeywordEnum._proc},
            {"qualified", KeywordEnum._qualified},
            {"rec", KeywordEnum._rec},
            {"type", KeywordEnum._type},
            {"type family", KeywordEnum._type_family},
            {"type instance", KeywordEnum._type_instance},
            {"where", KeywordEnum._where}
        };
    }
}