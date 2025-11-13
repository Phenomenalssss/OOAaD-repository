using RemoteControlBridge;
using RemoteControlLibrary;

namespace ProgramBridge
{
    class ProgramBridge
    {
        public static void Main(string[] args)
        {
            Power power = new Power();
            Settings settings = new Settings();
            Sound sound = new Sound();
            Channel channel = new Channel();
            DriverForRemoteControl driver;

            driver = new DriverForRemoteControl(settings);
            RemoteControl.Use(power, driver);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            driver = new ExtendedDriverForRemoteControl(settings, sound, channel);
            RemoteControl.Use(power, driver);
        }
    }
}