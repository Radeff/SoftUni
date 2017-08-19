using System.Collections.Generic;

public interface IManager
{
    string Quit(IList<string> argsList);

    string AddRecipe(IList<string> argsList);

    string AddItem(IList<string> argsList);

    string Inspect(IList<string> argsList);

    string AddHero(IList<string> argsList);
}