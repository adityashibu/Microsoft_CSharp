using System;

// Initialize variables - graded assignments 
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

string[] grade = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" };

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
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };
string[] finalGrades = new string[4];

for (int i = 0; i < scores.Length; i++)
{
    decimal score = scores[i];
    if (score >= 97 && score <= 100)
    {
        finalGrades[i] = grade[0];
    }
    else if (score >= 93 && score <= 96)
    {
        finalGrades[i] = grade[1];
    }
    else if (score >= 90 && score <= 92)
    {
        finalGrades[i] = grade[2];
    }
    else if (score >= 87 && score <= 89)
    {
        finalGrades[i] = grade[3];
    }
    else if (score >= 83 && score <= 86)
    {
        finalGrades[i] = grade[4];
    }
    else if (score >= 80 && score <= 82)
    {
        finalGrades[i] = grade[5];
    }
    else if (score >= 77 && score <= 79)
    {
        finalGrades[i] = grade[6];
    }
    else if (score >= 73 && score <= 76)
    {
        finalGrades[i] = grade[7];
    }
    else if (score >= 70 && score <= 72)
    {
        finalGrades[i] = grade[8];
    }
    else if (score >= 67 && score <= 69)
    {
        finalGrades[i] = grade[9];
    }
    else if (score >= 63 && score <= 66)
    {
        finalGrades[i] = grade[10];
    }
    else if (score >= 60 && score <= 62)
    {
        finalGrades[i] = grade[11];
    }
    else
    {
        finalGrades[i] = grade[12];
    }
}

Console.WriteLine("Student\t\tGrade\n");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine($"{studentNames[i]}:\t\t{scores[i]:F2}\t{finalGrades[i]}");
}
