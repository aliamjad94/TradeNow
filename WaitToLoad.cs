using System.Threading;

namespace vFluxLoginAutomation
{
    internal static class WaitToLoad
    {
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
