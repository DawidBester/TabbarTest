using System.Diagnostics;

namespace TabbarTest;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

	protected async override void OnAppearing()
    {        
        base.OnAppearing();
     
		Debug.WriteLine($"******* Page1 ******** ({Shell.Current?.CurrentItem.CurrentItem.Title})");

	}

}