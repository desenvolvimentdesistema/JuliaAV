using Windows.Media.Control;

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
		Atual=BlackCat;
		imgCharacter.Source=Atual.GetArquivo();

		var timer=Application.Current.Dispatcher.CreateTimer();
	timer.Interval=TimeSpan.FromSeconds(1);
	timer.Tick += (s,e) => PassouTempo();
	timer.Start();
	}

	 void OnChangeCharacterClick(object sender, EventArgs args)
	{
		if (Atual==BlackCat)
			Atual=OrangeCat;
		else if(Atual==OrangeCat)
			Atual=BlackCat;
		else if(Atual==OrangeCat)
			Atual=WhiteCat;
		imgCharacter.Source=Atual.GetArquivo();
	}
	

void PassouTempo()
{
	BlackCat.SetDrink(BlackCat.GetDrink()-0.1);
	BlackCat.SetFood(BlackCat.GetFood()-0.2);
	BlackCat.SetPlay(BlackCat.GetPlay()-0.3);

	OrangeCat.SetDrink(OrangeCat.GetDrink()-0.1);
	OrangeCat.SetFood(OrangeCat.GetFood()-0.2);
	OrangeCat.SetPlay(OrangeCat.GetPlay()-0.3);

	WhiteCat.SetDrink(WhiteCat.GetDrink()-0.1);
	WhiteCat.SetFood(WhiteCat.GetFood()-0.2);
	WhiteCat.SetPlay(WhiteCat.GetPlay()-0.3);
}
void AtualizaCharacter()
{
	imgCharacter.Source = Atual.GetArquivo();
	Drink.Progress = Atual.GetDrink();
	Food.Progress = Atual.GetFood();
	Play.Progress = Atual.GetPlay();
}
void DrinkCharacter(object sender, EventArgs args)
{
	Atual.SetDrink(Atual.GetDrink()+0.1);
	AtualizaCharacter();
}
void FoodCharacter(object sender, EventArgs args)
{
	Atual.SetFood(Atual.GetFood()+0.1);
	AtualizaCharacter();
}
void PlayCharacter(object sender, EventArgs args)
{
	Atual.SetPlay(Atual.GetPlay()+0.1);
	AtualizaCharacter();
}
}


