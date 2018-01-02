using PCFitnessK.DataStorage;
using PCFitnessK.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels
{
    public class _1RepMaxCalcViewModel : ViewModelBase
    {
        private List<double> _repRange;
        private double _weightLifted;
        private double _calculatedResults;
        private _1RepMaxCalcDataStorage _dataStorage;

        public _1RepMaxCalcViewModel(double CalculatedResults, double WeightLifted)
        {
            _repRange = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            _weightLifted = WeightLifted;
            _calculatedResults = CalculatedResults;
            _dataStorage = new _1RepMaxCalcDataStorage();
        }

        public List<double> GetRepRange { get { return _repRange; } set { value = _repRange; } }
        public _1RepMaxCalcDataStorage DataStorage { get { return _dataStorage; } set { value = _dataStorage; } }

        public double Calculate1RepMax { get { return _calculatedResults; } }

        public double TotalWeightLifted { get { return _weightLifted; } set { value = _weightLifted; } }


    }
}


