
void SummOfNaturals(int min, int max, int summ = 0)
{
    if(min > max)
    {
        Console.WriteLine(summ);
        return;
    }
    summ += min;
    min++;
    SummOfNaturals(min, max, summ);
}

SummOfNaturals(2, 8); 