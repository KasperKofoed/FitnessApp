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
        private List<int> _sets;
        private PLegsDataStorage _dataStorage;

        public PLegsViewModel()
        {
            _repRange = new List<int>() { 1, 5, 8, 12, 15 };
            _sets = new List<int>() { 1, 2, 3, 4, 5, 6 };
            _dataStorage = new PLegsDataStorage();
        }

        public List<int> GetRepRange { get { return _repRange; } set {value = _repRange ; } }
        public PLegsDataStorage DataStorage { get {return _dataStorage; } set { value = _dataStorage; } }
        public List<int> GetSets { get { return _sets; } set { value = _sets; } }

        //private string ItemIsSelected
        //{

        //}
    }
}
