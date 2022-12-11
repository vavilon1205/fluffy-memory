
  int[] PlusOne(int[] digits) 
 {
    
    long num = 0;
    long num1 = 0;
    long num2 = 0;
    long num3 = 0;
    long num4 = 0;
    long num5 = 0;
    long num5 = 0;
    int l = 0;
    string str = "";
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string str6 = "";

    char[] sym = 


	
	int k = 0;
    
    int[] newDigits = new int[]{};


	for (int i = 0; i < digits.Length; i++)
	{
		if(i < 17)
        {
            str1 = str1 + digits[i].ToString();
            l++;
        }
       
        if(i > 16 & i < 35)
        {
            str2 = str1 + digits[i].ToString();
            l++;
        }
        else if(i > 34 & i < 53)
        {
            str3 = str1 + str2 + digits[i].ToString();
            l++;
        }
        else if(i > 52 & i < 71)
        {
            str4 = str1 + str2 + str3 + digits[i].ToString();
            l++;
        }
        else if(i > 70 & i < 89)
        {
            str5 = str1 + str2 + str3 + str4 + digits[i].ToString();
            l++;
        }
        else if(i > 88 & i < 101)
        {
            str6 = str1 + str2 + str3 + str4 + str5 + digits[i].ToString();
            l++;
        }
               
	}

    switch(l){
        case 1:
            num = long.Parse(str1) + 1;
            char[] sym = num.ToString().ToCharArray();
        break;
        case 2:
            num = long.Parse(str2) + 1;
        break;
    }



	
	char[] sym = num.ToString().ToCharArray();
	k = sym.Length;
	int[] digit2 = new int[k];
	for (int i = 0; i < digit2.Length; i++)
	{
		digit2[i] = int.Parse(string.Concat(sym[i]));
    }
	return digit2; 
    



 }

 System.Console.WriteLine();
 int[] num = new int[]{1,2,3};
 System.Console.WriteLine($"Number out:{PlusOne(num)}");