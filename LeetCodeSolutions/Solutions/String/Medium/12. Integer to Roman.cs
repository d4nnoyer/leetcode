using System.Text;

namespace LeetCodeSolutions.Solutions.String.Medium;

public static class Integer_to_Roman {
    
    public static string IntToRoman(int num)
    {
        var sb = new StringBuilder();

        if (num >= 1000) {
            sb.Append('M', num / 1000); num %= 1000;
        }
        if (num >= 900)
        {
            sb.Append("CM"); num -= 900;
        }
        if (num >= 500) {
            sb.Append('D'); num -= 500;
        }
        if (num >= 400) {
            sb.Append("CD"); num -= 400;
        }
        if (num >= 100) {
            sb.Append('C', num / 100); num %= 100;
        }
        if (num >= 90) {
            sb.Append("XC"); num -= 90;
        }
        if (num >= 50) {
            sb.Append('L'); num -= 50;
        }
        if (num >= 50) {
            sb.Append('L'); num -= 50;
        }
        if (num >= 40) {
            sb.Append("XL"); num -= 40;
        }
        if (num >= 10) {
            sb.Append('X', num / 10); num %= 10;
        }
        if (num == 9) {
            sb.Append("IX"); num = 0;
        }
        if (num >= 5) {
            sb.Append('V'); num %= 5;
        }
        if (num == 4) {
            sb.Append("IV"); num = 0;
        }
        if (num > 0) 
            sb.Append('I', num / 1);
        
        return sb.ToString();
    }
}