using System;

string[] val = new string[1];
Console.WriteLine("Enter anyone of the letters from F, W, Q, N, A");

for (int i = 0; i < val.Length; i++)
{
    val[i] = Console.ReadLine();
}


for (int i = 0; i < val.Length; i++)
{
    if (val[i] == "F")
    {
        for (int j = 100; j < 110; j++)
        {
            if (j % 2 != 0)
            {
                Console.Write(" F" + j);
            }
        }
    }
}


for (int i = 0; i < val.Length; i++)
{
    if (val[i] == "W")
    {
        for (int j = 100; j <= 110; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write(" W" + j);
            }
        }
    }
}


for (int i = 0; i < val.Length; i++)
{
    int flag;

    if (val[i] == "Q")
    {
        for (int k = 2; k <= 30; k++)
        {
            flag = 1;

            for (int j = 2; j <= k / 2; j++)
            {
                if (k % j == 0)
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.Write(" Q" + k);
            }
        }
    }
}


for (int i = 0; i < val.Length; i++)
{
    int n1 = 0;
    int n2 = 1;
    int n3;
    if (val[i] == "N")
    {
        Console.Write("N" + n1 + " " + "N" + n2);
        for (int j = 2; j < 10; ++j)
        {
            n3 = n1 + n2;
            Console.Write(" N" + n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
}

for (int i = 0; i < val.Length; i++)
{
    if (val[i] == "A")
    {
        int rem, sum, temp;

        for (int j = 1; j <= 1000; j++)
        {
            temp = j;
            sum = 0;

            while (temp != 0)
            {
                rem = temp % 10;
                temp = temp / 10;
                sum = sum + (rem * rem * rem);
            }
            if (sum == j)
                Console.WriteLine(" A" + j);
        }

        for (int K = 1001; K <= 10000; K++)
        {
            temp = K;
            sum = 0;

            while (temp != 0)
            {
                rem = temp % 10;
                temp = temp / 10;
                sum = sum + (rem * rem * rem * rem);
            }
            if (sum == K)
                Console.WriteLine(" A" + K);
        }
        for (int n = 10001; n <= 93000; n++)
        {
            temp = n;
            sum = 0;

            while (temp != 0)
            {
                rem = temp % 10;
                temp = temp / 10;
                sum = sum + (rem * rem * rem * rem * rem);
            }
            if (sum == n)
                Console.WriteLine(" A" + n);
        }
    }
}

