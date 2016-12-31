 //Repeated String
 //
 //Lilah has a string, s, of lower-case English letters that she repeated infinitely many times.
 //
 //Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.
 //
 //Example :
 //	a)			aba 10
 //	Result : 	7
 //	
 //	The first 10 letters of the infinite string are 'abaabaabaa'. 
 //	Because there are  a's, we print 7 on a new line.
 //
 //	b)			a	1000000000000
 //	Result : 	1000000000000
 //
 //	Because all of the first 1000000000000 letters of the infinite string are a, 
 //	we print 1000000000000 on a new line.
 //
 // @author HSaadAdeen

long RepeatedString(string s, long n)
{
    long count = 0;

    // Count the a's in the input string
    for (int idx = 0; idx < Math.Min(s.Length, n); idx++)
        if (s[idx] == 'a')
            count++;

    if (s.Length < n)
    {
        // mathematicaly compute the number of occurrence of the input string
        count *= (n / s.Length);

        // do the extra loops for the decimals
        for (int idx = 0; idx < (n % s.Length); idx++)
            if (s[idx] == 'a')
                count++;
    }

    return count;
}
