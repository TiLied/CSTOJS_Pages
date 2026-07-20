import { scheduler } from 'node:timers/promises';

class Main
{
    static
    {
        Main.StartPause();
    }

    static async StartPause()
    {
        console.log("Before the pause!");
        await scheduler.wait(1000);
        console.log("After the pause!");
    }
}
