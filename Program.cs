using TheropodSystem.HUD;
using TheropodSystem;
using TheropodSystem.Models.Auth;
using TheropodSystem.Services;

SystemInfo info = new SystemInfo();
UserService userService = new UserService();

Thread.Sleep(1000);
Starting starting = new Starting(userService);

//starting.StartUp();

//starting.StartSystem();

User? user;

do {
    user = starting.UserLogin();
} while (user == null);

starting.LoginSuccess();

List<string> options = new List<string>();

options.Add("Start");
options.Add("Files");
options.Add("User Data");
options.Add("Lock Screen");
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
        case 3:
            starting.LockScreen();
            break;
        case 4:
            break;
    }
} while (index != options.Count);


Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;