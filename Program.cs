﻿//Code challenge: Add a method to display email addresses


string[,] corporate = 
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
    displayNames(corporate[i,0],corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    displayNames(external[i,0],external[i,1],externalDomain);
}

void displayNames(string firstName, string lastname, string domain = "contoso.com"){
    string emailAddress = "" + firstName[0] + firstName[1] +lastname +"@"+domain;
    Console.WriteLine(emailAddress.ToLower());
}