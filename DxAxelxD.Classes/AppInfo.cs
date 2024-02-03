using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.DxAxelxD.Classes
{
    internal class AppInfo
    {
        string name;
        TimeSpan timeInUse;
        public AppInfo(string _name) : this(_name,new TimeSpan(0)) { }
        public AppInfo(string _name, TimeSpan _timeInUse)
        {
            name = _name;
            timeInUse = _timeInUse;
        }
        public void UpdateAppTime(TimeSpan _timeInUse)
        {
            timeInUse = _timeInUse;
        }
    }
}
