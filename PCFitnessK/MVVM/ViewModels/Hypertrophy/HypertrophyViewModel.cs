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
        private HypertrophyData _dataStorage;

        public HypertrophyViewModel()
        {  
            _dataStorage = new HypertrophyData();
        }

        
        public HypertrophyData DataStorage { get {return _dataStorage; } set { value = _dataStorage; } }

        //private string ItemIsSelected
        //{

        //}

    }
}
