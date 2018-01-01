using PCFitnessK.DataStorage;
using PCFitnessK.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels.Power
{
    public class PLegsViewModel : ViewModelBase
    {
        private List<int> _repRange;
        private PLegsDataStorage _dataStorage;

        public PLegsViewModel()
        {
            _repRange = new List<int>() { 1, 5, 8, 12, 15 };
            _dataStorage = new PLegsDataStorage();
        }

        public List<int> GetRepRange { get { return _repRange; } set {value = _repRange ; } }
        public PLegsDataStorage DataStorage { get {return _dataStorage; } set { value = _dataStorage; } }


        //private string ItemIsSelected
        //{

        //}
    }
}
