
int[] PlusOne(int[] digits)
{
    char[] sym = new char[] { };
    long num = 0;
    int k = 0;
    int[] digit2 = new int[] {};



    int l = 0;
    string str = "";
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string str6 = "";

    int enter1 = 0;
    int enter2 = 0;
    int enter3 = 0;
    int enter4 = 0;
    int enter5 = 0;
    int enter6 = 0;

    char firstChar = '0';
    string numString = "";

    



    

    int[] newDigits = new int[] { };


    for (int i = 0; i < digits.Length; i++)
    {
        if (i < 16)
        {
            str1 = str1 + digits[i].ToString();
            enter1 = 1;
        }

        if (i > 15 & i < 34)
        {
            str2 = str2 + digits[i].ToString();
            enter2 = 1;
        }
        else if (i > 33 & i < 52)
        {
            str3 = str3 + digits[i].ToString();
            enter3 = 1;
        }
        else if (i > 51 & i < 70)
        {
            str4 = str4 + digits[i].ToString();
            enter4 = 1;
        }
        else if (i > 69 & i < 88)
        {
            str5 = str5 + digits[i].ToString();
            enter5 = 1;
        }
        else if (i > 87 & i < 101)
        {
            str6 = str6 + digits[i].ToString();
            enter6 = 1;
        }

    }
    l = enter1 + enter2 + enter3 + enter4 + enter5 + enter6;
    switch (l)
    {
        case 1:
            if (firstChar == str1[0])
            {
                if(digits.Length == 1)
                {
                    return digit2 = new int[]{ 1 };
                }
                
                num = long.Parse(str1) + 1;
                numString = "0" + num.ToString();
                sym = numString.ToCharArray();
            }
            else
            {
                num = long.Parse(str1) + 1;
                sym = num.ToString().ToCharArray();
            }
            
            break;
        case 2:
            if (firstChar == str2[0])
            {
                num = long.Parse(str2) + 1;
                numString = str1 + "0" + num.ToString();
                sym = numString.ToCharArray();
            }
            else
            {
                num = long.Parse(str2) + 1;
                str = str1 + num.ToString();
                sym = str.ToCharArray();
               
            }
             break;
        case 3:
            if (firstChar == str3[0])
            {
                num = long.Parse(str3) + 1;
                numString = str1 + str2 + "0" + num.ToString();
                sym = numString.ToCharArray();
            }
            else
            {
                num = long.Parse(str3) + 1;
                str = str1 + str2 + num.ToString();
                sym = str.ToCharArray();
            }

           
            break;
        case 4:
            if (firstChar == str4[0])
            {
                num = long.Parse(str4) + 1;
                numString = str1 + str2 + str3 + "0" + num.ToString();
                sym = numString.ToCharArray();
            }
            else
            {
                num = long.Parse(str4) + 1;
                str = str1 + str2 + str3 + num.ToString();
                sym = str.ToCharArray();
            }
            
            break;
        case 5:
            if (firstChar == str5[0])
            {
                num = long.Parse(str5) + 1;
                numString = str1 + str2 + str3 + str4 + "0" + num.ToString();
                sym = numString.ToCharArray();
            }
            else
            {
                num = long.Parse(str5) + 1;
                str = str1 + str2 + str3 + str4 + num.ToString();
                sym = str.ToCharArray();
            }
            
            break;
        case 6:
            if (firstChar == str6[0])
            {
                num = long.Parse(str6) + 1;
                numString = str1 + str2 + str3 + str4 + str5 + "0" + num.ToString();
                sym = numString.ToCharArray();
            }
            else
            {
                num = long.Parse(str6) + 1;
                str = str1 + str2 + str3 + str4 + str5 + num.ToString();
                sym = str.ToCharArray();
            }
           
            break;
    }




    k = sym.Length;
    digit2 = new int[k];

    for (int i = 0; i < digit2.Length; i++)
    {
        digit2[i] = int.Parse(string.Concat(sym[i]));
    }
    return digit2;




}

Console.WriteLine();
int[] num = new int[] { 1, 2, 3 };
Console.WriteLine($"Number out:{PlusOne(num)}");