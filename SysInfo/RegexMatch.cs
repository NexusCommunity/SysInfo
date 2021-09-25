using System;
using System.Text.RegularExpressions;

namespace SysInfo
{
    internal class RegexMatch<T>
    {
        internal readonly Regex Regex;
        internal Action<string> Update;

        public RegexMatch(object pattern, Action<string> onUpdate)
        {
            Regex = new Regex(pattern.ToString(), RegexOptions.Compiled);
            Update = onUpdate;
        }
    }
}
