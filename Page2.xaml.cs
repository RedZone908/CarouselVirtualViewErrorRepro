using System.Collections.ObjectModel;

namespace MauiAppRepro1;

public partial class Page2 : ContentPage
{
	public ObservableCollection<string> Values { get; set; } = new();

	public Page2()
	{
		InitializeComponent();

		this.BindingContext = this;
    }

	private async void Button_Pressed(object sender, EventArgs e)
	{
		Values.Clear();

		await Task.Delay(1000);

		for (int i = 1; i <= 5; i++)
			Values.Add($"Item #{i}");
    }
}