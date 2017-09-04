using System;
using System.Text;

public class Engine : IEngine
{
    public void Run()
    {
        var reader = new ConsoleReader();
        var writer = new ConsoleWriter();
        var input = reader.ReadLine();
        var gameController = new GameController();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException)
            {
            }

            input = reader.ReadLine();
        }

        result.AppendLine(gameController.RequestResult());
        writer.WriteLine(result.ToString().Trim());
    }
}
