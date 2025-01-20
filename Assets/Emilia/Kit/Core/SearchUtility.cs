#if UNITY_EDITOR
namespace Emilia.Kit
{
    public static class SearchUtility
    {
        /// <summary>
        /// 字符串搜索
        /// </summary>
        public static bool Search(string target, string input, bool nullResult = true, bool ignoreCase = true)
        {
            if (string.IsNullOrEmpty(input)) return nullResult;

            if (ignoreCase == false) return Bdt(target, input);

            target = target.ToLower();
            input = input.ToLower();
            return Bdt(target, input);
        }

        /// <summary>
        /// 模糊搜索
        /// </summary>
        public static bool Bdt(string text, string str)
        {
            int i = 0;
            bool result = false;

            int strLength = str.Length;
            for (var j = 0; j < strLength; j++)
            {
                var temp = str[j];
                result = false;

                for (; i < text.Length; i++)
                {
                    if (temp != text[i]) continue;

                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
#endif