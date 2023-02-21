using TheropodSystem.HUD;

Starting starting = new Starting();

starting.StartUp();

List<string> options = new List<string>();

options.Add("Start");
options.Add("Files");
options.Add("User Data");
options.Add("Logs");

int index = 0;

do {
    index = Menu.Show(options);
    switch (index)
    {
        case 0:
            break;
        case 1:
            break;
        case 2:
            break;
    }
} while (index != options.Count);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;