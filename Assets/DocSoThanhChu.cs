using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class DocSoThanhChu
    {
       public static string NumberToWords(int number)
        {
            if (number == 0)
                return "không";

            if (number < 0)
                return "âm " + NumberToWords(Math.Abs(number));

            string[] unitsMap = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tensMap = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " tỷ ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "lẻ ";

                if (number < 10)
                    words += unitsMap[number];
                else if (number < 20)
                {
                    if (number == 15)
                        words += "mười lăm";
                    else
                        words += "mười " + unitsMap[number % 10];
                }
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                    {
                        if (number % 10 == 1)
                            words += " mốt";
                        else if (number % 10 == 5)
                            words += " lăm";
                        else
                            words += " " + unitsMap[number % 10];
                    }
                }
            }

            return words.Trim();
        }
    }
}
