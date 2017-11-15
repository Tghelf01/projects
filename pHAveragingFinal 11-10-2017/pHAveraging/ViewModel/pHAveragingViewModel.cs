using pHAveraging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pHAveraging.ViewModel
{
    public class pHAveragingViewModel : ObservableObject
    {
        private double _ph1;
        private double _ph2;
        private double _ph3;
        private double _ph4;
        private double _ph5;
        private double _ph6;
        private double _ph7;
        private double _ph8;
        private double _ph9;
        private double _ph10;
        private double _ph11;
        private double _ph12;
        private double _ph13;
        private double _ph14;
        private double _ph15;
        private double _ph16;
        private double _ph17;
        private double _ph18;
        private double _ph19;
        private double _ph20;

        private double _calc_average;

        public double CalcAverage
        {
            get
            {
                return _calc_average;
            }
            set
            {
                ChangeAndNotify(ref _calc_average, value);
            }
        }

        public double pH1
        {
            get
            {
                return _ph1;
            }
            set
            {
                ChangeAndNotify(ref _ph1, value);
                myListAverage();
            }
        }

        private void myListAverage()
        {
            
            
            List<double> myList = new List<double>();

            if (!pH1.Equals(0))
            {
                myList.Add(pH1);
            }

            if (!pH2.Equals(0))
            {
                myList.Add(pH2);
            }
            if (!pH3.Equals(0))
            {
                myList.Add(pH3);
            }
            if (!pH4.Equals(0))
            {
                myList.Add(pH4);
            }
            if (!pH5.Equals(0))
            {
                myList.Add(pH5);
            }
            if (!pH6.Equals(0))
            {
                myList.Add(pH6);
            }
            if (!pH7.Equals(0))
            {
                myList.Add(pH7);
            }
            if (!pH8.Equals(0))
            {
                myList.Add(pH8);
            }
            if (!pH9.Equals(0))
            {
                myList.Add(pH9);
            }
            if (!pH10.Equals(0))
            {
                myList.Add(pH10);
            }
            if (!pH11.Equals(0))
            {
                myList.Add(pH11);
            }
            if (!pH12.Equals(0))
            {
                myList.Add(pH12);
            }
            if (!pH13.Equals(0))
            {
                myList.Add(pH13);
            }
            if (!pH14.Equals(0))
            {
                myList.Add(pH14);
            }
            if (!pH15.Equals(0))
            {
                myList.Add(pH15);
            }
            if (!pH16.Equals(0))
            {
                myList.Add(pH16);
            }
            if (!pH17.Equals(0))
            {
                myList.Add(pH17);
            }
            if (!pH18.Equals(0))
            {
                myList.Add(pH18);
            }
            if (!pH19.Equals(0))
            {
                myList.Add(pH19);
            }
            if (!pH20.Equals(0))
            {
                myList.Add(pH20);
            }
                
            CalcAverage = pHCalculations.CalcAverage(myList);
            OnPropertyChanged(nameof(CalcAverage));
        }


        public double pH2
        {
            get
            {
                return _ph2;
            }
            set
            {
                ChangeAndNotify(ref _ph2, value);
                myListAverage();
            }
        }

        public double pH3
        {
            get
            {
                return _ph3;
            }
            set
            {
                ChangeAndNotify(ref _ph3, value);
                myListAverage();
            }
        }

        public double pH4
        {
            get
            {
                return _ph4;
            }
            set
            {
                ChangeAndNotify(ref _ph4, value);
                myListAverage();
            }
        }

        public double pH5
        {
            get
            {
                return _ph5;
            }
            set
            {
                ChangeAndNotify(ref _ph5, value);
                myListAverage();
            }
        }

        public double pH6
        {
            get
            {
                return _ph6;
            }
            set
            {
                ChangeAndNotify(ref _ph6, value);
                myListAverage();
            }
        }

        public double pH7
        {
            get
            {
                return _ph7;
            }
            set
            {
                ChangeAndNotify(ref _ph7, value);
                myListAverage();
            }
        }

        public double pH8
        {
            get
            {
                return _ph8;
            }
            set
            {
                ChangeAndNotify(ref _ph8, value);
                myListAverage();
            }
        }

        public double pH9
        {
            get
            {
                return _ph9;
            }
            set
            {
                ChangeAndNotify(ref _ph9, value);
                myListAverage();
            }
        }

        public double pH10
        {
            get
            {
                return _ph10;
            }
            set
            {
                ChangeAndNotify(ref _ph10, value);
                myListAverage();
            }
        }

        public double pH11
        {
            get
            {
                return _ph11;
            }
            set
            {
                ChangeAndNotify(ref _ph11, value);
                myListAverage();
            }
        }

        public double pH12
        {
            get
            {
                return _ph12;
            }
            set
            {
                ChangeAndNotify(ref _ph12, value);
                myListAverage();
            }
        }

        public double pH13
        {
            get
            {
                return _ph13;
            }
            set
            {
                ChangeAndNotify(ref _ph13, value);
                myListAverage();
            }
        }

        public double pH14
        {
            get
            {
                return _ph14;
            }
            set
            {
                ChangeAndNotify(ref _ph14, value);
                myListAverage();
            }
        }

        public double pH15
        {
            get
            {
                return _ph15;
            }
            set
            {
                ChangeAndNotify(ref _ph15, value);
                myListAverage();
            }
        }

        public double pH16
        {
            get
            {
                return _ph16;
            }
            set
            {
                ChangeAndNotify(ref _ph16, value);
                myListAverage();
            }
        }

        public double pH17
        {
            get
            {
                return _ph17;
            }
            set
            {
                ChangeAndNotify(ref _ph17, value);
                myListAverage();
            }
        }

        public double pH18
        {
            get
            {
                return _ph18;
            }
            set
            {
                ChangeAndNotify(ref _ph18, value);
                myListAverage();
            }
        }

        public double pH19
        {
            get
            {
                return _ph19;
            }
            set
            {
                ChangeAndNotify(ref _ph19, value);
                myListAverage();
            }
        }

        public double pH20
        {
            get
            {
                return _ph20;
            }
            set
            {
                ChangeAndNotify(ref _ph20, value);
                myListAverage();
            }
        }
    }
}
