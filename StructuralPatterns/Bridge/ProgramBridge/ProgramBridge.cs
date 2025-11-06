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

            driver = new DriverForRemoteControl(power, settings);
            RemoteControl.Use(driver);

            driver = new ExtendedDriverForRemoteControl(power, settings, sound, channel);
            RemoteControl.Use(driver);
        }
    }
}