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

        public RepMaxCalcDataStorage()
        {

        }

        public int CalculateRepRange
        {
            get { return _repRange; }
            set { _repRange = value; OnPropertyChanged(); }
        }

        public double CalculateWeightUsed
        {
            get { return _weightUsed; }
            set { _weightUsed = value; OnPropertyChanged(); }
        }

    }
}
