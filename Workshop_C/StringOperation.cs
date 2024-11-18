namespace Workshop_C;

public class StringOperation
{
   
    //Concatenate 2 strings with a space among it
   public string concat2trings(string txt1, string txt2)
    {
        return txt1+" "+txt2;
    }

   //Return the chars in the string
    public int charsInString(string txt1)
    {
        int contadorchar = 0;

        foreach (char character in txt1)
        {
            contadorchar++;
        }
        return contadorchar;
    }
    
    //return the letters in the string
    public int lettersInString(string txt)
    {
        txt = txt.ToLower();
        int letterCount = 0;

        foreach (char c in txt)
        {
            if (Char.IsLetter(c))
            {
                letterCount++;
            }
        }
        return letterCount;
    }
    
    //Count the uppercase letters in a String
    public int upperInString(string txt)
    {
        int uppercounter = 0;

        foreach (char c in txt)
        {
            if (Char.IsUpper(c))
            {
                uppercounter++;
            }
        }
        return uppercounter;
   
    }
    
    //count the times a char appears in the string (upper and lower)
    public int charInString(string txt, char a)
    {
        txt = txt.ToLower();
        int contador = 0;

        foreach (char c in txt)
        {
            if (c == a)
            {
                contador++;
            }
        }
        
        return contador;
    }
   
    //Reverse string
    public string reverseString(string txt)
    {
        char[] reversa = txt.ToCharArray();
        Array.Reverse(reversa);
        return new string(reversa);
 
    }
    
    //Is palindrome?
    public bool isPalindrome(string txt)
    {
        string txt2 = txt.ToLower().Replace(" ", "");
        
        char[] charArray = txt2.ToCharArray();
        Array.Reverse(charArray);
        string reversa = new string(charArray);
        
        return txt2 == reversa;
        
    }
    
    //substring in string
    public int substring(string txt, string substring)
    {
        int count = 0;
        int startIndex = 0;

        while ((startIndex = txt.IndexOf(substring, startIndex)) != -1)
        {
            count++;
            startIndex += substring.Length; 
        }

        return count;
    }
}
