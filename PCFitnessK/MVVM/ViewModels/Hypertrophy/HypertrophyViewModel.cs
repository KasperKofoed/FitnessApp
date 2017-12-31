using PCFitnessK.MVVM.Models;
using PCFitnessK.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels.Hypertrophy
{
    public class HypertrophyViewModel : ViewModelBase
    {
        private List<int> _repRange;
        private HypertrophyData _dataStorage;

        public HypertrophyViewModel()
        {
            _repRange = new List<int>() { 8, 12, 15 };
            _dataStorage = new HypertrophyData();

        }

        public List<int> GetRepRange { get {return _repRange; } set {value = _repRange; } }
        public HypertrophyData DataStorage { get {return _dataStorage; } set { value = _dataStorage; } }

        //private string ItemIsSelected
        //{

        //}

    }
}
