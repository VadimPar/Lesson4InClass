double s = 200;
for(int i = 0; i < 8; i++)
{
    s *= 1.1;
}
Console.WriteLine(s);
Console.WriteLine("\n");


for(int i = 0; i <= 200; i++)
{
    if (i % 8 == 0)
    {
        Console.Write(i+"\t");
    }
}