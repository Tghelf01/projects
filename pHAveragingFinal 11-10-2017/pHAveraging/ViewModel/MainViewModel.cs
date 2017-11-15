using pHAveraging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pHAveraging.ViewModel
{
    class MainViewModel
    {
        public pHAveragingViewModel PhValue { get; private set; }

        public MainViewModel()
        {
            PhValue = new pHAveragingViewModel();
        }
    }
}
