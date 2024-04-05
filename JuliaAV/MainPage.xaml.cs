namespace JuliaAV;

public partial class MainPage : ContentPage
{
	 BlackCat BlackCat; OrangeCat OrangeCat; WhiteCat WhiteCat; Personagem Atual;

	public MainPage()
	{
		InitializeComponent();
		BlackCat=new BlackCat();
		OrangeCat=new OrangeCat();
		WhiteCat=new WhiteCat();
		Atual=BlackCat
		imgPersonagem.Source=Atual.GetArquivo
	}

	 void OnChangeCharacterClick(object sender, EventArgs args)
	{
		if (Atual==BlackCat)
			Atual=OrangeCat;
		else if(Atual==OrangeCat)
			Atual=BlackCat;
		else if(Atual==OrangeCat)
			Atual=WhiteCat;
		imgPersonagem.Source=Atual.GetArquivo();
	}
	 void OnDrinkClicked(object sender, EventArgs args)
	 {
			frameOnDrinkClicked.IsVisible = true;
	 }
	 void OnFoodClicked(object sender, EventArgs args)
	 {
			frameOnFoodClicked.IsVisible = true;
	 }
	 void OnPlayClicked(object sender, EventArgs args)
	{
			frameOnPlayClicked.IsVisible = true;
	}
}

