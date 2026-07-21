using CSharpToJavaScript.Utils;
namespace N;

[Import("scheduler", "node:timers/promises")]
[Value("scheduler")]
[Ignore]
public static class Scheduler
{
    [Value("wait")]
    public static Task<bool> Wait(int delay) { throw new System.NotImplementedException(); }
}

public class Main
{
    static Main()
    {
        Main.StartPause();
    }

    public async static void StartPause()
    {
        Console.WriteLine("Before the pause!");
        await Scheduler.Wait(1000);
        Console.WriteLine("After the pause!");
    }
}
