using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TaskPlanner.Models;

namespace TaskPlanner.DAL
{
    public class TaskPlannerInitializer : DropCreateDatabaseAlways<TaskPlannerContext>
    {
        protected override void Seed (TaskPlannerContext context)
        {


            var tasks = new List<Task>()
            {
                new Task() { Name="Doček nove godine", Description="Kupit sljedeće: Piće \n hrana \n bla bla" },
                new Task() { Name="Doček nove godine", Description="Kupit sljedeće: Piće \n hrana \n bla bla" },
                new Task() { Name="Doček nove godine", Description="Kupit sljedeće: Piće \n hrana \n bla bla" },
                new Task() { Name="Doček nove godine", Description="Kupit sljedeće: Piće \n hrana \n bla bla" }
            };

            var users = new List<User>()
            {
                new User() {
                    Name = "John",
                    Surname = "Smith",
                    Tasks = new List<Task>() { tasks[0], tasks[1] }
                },
                new User() {
                    Name = "Alice",
                    Surname = "Fox"
                },
                new User() {
                    Name = "Dan",
                    Surname = "Mckee"
                }
            };

            context.Users.AddRange(users);
            context.Tasks.AddRange(tasks);

            context.SaveChanges();
        }
    }
}