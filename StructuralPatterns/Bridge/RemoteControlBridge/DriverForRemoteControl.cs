using RemoteControlLibrary;

namespace RemoteControlBridge
{
    public class DriverForRemoteControl
    {
        protected Power _power;
        protected Settings _settings;

        public DriverForRemoteControl(Power power, Settings settings)
        {
            _power = power;
            _settings = settings;
        }

        public virtual void Operation()
        {
            Console.WriteLine("Абстрактный пульт:");
            _power.TurnOn();
            _settings.BrightnessUp();
            _settings.BrightnessUp();
            _settings.BrightnessDown();
            _settings.Subtitles();
            _settings.SetBrightness(77);
            _settings.InformationAboutRemoteControl();
            _power.TurnOff();
            Console.WriteLine();
        }
    }
}
 