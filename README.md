# Home Work

Lesson tasks and Udemy tasks

## How to run it

Firstly you need to download this project. After this you need to open it in Visual Studio 2017(or other version).
If you want to run some task, you should open file Program.cs and write like this:
```
lessonNumber = 1;
taskNumber = 1;
IRunnable runnable = LoggerProviderFactory.GetTask(lessonNumber, taskNumber);
runnable.Run(new Cons());
```
In this example I run 1st task of 1st lesson task. Want to run other task? Simply change lessonNumber and taskNumber. For example:
```
lessonNumber = 16;
taskNumber = 1;
IRunnable runnable = LoggerProviderFactory.GetTask(lessonNumber, taskNumber);
runnable.Run(new Cons());
```
Similarly you could run Udemy tasks.
Lesson tasks are in folder TestProject.TaskLibrary/Tasks/. Udemy tasks are in folder TestProject.TaskLibrary/Udemy/.

## Author

* **Yurii Danchyshyn** - [jordi98](https://github.com/jordi98)
