# Home Work

Lesson tasks and Udemy tasks

## How to run it

Firstly you need to download this project. After this you need to open it in Visual Studio 2017(or other version).
If you want to run some task, you should open file Program.cs and write like this:
```
var tasks = new IRunnable[]
{
    new TaskLibrary.Tasks.Lesson1.Task1.Task()
};

foreach (var task in tasks)
{
    task.Run(new Cons());
}
```
In this example I run 1st task of 1st lesson task. Want to run more tasks? Simply add new task to tasks. For example:
```
var tasks = new IRunnable[]
{
    new TaskLibrary.Tasks.Lesson1.Task1.Task()
    new TaskLibrary.Tasks.Lesson1.Task2.Task()
    new TaskLibrary.Tasks.Lesson1.Task3.Task()
};

foreach (var task in tasks)
{
    task.Run(new Cons());
}
```
Similarly you could run Udemy tasks.
Lesson tasks are in folder TestProject.TaskLibrary/Tasks/. Udemy tasks are in folder TestProject.TaskLibrary/Udemy/.

## Author

* **Yurii Danchyshyn** - [jordi98](https://github.com/jordi98)
