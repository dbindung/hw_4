using System;

class Program {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Укажите номер задачи, например: dotnet run -- 1");
            return;
        }

        switch (args[0]) {
            case "1":
                Task1.Run(); break;
            default:
                Console.WriteLine("Нет такой задачи."); break;
        }
    }
}
