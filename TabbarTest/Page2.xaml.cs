using System.Diagnostics;
using System.Windows.Input;

namespace TabbarTest;

public partial class Page2 : ContentPage
{
    
    private int _counter;

    public int Counter
    {
        get { return _counter; }
        set
        {
            _counter = value;
            OnPropertyChanged();
          
        }
    }

	public Page2()
	{
		InitializeComponent();
	}

	protected async override void OnAppearing()
    {        
        base.OnAppearing();
     
		Debug.WriteLine($"******* Page2 ******** ({Shell.Current?.CurrentItem.CurrentItem.Title})");

        if (Shell.Current?.CurrentItem.CurrentItem.Title == "Page2A")
        {
            Debug.WriteLine($"******* Page2A ********");
            Page2AGrid.IsVisible = true;
            Page2BGrid.IsVisible = false;

        }
        else
        {
            Debug.WriteLine($"******* Page2B ********");
            Page2AGrid.IsVisible = false;
            Page2BGrid.IsVisible = true;
                        
        }

    }


    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Counter++;
    }
}