using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaGrades = { 90, 86, 87, 98, 100 };
int[] andrewGrades = { 92, 89, 81, 96, 90 };
int[] emmaGrades = { 90, 85, 87, 98, 68 };
int[] loganGrades = { 90, 95, 87, 88, 96 };

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

string grade = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" };

foreach (int score in sophiaGrades)
{
    sophiaSum += score;
}

foreach (int score in andrewGrades)
{
    andrewSum += score;
}

foreach (int score in emmaGrades)
{
    emmaSum += score;
}

foreach (int score in loganGrades)
{
    loganSum += score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

decimal[] scores = { sophiaScore, andrewScore, emmaScore, loganScore };

foreach (score in scores)
{
    if (score >= 97 || score <= 100)
    {
        Console.WriteLine(grade[0]);
    }
    else if (score >= 93 || score <= 96)
    {
        Console.WriteLine(grade[1]);
    }
    else if (score >= 90 || score <= 92)
    {
        Console.WriteLine(grade[2]);
    }
    else if (score >= 87 || score <= 89)
    {
        Console.WriteLine(grade[3]);
    }
    else if (score >= 83 || score <= 86)
    {
        Console.WriteLine(grade[4]);
    }
    else if (score >= 80 || score <= 82)
    {
        Console.WriteLine(grade[5]);
    }
    else if (score >= 77 || score <= 79)
    {
        Console.WriteLine(grade[6]);
    }
    else if (score >= 73 || score <= 76)
    {
        Console.WriteLine(grade[7]);
    }
    else if (score >= 70 || score <= 72)
    {
        Console.WriteLine(grade[8]);
    }
    else if (score >= 67 || score <= 69)
    {
        Console.WriteLine(grade[9]);
    }
    else if (score >= 63 || score <= 66)
    {
        Console.WriteLine(grade[10]);
    }
    else if (score >= 60 || score <= 62)
    {
        Console.WriteLine(grade[11]);
    }
    else
    {
        Console.WriteLine(grade[12]);
    }
}

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + $"\t{score}");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();