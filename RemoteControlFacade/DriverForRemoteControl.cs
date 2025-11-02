namespace RemoteControlFacade
{
    public class DriverForRemoteControl
    {
        private Power _power;
        private Settings _settings;
        private Sound _sound;
        private Channel _channel;

        public DriverForRemoteControl(Power power, Settings settings, Sound sound, Channel channel)
        {
            _power = power;
            _settings = settings;
            _sound = sound;
            _channel = channel;
        }

        public void Operation()
        {
            _power.TurnOn();
            _settings.BrightnessUp();
            _settings.BrightnessUp();
            _settings.BrightnessDown();
            _channel.List();
            _channel.Previous();
            _channel.Next();
            _channel.Next();
            _channel.ForNumber(7);
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeDown();
            _sound.VolumeMute();
            _sound.VolumeUp();
            _sound.VolumeUnMute();
            _settings.Subtitles();
            _settings.SetBrightness(77);
            _settings.InformationAboutRemoteControl();
            _power.TurnOff();
        }
    }
}
