namespace Maui_hello_world;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
			CounterBtn.Text = "Hello world";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

