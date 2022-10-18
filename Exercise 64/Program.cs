
void MultipleThree(int min, int max)
{
    if (min > max)
    {
        return;
    }
    if (min % 3 == 0)
    {
        Console.WriteLine(min);
    }
    min++;
    MultipleThree(min, max);
}

MultipleThree(-9, 30);