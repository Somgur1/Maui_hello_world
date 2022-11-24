namespace Maui_hello_world;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    
	string name = "";

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
		name = inputfield.Text;
        CounterBtn.Text = $"Hello {name}";

    }

 //   void OnEtryCompleted(object sender, EventArgs e)
	//{
	//	name = inputfield.Text;
 //       CounterBtn.Text = $"Hello {name}";
 //   }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		
			CounterBtn.Text = $"Hello {name}";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

