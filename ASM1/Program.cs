using System;
using System.Linq;
using System.Collections.Generic;

namespace ASM1
{
    internal class Program:BaseProgram
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Lecturer> lecturers = new List<Lecturer>();
            while (true)
            {
                try
                {
                    Write("==================================");
                    Write("     Welcome to BTEC FPT");
                    Write("     This is Assignment 2");
                    Write("==================================");
                    Write("           Main menu");
                    Write("==================================");
                    Write("     1. Student Management");
                    Write("     2. Lecturer Management");
                    Write("     3. Exit");
                    Write("==================================");
                    Write("==================================");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (choice == 1)
                    {
                        while (true)
                        {
                            try
                            {
                                Write("==================================");
                                Write("     Welcome to BTEC FPT");
                                Write("     This is Assignment 2");
                                Write("==================================");
                                Write("    1.	Add new student");
                                Write("    2.	View all students");
                                Write("    3.	Search students");
                                Write("    4.	Delete students");
                                Write("    5.	Update student");
                                Write("    6.	Back to main menu");
                                Write("==================================");
                                int subChoice = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (subChoice == 1)
                                {
                                    Write("====\t1. Add Student\t===");
                                    Console.Write("ID of Student: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Name of Student: ");
                                    string Name = Console.ReadLine();
                                    Console.Write("Dob: ");
                                    DateTime Dob = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Email: ");
                                    string Email = Console.ReadLine();
                                    Console.Write("Address: ");
                                    string Address = Console.ReadLine();
                                    Console.Write("Batch: ");
                                    string Batch = Console.ReadLine();
                                    students.Add(new Student(id, Name, Dob, Email, Address, Batch));
                                    Write("Add Successfully");
                                }
                                else if (subChoice == 2)
                                {
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Write("====\tList Students\t===");
                                    foreach (Student student in students)
                                    {
                                        Write(student.ToString());
                                        Write("==========================");
                                        Console.WriteLine();
                                    }
                                }
                                else if (subChoice == 3)
                                {
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Write("====\t3. Search Student\t===");
                                    Write("Name or Id to Search ...");
                                    string search = Console.ReadLine();
                                    var containStudent = students.Where(x => x.Name.Contains(search) || x.Id.Equals(search));
                                    foreach (Student student in containStudent)
                                    {
                                        Write(student.ToString());
                                        Write("==========================");
                                        Console.WriteLine();
                                    }
                                }
                                else if (subChoice == 4)
                                {
                                    Write("====\t4. Delete Student\t===");
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Console.Write("Id: ");
                                    string deleteId = Console.ReadLine();
                                    var deleteStudent = students.Find(x => x.Id.Equals(deleteId));
                                    if (deleteStudent == null) Write("Can't find anyone");
                                    else
                                    {
                                        students.Remove(deleteStudent);
                                        Write("Delete Successfully");
                                    }
                                }
                                else if (subChoice == 5)
                                {
                                    Write("====\t5. Update Student\t===");
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Console.Write("Id: ");
                                    string updateId = Console.ReadLine();
                                    var updateStudent = students.Find(x => x.Id.Equals(updateId));
                                    if (updateStudent == null) Write("Can't find anyone");
                                    else
                                    {
                                        Console.Write("Name: ");
                                        updateStudent.Name = Console.ReadLine();
                                        Console.Write("Dob: ");
                                        updateStudent.Dob = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Email: ");
                                        updateStudent.Email = Console.ReadLine();
                                        Console.Write("Address: ");
                                        updateStudent.Address = Console.ReadLine();
                                        Console.Write("Batch: ");
                                        updateStudent.Batch = Console.ReadLine();
                                        Write("Update Successfully");
                                    }
                                }
                                else if (subChoice == 6) break;
                                else Write("Wrong key !!");
                            }
                            catch (Exception)
                            {
                                Console.Write("Errr");
                            }
                        }
                    }
                    else if (choice == 2)
                    {
                        while (true)
                        {
                            try
                            {
                                Write("==================================");
                                Write("     Welcome to BTEC FPT");
                                Write("     This is Assignment 2");
                                Write("==================================");
                                Write("    1.	Add new Lectures");
                                Write("    2.	View all Lectures");
                                Write("    3.	Search Lectures");
                                Write("    4.	Delete Lectures");
                                Write("    5.	Update Lectures");
                                Write("    6.	Back to main menu");
                                Write("==================================");
                                int subChoice = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (subChoice == 1)
                                {
                                    Write("====\t1. Add Lecturer\t===");
                                    Console.Write("ID of Lecturer: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Name of Lecturer: ");
                                    string Name = Console.ReadLine();
                                    Console.Write("Dob: ");
                                    DateTime Dob = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Email: ");
                                    string Email = Console.ReadLine();
                                    Console.Write("Address: ");
                                    string Address = Console.ReadLine();
                                    Console.Write("Department: ");
                                    string Batch = Console.ReadLine();
                                    lecturers.Add(new Lecturer(id, Name, Dob, Email, Address, Batch));
                                    Write("Add Successfully");
                                }
                                else if (subChoice == 2)
                                {
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Write("====\tList Lecturers\t===");
                                    foreach (Lecturer lecturer in lecturers)
                                    {
                                        Write(lecturer.ToString());
                                        Write("==========================");
                                        Console.WriteLine();
                                    }
                                }
                                else if (subChoice == 3)
                                {
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Write("====\t3. Search Lecturers\t===");
                                    Write("Name or Id to Search ...");
                                    string search = Console.ReadLine();
                                    var containLecturer = lecturers.Where(x => x.Name.Contains(search) || x.Id.Equals(search));
                                    foreach (Lecturer lecturer in containLecturer)
                                    {
                                        Write(lecturer.ToString());
                                        Write("==========================");
                                        Console.WriteLine();
                                    }
                                }
                                else if (subChoice == 4)
                                {
                                    Write("====\t4. Delete Lecturer\t===");
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Console.Write("Id: ");
                                    string deleteId = Console.ReadLine();
                                    var deleteLecturer = lecturers.Find(x => x.Id.Equals(deleteId));
                                    if (deleteLecturer == null) Write("Can't find anyone");
                                    else
                                    {
                                        lecturers.Remove(deleteLecturer);
                                        Write("Delete Successfully");
                                    }
                                }
                                else if (subChoice == 5)
                                {
                                    Write("====\t5. Update Lecturer\t===");
                                    Write("==================================");
                                    Write("     Welcome to BTEC FPT");
                                    Write("     This is Assignment 2");
                                    Write("==================================");
                                    Console.Write("Id: ");
                                    string updateId = Console.ReadLine();
                                    var updateLecturer = lecturers.Find(x => x.Id.Equals(updateId));
                                    if (updateLecturer == null) Write("Can't find anyone");
                                    else
                                    {
                                        Console.Write("Name: ");
                                        updateLecturer.Name = Console.ReadLine();
                                        Console.Write("Dob: ");
                                        updateLecturer.Dob = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Email: ");
                                        updateLecturer.Email = Console.ReadLine();
                                        Console.Write("Address: ");
                                        updateLecturer.Address = Console.ReadLine();
                                        Console.Write("Department: ");
                                        updateLecturer.Department = Console.ReadLine();
                                        Write("Update Successfully");
                                    }
                                }
                                else if (subChoice == 6) break;
                                else Write("Wrong key !!");
                            }
                            catch (Exception)
                            {
                                Console.Write("Errr");
                            }
                        }
                    }
                    else if (choice == 3) break;
                    else Write("Wrong key !!");
                }
                catch (Exception)
                {
                    Console.Write("Errr");
                }
            }
        }
    }
}