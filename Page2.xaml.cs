using System.Collections.ObjectModel;

namespace MauiAppRepro1;

public partial class Page2 : ContentPage
{
	public ObservableCollection<Foo> FooImages { get; set; } = new();

	public Page2()
	{
		InitializeComponent();

		this.BindingContext = this;
    }

	private async void Button_Pressed(object sender, EventArgs e)
	{
		FooImages.Clear();

		await Task.Delay(1000);

		FooImages.Add(new Foo { ImagePath = "red_mm.png" });
		FooImages.Add(new Foo { ImagePath = "yellow_mm.png" });
		FooImages.Add(new Foo { ImagePath = "blue_mm.png" });
		FooImages.Add(new Foo { ImagePath = "orange_mm.png" });
    }
}