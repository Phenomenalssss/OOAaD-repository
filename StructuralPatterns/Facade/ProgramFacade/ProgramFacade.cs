using DriverForRemoteControlFacade;
using RemoteControlLibrary;
using RemoteControlFacade;

namespace ProgramFacade
{
    class ProgramFacade
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            Settings settings = new Settings();
            Sound sound = new Sound();
            Channel channel = new Channel();

            DriverForRemoteControl driverForRemoteControl = new DriverForRemoteControl(power, settings, sound, channel);
            RemoteControl.Use(driverForRemoteControl);
        }
    }
}
