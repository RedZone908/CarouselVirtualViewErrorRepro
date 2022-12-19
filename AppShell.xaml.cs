namespace MauiAppRepro1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("Page2", typeof(Page2));
    }
}
