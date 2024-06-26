﻿string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";


for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayEmail(corporate[i, 0], corporate[i, 1], "contoso.com");
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmail(external[i, 0], external[i, 1], externalDomain);
}

void DisplayEmail(string firstname, string lastname, string domain)
{
    string firstpart = firstname.Substring(0, 2).ToLower();
    string lastpart = lastname.ToLower();
    Console.WriteLine($"{firstpart}{lastpart}@{domain}");
}