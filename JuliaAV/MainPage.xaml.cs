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

public MainPage()
{
	var timer=Application.Current.Dispatcher.CreateTimer();
	timer.Interval=TimeSpan.FromSeconds(1);
	timer.Tick =+(s,e)=>PassouTempo();
}
void PassouTempo()
{
	Atual 
}


