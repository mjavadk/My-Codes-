using System;
using Xamarin.Forms;

namespace XamApp.Views
{
	
	public partial class VerificationView
	{
		public VerificationView ()
		{
			InitializeComponent ();
		}


	    private void VisualElement_OnFocused(object sender, FocusEventArgs e)
	    {
	       frame1.BackgroundColor = Color.Gray;
           frame1.BorderColor = Color.Black;
	       Button0.Margin = new Thickness(0,20,0,250);

	    }
	    private void VisualElement_OnFocused1(object sender, FocusEventArgs e)
	    {
	        frame2.BackgroundColor = Color.Gray;
	        frame2.BorderColor = Color.Black;
	        Button0.Margin = new Thickness(0, 20, 0, 250);
        }
	    private void VisualElement_OnFocused2(object sender, FocusEventArgs e)
	    {
	        frame3.BackgroundColor = Color.Gray;
	        frame3.BorderColor = Color.Black;
	        Button0.Margin = new Thickness(0, 20, 0, 250);
        }
        private void VisualElement_OnFocused3(object sender, FocusEventArgs e)
	    {
	        frame4.BackgroundColor = Color.Gray;
	        frame4.BorderColor = Color.Black;
	        Button0.Margin = new Thickness(0, 20, 0, 250);
        }


	    private void VisualElement_OnUnfocused(object sender, FocusEventArgs e)
	    {
	        frame1.BackgroundColor = Color.White;
	        frame1.BorderColor = Color.Gray;
	        Button0.Margin = new Thickness(0, 0, 0, 10);
        }
	    private void VisualElement_OnUnfocused1(object sender, FocusEventArgs e)
	    {
	        frame2.BackgroundColor = Color.White;
	        frame2.BorderColor = Color.Gray;
	        Button0.Margin = new Thickness(0, 0, 0, 10);
        }
	    private void VisualElement_OnUnfocused2(object sender, FocusEventArgs e)
	    {
	        frame3.BackgroundColor = Color.White;
	        frame3.BorderColor = Color.Gray;
	        Button0.Margin = new Thickness(0, 0, 0, 10);
        }
	    private void VisualElement_OnUnfocused3(object sender, FocusEventArgs e)
	    {
	        frame4.BackgroundColor = Color.White;
	        frame4.BorderColor = Color.Gray;
	        Button0.Margin = new Thickness(0, 0, 0, 10);
        }


	}
}