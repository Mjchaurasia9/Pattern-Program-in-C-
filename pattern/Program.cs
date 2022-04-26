// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter a Numbet:\t");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
int m = n-1;
int l = i;
for (int j = 1; j <= i; j++)
{
Console.Write(l+" ");
l = l+m;
m--;
}
Console.WriteLine();
}
