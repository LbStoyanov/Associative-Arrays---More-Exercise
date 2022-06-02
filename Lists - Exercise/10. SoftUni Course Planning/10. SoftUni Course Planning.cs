using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split(":").ToArray();
                if (command[0] == "course start")
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    if (!lessons.Contains(command[1]))
                    {
                        lessons.Add(command[1]);
                    }
                }
                else if (command[0] == "Insert")
                {
                    var lessonTitle = command[1];
                    var indexTitle = int.Parse(command[2]);
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(indexTitle, lessonTitle);
                    }
                }
                else if (command[0] == "Remove")
                {
                    var lessonTitle = command[1];
                    var exercise = lessonTitle + "-Exercise";
                    if (lessons.Contains(lessonTitle))
                    {
                        lessons.Remove(lessonTitle);
                    }
                    if (lessons.Contains(exercise))
                    {
                        lessons.Remove(exercise);
                    }


                }
                else if (command[0] == "Swap")
                {
                    var firstLessonTitle = command[1];
                    var secondLessonTitle = command[2];
                    var firstExerciseTitle = command[1] + "-Exercise";
                    var secondExerciseTitle = command[2] + "-Exercise";
                    if (lessons.Contains(firstLessonTitle) && lessons.Contains(secondLessonTitle))
                    {
                        var firstLessonIndex = 0;
                        var secondLessonIndex = 0;
                        var firstExerciseIndex = 0;
                        var secondExerciseIndex = 0;
                        for (int i = 0; i < lessons.Count; i++)
                        {
                            if (lessons[i] == firstLessonTitle)
                            {
                                firstLessonIndex = i;
                            }
                            else if (lessons[i] == secondLessonTitle)
                            {
                                secondLessonIndex = i;
                            }
                        }
                        if (lessons.Contains(firstExerciseTitle) || lessons.Contains(secondExerciseTitle)) 
                        {
                            for (int i = 0; i < lessons.Count; i++)
                            {
                                if (lessons[i] == firstExerciseTitle)
                                {
                                    firstExerciseIndex = i;
                                }
                                else if (lessons[i] == secondExerciseTitle)
                                {
                                    secondExerciseIndex = i;
                                }
                            }
                           
                        }
                        
                        string temp = string.Empty;
                        temp = lessons[firstLessonIndex];
                        lessons[firstLessonIndex] = lessons[secondLessonIndex];
                        lessons[secondLessonIndex] = temp;
                    }
                }
                else if (command[0] == "Exercise")
                {
                    var lessonTitle = command[1];
                    var exercise = lessonTitle + "-Exercise";
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exercise);
                    }
                    else
                    {
                        for (int i = 0; i < lessons.Count; i++)
                        {
                            if (lessonTitle == lessons[i])
                            {
                                var index = i + 1;
                                lessons.Insert(index, exercise);
                                break;
                            }
                        }
                    }
                }

            }
            var counter = 1;
            foreach (var lesson in lessons)
            {
                Console.WriteLine($"{counter}.{lesson}");
                counter++;
            }
        }
    }
}
