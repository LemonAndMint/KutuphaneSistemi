namespace KutuphaneSistemi;

public partial class App : Application
{
	public App()
	{

		new TestBackEnd();

		InitializeComponent();

        MainPage = new AppShell();
	}
}
