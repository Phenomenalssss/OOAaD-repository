using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlProxy
{
    public class Proxy : IDriver
    {
        private Role _role;
        private IDriver _driver;

        public Proxy(IDriver driver, Role role) 
        {
            _driver = driver;
            _role = role;
        }

        public void Operation()
        {
            if (CheckRole() == true)
            {
                Console.WriteLine("Добро пожаловать, Администратор");
                _driver.Operation();
            }
            else
            {
                Console.WriteLine("Доступ запрещён");
            }
        }

        public bool CheckRole()
        {
            if (_role == Role.Admin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
