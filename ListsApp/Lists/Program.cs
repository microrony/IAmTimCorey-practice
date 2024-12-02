

bool noMoreStudents = false;
string? readResult;
List<string> classRosterList = new List<string>();

do
{
    Console.Clear();

    Console.Write("" +
        "Please enter the student name you want to add to the class roster list" +
        "(or type \"no more\" if there are no more students): ");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        string studentName = readResult;
        classRosterList.Add(studentName);

        noMoreStudents = readResult.ToLower() == "no more";
    }

}
while (noMoreStudents == false);

Console.WriteLine($"Total {classRosterList.Count} students enrolled");

