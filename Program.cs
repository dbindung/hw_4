using System;

class Program {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Укажи номер задачи, например: dotnet run -- 1");
            return;
        }

        switch (args[0]) {
            case "1":
                Task1.Run(); break;
            // case "2":
            //     Task2.Run(); break;
            // case "3":
            //     Task3.Run(); break;s
            default:
                Console.WriteLine("Нет такой задачи."); break;
        }
    }

    
}
