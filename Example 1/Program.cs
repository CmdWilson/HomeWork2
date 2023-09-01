Console.Write("a = ");
int A = int.Parse(Console.ReadLine());
Console.Write("b = ");
int B = int.Parse(Console.ReadLine());
int sum = 1;
int perm = A;
int max = 0;
if(B == 0)
{
    Console.Write("max = 1");
}

if(B > 0)
{
    
    while(sum <= B-1)
    {
    max = perm * A; 
    perm = max;
    sum++;
    }
    Console.Write("max = ");
    Console.WriteLine(perm);
}
else
{
    Console.Write("Степень является не четной ");
}