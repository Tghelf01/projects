using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pHAveraging
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public bool ChangeAndNotify<generic>(ref generic memberVariable, generic value,
            [CallerMemberName] string propertyName = null /* It obtains the property name 
            of the property that is calling this method. or propertyName = "" */)
        {
            if (!EqualityComparer<generic>.Default.Equals(memberVariable, value))
            {
                memberVariable = value;
                OnPropertyChanged(propertyName);
                return true;
            }
            return false;
        }
    }
}
