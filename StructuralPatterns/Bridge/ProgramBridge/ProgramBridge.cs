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
            RemoteControl remoteControl = new RemoteControl(power, driver);
            remoteControl.Use();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            driver = new ExtendedDriverForRemoteControl(settings, sound, channel);
            remoteControl = new ExtendedRemoteControl(power, sound, channel, driver);
            remoteControl.Use();
        }
    }
}