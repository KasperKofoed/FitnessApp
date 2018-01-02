using PCFitnessK.DataStorage;
using PCFitnessK.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels
{
    public class OneRepMaxCalcViewModel : ViewModelBase
    {
        private List<double> _repRange;
        private _1RepMaxCalcDataStorage _dataStorage;

        public OneRepMaxCalcViewModel ()
        {
            _repRange = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            _dataStorage = new _1RepMaxCalcDataStorage();
        }

        public List<double> GetRepRange { get { return _repRange; } set { value = _repRange; } }
        public _1RepMaxCalcDataStorage DataStorage { get { return _dataStorage; } set { value = _dataStorage; } }

        
     
    }
}

