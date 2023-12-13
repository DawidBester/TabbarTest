using System.Diagnostics;

namespace TabbarTest;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

		protected async override void OnAppearing()
    {        
        base.OnAppearing();
     
		Debug.WriteLine($"******* Page3 ******** ({Shell.Current?.CurrentItem.CurrentItem.Title})");

	}
}