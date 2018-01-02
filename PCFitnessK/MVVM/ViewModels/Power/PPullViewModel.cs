using PCFitnessK.MVVM.Models;
using PCFitnessK.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels.Power
{
    public class PPullViewModel : ViewModelBase
    {

        private List<int> _repRange;
        private List<int> _sets;
        private PPullDataStorage _dataStorange;

        public PPullViewModel()
        {
            _repRange = new List<int>() { 1, 5, 8, 12, 15 };
            _sets = new List<int>() { 1, 2, 3, 4, 5, 6 };
            _dataStorange = new PPullDataStorage();
        }

        public List<int> GetRepRange { get { return _repRange; } set { value = _repRange; } }
        public PPullDataStorage DataStorage { get { return _dataStorange; } set { value = _dataStorange; } }
        public List<int> GetSets { get { return _sets; } set { value = _sets; } }

        //private string ItemISSelected
        //{

        //}
    }
}
