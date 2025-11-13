using RemoteControlLibrary;
using RemoteControlProxy;

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

            SettingsDriver settingsDriver = new SettingsDriver(settings);
            SoundDriver soundDriver = new SoundDriver(sound);
            ChannelDriver channelDriver = new ChannelDriver(channel);

            Console.WriteLine("---------------------- Пульт с Settings ----------------------");
            RemoteControl.Use(power, settingsDriver);

            Console.WriteLine("---------------------- Пульт с Sound ----------------------");
            RemoteControl.Use(power, soundDriver);

            Console.WriteLine("---------------------- Пульт с Channel ----------------------");
            RemoteControl.Use(power, channelDriver);

            Proxy guestProxySettings = new Proxy(settingsDriver, Role.Guest);
            Proxy userProxySound = new Proxy(soundDriver, Role.User);
            Proxy adminProxyChannel = new Proxy(channelDriver, Role.Admin);

            Console.WriteLine("---------------------- Пульт с Settings в роли Guest ----------------------");
            RemoteControl.Use(power, guestProxySettings);

            Console.WriteLine("---------------------- Пульт с Sound в роли User ----------------------");
            RemoteControl.Use(power, userProxySound);

            Console.WriteLine("---------------------- Пульт с Channel в роли Admin ----------------------");
            RemoteControl.Use(power, adminProxyChannel);

        }
    }
}