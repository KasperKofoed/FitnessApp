using PCFitnessK.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.DataStorage
{
    public class RepMaxCalcDataStorage : ViewModelBase
    {
        private int _repRange;
        private double _weightUsed;

        public int CalculateRepRange { get { return _repRange; } set { value = _repRange; } }
        public double CalculateWeightUsed { get { return _weightUsed; } set { value = _weightUsed; } }

    }
}
