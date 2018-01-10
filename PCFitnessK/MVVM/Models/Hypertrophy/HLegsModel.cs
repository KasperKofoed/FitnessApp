using PCFitnessK.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace PCFitnessK.MVVM.Models.Hypertrophy
{
    public class HLegsModel 
    {
        #region Fields
        private double _itemSelectedSquatReps;
        private double _itemSelectedSquatSets;
        private double _WeightSquat;

        private double _itemSelectedLegPressReps;
        private double _itemSelectedLegPressSets;
        private double _WeightLegPress;

        private double _itemSelectedLungesReps;
        private double _itemSelectedLungesSets;
        private double _WeightLunge;

        private double _itemSelectedHamstringCurlReps;
        private double _itemSelectedHamstringCurlSets;
        private double _WeightHamstringCurl;

        private double _itemSelectedQuadExtensionsReps;
        private double _itemSelectedQuadExtensionsSets;
        private double _WeightQuadExtension;

        private double _itemSelectedOuterThighPressReps;
        private double _itemSelectedOuterThighPressSets;
        private double _WeightOuterThighPress;
        #endregion

        #region Constructor
        public HLegsModel(double SquatReps, double SquatSets, double SquatWeight,
                          double LegPressReps, double LegPressSets, double LegPressWeight,
                          double LungeReps, double LungeSets, double LungeWeight,
                          double HamstringReps, double HamstringSets, double HamstringWeight,
                          double QuadReps, double QuadSets, double QuadWeight,
                          double OuterThighReps, double OuterThighSets, double OuterThighWeight)
        {
            _itemSelectedSquatReps = SquatReps;
            _itemSelectedSquatSets = SquatSets;
            _WeightSquat = SquatWeight;

            _itemSelectedLegPressReps = LegPressReps;
            _itemSelectedLegPressSets = LegPressSets;
            _WeightLegPress = LegPressWeight;

            _itemSelectedLungesReps = LungeReps;
            _itemSelectedLungesSets = LungeSets;
            _WeightLunge = LungeWeight;

            _itemSelectedHamstringCurlReps = HamstringReps;
            _itemSelectedHamstringCurlSets = HamstringSets;
            _WeightHamstringCurl = HamstringWeight;

            _itemSelectedQuadExtensionsReps = QuadReps;
            _itemSelectedQuadExtensionsSets = QuadSets;
            _WeightQuadExtension = QuadWeight;

            _itemSelectedOuterThighPressReps = OuterThighReps;
            _itemSelectedOuterThighPressSets = OuterThighSets;
            _WeightOuterThighPress = OuterThighWeight;
        }
        #endregion

        #region Properties
        public double ItemSelectedSquatRepsModel
        {
            get { return _itemSelectedSquatReps; }
            set { _itemSelectedSquatReps = value; }
        }

        public double ItemSelectedSquatSetsModel
        {
            get { return _itemSelectedSquatSets; }
            set { _itemSelectedSquatSets = value; }
        }

        public double WeightSquatModel
        {
            get { return _WeightSquat; }
            set { _WeightSquat = value; }
        }

        public double ItemSelectedLegPressRepsModel
        {
            get { return _itemSelectedLegPressReps; }
            set { _itemSelectedLegPressReps = value;}
        }

        public double ItemSelectedLegPressSetsModel
        {
            get { return _itemSelectedLegPressSets; }
            set { _itemSelectedLegPressSets = value; }
        }

        public double WeightLegPressModel
        {
            get { return _WeightLegPress; }
            set { _WeightLegPress = value; }
        }

        public double ItemSelectedLungesRepsModel
        {
            get { return _itemSelectedLungesReps; }
            set { _itemSelectedLungesReps = value; }
        }

        public double ItemSelectedLungesSetsModel
        {
            get { return _itemSelectedLungesSets; }
            set { _itemSelectedLungesSets = value; }
        }

        public double WeightLungeModel
        {
            get { return _WeightLunge; }
            set { _WeightLunge = value; }
        }

        public double ItemSelectedHamstringCurlRepsModel
        {
            get { return _itemSelectedHamstringCurlReps; }
            set { _itemSelectedHamstringCurlReps = value; }
        }

        public double ItemSelectedHamstringCurlSetsModel
        {
            get { return _itemSelectedHamstringCurlSets; }
            set { _itemSelectedHamstringCurlSets = value;}
        }

        public double WeightHamstringCurlModel
        {
            get { return _WeightHamstringCurl; }
            set { _WeightHamstringCurl = value; }
        }

        public double ItemSelectedQuadExtensionsRepsModel
        {
            get { return _itemSelectedQuadExtensionsReps; }
            set { _itemSelectedQuadExtensionsReps = value; }
        }

        public double ItemSelectedQuadExtensionsSetsModel
        {
            get { return _itemSelectedQuadExtensionsSets; }
            set { _itemSelectedQuadExtensionsSets = value; }
        }

        public double WeightQuadExtensionModel
        {
            get { return _WeightQuadExtension; }
            set { _WeightQuadExtension = value; }
        }

        public double ItemSelectedOuterThighPressRepsModel
        {
            get { return _itemSelectedOuterThighPressReps; }
            set { _itemSelectedOuterThighPressReps = value;}
        }

        public double ItemSelectedOuterThighPressSetsModel
        {
            get { return _itemSelectedOuterThighPressSets; }
            set { _itemSelectedOuterThighPressSets = value;}
        }

        public double WeightOuterThighPressModel
        {
            get { return _WeightOuterThighPress; }
            set { _WeightOuterThighPress = value;}
        }
        #endregion
    }
}


