using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlLibrary;

namespace RemoteControlDecorator
{
    public class ChannelDriver : Driver
    {
        private Channel _channel;

        public ChannelDriver(Channel channel)
        {
            _channel = channel;
        }

        public override void Operation()
        {
            _channel.List();
            _channel.Previous();
            _channel.Next();
            _channel.Next();
            _channel.ForNumber(7);
        }
    }
}
