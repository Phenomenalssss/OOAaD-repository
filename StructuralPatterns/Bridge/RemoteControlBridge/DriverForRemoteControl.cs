using RemoteControlLibrary;

namespace RemoteControlBridge
{
    public class DriverForRemoteControl
    {
        protected Settings _settings;

        public DriverForRemoteControl(Settings settings)
        {
            _settings = settings;
        }

        public virtual void Operation()
        {
            Console.WriteLine("---------- Абстрактный пульт ----------");
            _settings.BrightnessUp();
            _settings.BrightnessUp();
            _settings.BrightnessDown();
            _settings.Subtitles();
            _settings.SetBrightness(77);
            _settings.InformationAboutRemoteControl();
            Console.WriteLine("---------- Абстрактный пульт ----------");
        }
    }
}
 