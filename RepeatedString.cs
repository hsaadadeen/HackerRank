long RepeatedString(string s, long n)
{
    long count = 0;

    for (int idx = 0; idx < Math.Min(s.Length, n); idx++)
        if (s[idx] == 'a')
            count++;

    if (s.Length < n)
    {
        count *= (n / s.Length);

        for (int idx = 0; idx < (n % s.Length); idx++)
            if (s[idx] == 'a')
                count++;
    }

    return count;
}