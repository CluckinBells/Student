using System;
using System.Linq;

public class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    // Конструктор без параметров
    public Student()
    {
        LastName = "Иванов";
        FirstName = "Иван";
        MiddleName = "Иванович";
        GroupNumber = "Группа 1";
        Grades = new int[] { 4, 5, 4, 5, 4 };
    }

    // Конструктор с параметрами
    public Student(string lastName, string firstName, string middleName, string groupNumber, int[] grades)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    // Метод для вычисления среднего балла
    public double CalculateAverageGrade()
    {
        return Grades.Average();
    }

    // Метод для проверки, все ли оценки 4 или 5
    public bool HasOnlyGoodGrades()
    {
        return Grades.All(grade => grade >= 4);
    }
}