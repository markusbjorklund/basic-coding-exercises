using System.Collections.Generic;
using System;
public class GradeRegister
{
  private List<int> grades;
  private List<int> exampoints;

  public GradeRegister()
  {
    this.grades = new List<int>();
    this.exampoints = new List<int>();
  }

  public void AddGradeBasedOnPoints(int points)
  {
    this.grades.Add(PointsToGrades(points));
    this.exampoints.Add(points);
  }

  public int NumberOfGrades(int grade)
  {
    int count = 0;
    foreach (int received in this.grades)
    {
      if (received == grade)
      {
        count++;
      }
    }
    return count;
  }

  public static int PointsToGrades(int points)
  {
    int grade = 0;
    if (points < 50)
    {
      grade = 0;
    }
    else if (points < 60)
    {
      grade = 1;
    }
    else if (points < 70)
    {
      grade = 2;
    }
    else if (points < 80)
    {
      grade = 3;
    }
    else if (points < 90)
    {
      grade = 4;
    }
    else
    {
      grade = 5;
    }
    return grade;
  }

  public double AverageOfGrades()
  {
    // Hint! You don't need to round the -1, but you do need it for all the other results...
    if (this.grades.Count == 0)
    {
      return Math.Round(-1.0, 2);
    }
    // calculate the average of grades
    double averageGrade = 0.00;
    foreach (double grade in this.grades)
    {
      averageGrade = averageGrade + grade;
    }
    return Math.Round(averageGrade / this.grades.Count, 2);
  }

  public double AverageOfPoints()
  {
    if (this.exampoints.Count == 0)
    {
      return Math.Round(-1.0, 2);
    }
    // calculate the average of points
    double averagePoints = 0.00;
    foreach (double point in this.exampoints)
    {
      averagePoints = averagePoints + point;
    }
    return Math.Round(averagePoints / this.exampoints.Count, 2);
  }
}