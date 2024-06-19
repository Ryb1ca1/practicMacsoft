using System;
public class Kata
{
    public static bool isAValidMessage(string message) 
    {

        if (message == "") return true;
            bool result=false;

        char[] separatorsCh = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',' ' };
        char[] separatorsN = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',' ' };

        string[] subsCh = message.Split(separatorsCh, StringSplitOptions.RemoveEmptyEntries);
        string[] subsN = message.Split(separatorsN, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < subsN.Length; i++)
        {
            if (subsN[i].Length >=3)
            {
                return false;
            }
            
            
        }

        if (subsCh.Length == subsN.Length)
        {
            for (int i = 0; i < subsCh.Length; i++)
            {
                if (subsCh[i].Length == Convert.ToInt32(subsN[i]) && subsCh.Length == subsN.Length && message.Substring(0, subsCh[0].Length) != subsCh[0])
                {
                    result = true;
                }
                else result = false;
                //
            }

        }
            else result = false;


        return result;
    }
}