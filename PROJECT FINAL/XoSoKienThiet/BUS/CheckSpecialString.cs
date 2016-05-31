using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XoSoKienThiet.BUS
{
    public class CheckSpecialString
    {
        public static bool KT_ChuoiKiTuDacBiet(string _chuoi)
        {
            string schuoi = converToUnsign1(Convert.ToString(_chuoi));
            if (schuoi != "")
                foreach (char s in schuoi)
                {
                    bool b = Regex.IsMatch(Convert.ToString(s), @"[a-z A-Z]");
                    if (b == false)
                        return false;
                }
            return true;
        }

        public unsafe static string converToUnsign1(string s)
        {
            string[] pattern = {"(á|à|ả|ã|ạ|ă|ắ|ằ|ẳ|ẵ|ặ|â|ấ|ầ|ẩ|ẫ|ậ)",
                   "đ",
                   "(é|è|ẻ|ẽ|ẹ|ê|ế|ề|ể|ễ|ệ)",
                   "(í|ì|ỉ|ĩ|ị)",
                   "(ó|ò|ỏ|õ|ọ|ô|ố|ồ|ổ|ỗ|ộ|ơ|ớ|ờ|ở|ỡ|ợ)",
                   "(ú|ù|ủ|ũ|ụ|ư|ứ|ừ|ử|ữ|ự)",
                   "(ý|ỳ|ỷ|ỹ|ỵ)"};
            char[] replaceChar = { 'a', 'd', 'e', 'i', 'o', 'u', 'y', 'A', 'D', 'E', 'I', 'O', 'U', 'Y' };

            fixed (char* ptrChar = replaceChar)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    MatchCollection matchs = Regex.Matches(s, pattern[i], RegexOptions.IgnoreCase);
                    foreach (Match m in matchs)
                    {
                        char ch = char.IsLower(m.Value[0]) ? *(ptrChar + i) : *(ptrChar + i + 7);
                        s = s.Replace(m.Value[0], ch);
                    }
                }
            }
            return s;
        }
    }
}
