double S = 0;
int A = 3;
int B = 2;

while (B <= 50)
{
    S += (double)A / B;
    A += 2;
    B++;
}

Console.WriteLine(S.ToString("F2"));