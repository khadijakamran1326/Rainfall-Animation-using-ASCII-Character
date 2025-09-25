using System;
using System.Threading;

class RainSimulation
{
    static void Main()
    {
        // These frames create a visual progression of rain,
        // from light droplets to more distinct streaks.
        string[] frames = new string[]
        {
            @". . .
. . . .
  . . .
. . . .",
            @"
\  /
|  \ /
/ | \",
            @".| . |
 | . |
| . |"
        };
        Console.CursorVisible = false;

        // Loop 50 times to run the animation
        for (int i = 0; i < 50; i++)
        {
            // Loop through each frame in the array
            foreach (string frame in frames)
            {
                // Clear the console and move the cursor to the top-left corner
                Console.Clear();

                // Write the current frame to the console
                Console.WriteLine(frame);

                // Pause for a short time to create the animation effect
                Thread.Sleep(150);
            }
        }
        Console.CursorVisible = true;
    }
}
using System;
using System.Threading;

class RainSimulation
{
    static void Main()
    {
        // These frames create a visual progression of rain,
        // from light droplets to more distinct streaks.
        string[] frames = new string[]
        {
            // Frame 1: Light, scattered rain
            @"
. | . . . \ . . .
  . . . | . . . .
. . . | . \ . . .
  . . . . / . | .",
            
            // Frame 2: More streaks appear
            @"
/ | . | . . . \ .
. / . | . . . . .
. . | . / . . \ .
  . . . . | . . .",

            // Frame 3: Heavy rain
            @"
/ . | . \ . . . .
| . . . / . . | .
. . | / . . | . .
\ . . . . | . / .",

            // Frame 4: Rain settling
            @"
  . . / . | . . .
. | . . . . . \ .
  . . / . | . . .
. | . . . . \ . ."
        };
        Console.CursorVisible = false;

        // Loop 50 times to run the animation
        for (int i = 0; i < 50; i++)
        {
            // Loop through each frame in the array
            foreach (string frame in frames)
            {
                // Clear the console and move the cursor to the top-left corner
                Console.Clear();

                // Write the current frame to the console
                Console.WriteLine(frame);

                // Pause for a short time to create the animation effect
                Thread.Sleep(150);
            }
        }
        Console.CursorVisible = true;
    }
}
