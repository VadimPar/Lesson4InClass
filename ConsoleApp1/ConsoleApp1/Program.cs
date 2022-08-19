double s = 200;
for(int i = 0; i < 8; i++)
{
    s *= 1.1;
}
Console.WriteLine(s + "\n");

for(int i = 0; i <= 100; i++)
{
    if (i % 8 == 0)
    {
        Console.Write(i+"\t");
    }
}