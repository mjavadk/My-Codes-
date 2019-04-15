using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class Profiles
    {
        public string name { get; set; }
    }
	public partial class FinishedSevicesView : ContentPage
	{

		public FinishedSevicesView ()
		{
			InitializeComponent ();

           
        }

	    protected override void OnAppearing()
	    {


            profileListview.ItemsSource = new List<Profiles>
                       {
                           new Profiles { name = "خودم"},
                           new Profiles { name = "احمد"},
                           new Profiles { name = "رضا"},
                           new Profiles { name = "مرتضی"},
                           new Profiles { name = "علی"},
                           new Profiles { name = "محمد"},
            
                       };
	        
	    }
	}
}