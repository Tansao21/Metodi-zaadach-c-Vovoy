
double square = 100.0;
double harvestValue = 20.0;
double harvestValueTotal = harvestValue;



int yearHarvestOver22 = 0;
int yearSquareOver120 = 0;
int yearTotalHarvestOver800 = 0;

double harvestOver22Value = 0.0;
double squareOver120Value = 0.0;
double totalHarvestOver800Value = 0.0;

int currentYear = 1;
while (true)
{
    currentYear++;
    square *= 1.05;
    harvestValue *= 1.02;
    harvestValueTotal += harvestValue;

    if (yearHarvestOver22 == 0 && harvestValue > 22.0)
    {
        yearHarvestOver22 = currentYear;
        harvestOver22Value = harvestValue;
    }

    if (yearSquareOver120 == 0 && square > 120.0)
    {
        yearSquareOver120 = currentYear;
        squareOver120Value = square;
    }

    if (yearTotalHarvestOver800 == 0 && harvestValueTotal > 800.0)
    {
        yearTotalHarvestOver800 = currentYear;
        totalHarvestOver800Value = harvestValueTotal;
    }

    if (yearHarvestOver22 > 0 && yearSquareOver120 > 0 && yearTotalHarvestOver800 > 0)
    {
        Console.WriteLine($"Урожайность превысит 22 центнера с гектара в {yearHarvestOver22} году: {Math.Round(harvestOver22Value, 2)}.");
        Console.WriteLine($"Площадь участка станет больше 120 гектаров в {yearSquareOver120} году: {Math.Round(squareOver120Value, 2)}.");
        Console.WriteLine($"Общий урожай, собранный за все время, начиная с первого года, превысит 800 центнеров в {yearTotalHarvestOver800} году: {Math.Round(totalHarvestOver800Value, 2)}.");
        break;
    }
}
//
Console.ReadLine();
