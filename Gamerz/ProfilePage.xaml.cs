using Gamerz.ViewModel;
using GamerZ_Lib;

namespace Gamerz;

public partial class ProfilePage : ContentPage
{

	internal ProfileViewModel viewModel { get; set; }

	public ProfilePage()
	{
		InitializeComponent();
		ShowDefaultValue();
    }

	public void ShowDefaultValue()
	{
		viewModel = new ProfileViewModel();
        Content.BindingContext = viewModel.Player;
    }
}