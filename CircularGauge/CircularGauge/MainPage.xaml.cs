using Syncfusion.SfGauge.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CircularGauge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }

    public class ViewModel
    {
        public ObservableCollection<Scale> Scales
        {
            get;
            set;
        }
        public ViewModel()
        {
            Scales = new ObservableCollection<Scale>()
            {
                new Scale()
                {
                    StartValue =0, EndValue=240,
                    Interval =20, MinorTicksPerInterval=1,
                    LabelOffset =0.8
                },

                new Scale()
                {
                    StartValue =0,EndValue=160,
                    Interval =40,MinorTicksPerInterval=1,LabelOffset=0.45,
                    ScaleStartOffset =0.6, ScaleEndOffset =0.58,
                    MajorTickSettings =new TickSettings(){ StartOffset=0.58,EndOffset=0.53 },
                    MinorTickSettings =new TickSettings(){ StartOffset=0.58,EndOffset=0.54 }
                }
            };
        }
    }
}
