using Plugin.Maui.Scanner;

namespace Plugin.Maui.Scanner.Sample;

public partial class MainPage : ContentPage
{
	readonly IFeature feature;

	public MainPage(IFeature feature)
	{
		InitializeComponent();
		
		this.feature = feature;
	}
}
