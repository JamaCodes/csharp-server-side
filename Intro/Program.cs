using System;

data = {
    FirstName: Jama,
    LastName: Mohamed

}

List <Person> people = data.GetAllPeople();
foreach (Person p in people)
{
    Console.WriteLine($"Hi, {p.FirstName} {p.LastName}!");
}


