namespace Programa01;
public static class NumHelper
{
    public static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        bool prime = true;

        for (int i = num - 1; i > 1; i--)
        {
            if (num % i == 0)
            {
                prime = false;
                break;
            }
        }

        return prime;
    }
}