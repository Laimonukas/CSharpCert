// Guided project for learning arrays.


using System;
using System.Reflection.Metadata.Ecma335;

// initialize variables - graded assignments 

// Starter code:
/*
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

*/

//// Updated code here:

string[] studentNames = {"Sophia","Andrew","Emma","Logan"};
int assignmentCount = 5;
Dictionary<string,int[]> studentAssignments = new Dictionary<string, int[]>(){
    {"Sophia",[90,86,87,98,100]},
    {"Andrew",[92,89,81,96,90]},
    {"Emma",[90,85,87,98,68]},
    {"Logan",[90,95,87,88,96]}
};
Dictionary<string,float> studentScores = new Dictionary<string, float>();
string commandLine = "";
int[] oldGrades = [];
int[] newGrades = [];



void Main(){
    Console.Clear();
    Console.WriteLine("Commands:");
    Console.WriteLine("Info / i - Gets current information about students");
    Console.WriteLine("Update / u - Update student information");
    Console.WriteLine("Quit / q - Quits execution");
    Console.WriteLine("Enter command to continue:");
    
    commandLine = Console.ReadLine().ToLower();
    switch(commandLine){
        case "i":
            GetStudentInformation();
            break;
        case "info":
            GetStudentInformation();
            break;
        case "u":
            UpdateStudentInformation();
            break;
        case "update":
            UpdateStudentInformation();
            break;
        default:
            break;
    }
}

void GetStudentInformation(){
    Console.Clear();
    Console.WriteLine($"Current student count: {studentNames.Length}");
    Console.WriteLine($"Current assignment count: {assignmentCount}");

    studentScores.Clear();
    foreach(KeyValuePair<string,int[]> studentEntry in studentAssignments){
        Console.WriteLine($"{studentEntry.Key}: {String.Join(',',studentEntry.Value)}");

        float scoreSum = 0.0f;
        for (int i = 0; i < studentEntry.Value.Length; i++){
            if (i<assignmentCount){
                scoreSum += studentEntry.Value[i];
            }else{
                scoreSum += (float)studentEntry.Value[i] * 0.1f;
            }
        }
        studentScores.Add(studentEntry.Key,scoreSum/assignmentCount);
    }

    Console.WriteLine("Evaluation:");
    Console.WriteLine("Student\t\tGrade\n");

    foreach(KeyValuePair<string,float> studentScore in studentScores){
        Console.WriteLine($"{studentScore.Key}:\t\t{studentScore.Value} , {GetLetterGrade(studentScore.Value)}");
    }
    
    Console.WriteLine("Continue? Y/N");
    commandLine = Console.ReadLine().ToLower();
    switch(commandLine){
        case "y":
            Main();
            break;
        default:
            break;
    }
}

string GetLetterGrade(float numericGrade){
    string letterGrade = "F";
    switch(numericGrade){
        case float mark when mark > 97:
            letterGrade = "A+";
            break;
        case float mark when mark > 93:
            letterGrade = "A";
            break;
        case float mark when mark > 90:
            letterGrade = "A-";
            break;
        case float mark when mark > 87:
            letterGrade = "B+";
            break;
        case float mark when mark > 83:
            letterGrade = "B";
            break;
        case float mark when mark > 80:
            letterGrade = "B-";
            break;
        case float mark when mark > 77:
            letterGrade = "C+";
            break;
        case float mark when mark > 73:
            letterGrade = "C";
            break;
        case float mark when mark > 70:
            letterGrade = "C-";
            break;
        case float mark when mark > 67:
            letterGrade = "D+";
            break;    
        case float mark when mark > 63:
            letterGrade = "D";
            break;    
        case float mark when mark > 60:
            letterGrade = "D-";
            break;
        default:
            letterGrade = "F";
            break;
    }

    return letterGrade;
}

void UpdateStudentInformation(){
    Console.Clear();
    Console.WriteLine("Commands:");
    Console.WriteLine("s - Add student");
    Console.WriteLine("e - Edit student grades");
    Console.WriteLine("r - Remove student");
    Console.WriteLine("m - Return to Main");

    commandLine = Console.ReadLine().ToLower();
    switch(commandLine){
        case "s":
            AddStudent();
            break;
        case "e":
            EditStudent();
            break;
        case "r":
            RemoveStudent();
            break;
        case "m":
            Main();
            break;
        default:
            Main();
            break;
    }
}

void AddStudent(){
    Console.Clear();
    Console.WriteLine("Enter new student's name: ");
    string studentName = Console.ReadLine();
    studentNames = studentNames.Append(studentName).ToArray();
    studentAssignments.Add(studentName,[]);

    Console.WriteLine($"Enter grades for student: {studentName}? Y/N");
    commandLine = Console.ReadLine().ToLower();
    switch(commandLine){
        case "y":
            EditStudent(studentName);
            break;
        default:
            Main();
            break;
    }
}

void EditStudent(string studentName = ""){
    Console.Clear();

    if(studentName == ""){
        Console.WriteLine($"Available students: {String.Join(',',studentNames)}");
        Console.WriteLine("Enter valid student name: ");
        studentName = Console.ReadLine();
    }else if(!studentNames.Contains(studentName)){
        EditStudent();
    }
    oldGrades = [];
    newGrades = [];
    oldGrades = oldGrades.Concat(studentAssignments[studentName]).ToArray();
    Console.WriteLine($"{studentName} old grades: {String.Join(',',oldGrades)}");
    Console.WriteLine("Enter new grades // s - to save / n - to quit without saving");
    AddGrades(studentName);
}

void AddGrades(string studentName){
    int parsedGrade;
    commandLine = Console.ReadLine().ToLower();
    if(Int32.TryParse(commandLine, out parsedGrade)){
        newGrades = newGrades.Append(parsedGrade).ToArray();
        Console.WriteLine($"Old grades: {String.Join(',',oldGrades)}");
        Console.WriteLine($"New grades: {String.Join(',',newGrades)}");
        Console.WriteLine("Enter new grades // s - to save / n - to quit without saving");
        AddGrades(studentName);
    }else{
        switch(commandLine){
        case "s":
            studentAssignments[studentName] = newGrades;
            UpdateStudentInformation();
            break;
        default:
            UpdateStudentInformation();
            break;
        }
    }
}

void RemoveStudent(){
    Console.Clear();
    Console.WriteLine($"Available students: {String.Join(',',studentNames)}");
    Console.WriteLine("Enter student name to remove: ");
    List<string> studentList = studentNames.ToList();

    commandLine = Console.ReadLine();
    if(studentNames.ToList().Remove(commandLine)){
        studentNames = studentList.ToArray();
        studentAssignments.Remove(commandLine);
        UpdateStudentInformation();
    }else{
        RemoveStudent();
    }
}


Main();
