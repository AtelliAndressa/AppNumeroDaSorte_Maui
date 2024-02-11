using Microsoft.Maui.Controls;

namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumbers(object sender, EventArgs e)
    {	
		//sender é o botão
        //((Button)sender).Text = "";
        NameApp.IsVisible = false;
		ContainerLuckNumbers.IsVisible = true;

		var list = GenerateLuckNumbers();

		LuckNumber01.Text = list.ElementAt(0).ToString("D2");
		LuckNumber02.Text = list.ElementAt(1).ToString("D2");
		LuckNumber03.Text = list.ElementAt(2).ToString("D2");
		LuckNumber04.Text = list.ElementAt(3).ToString("D2");
		LuckNumber05.Text = list.ElementAt(4).ToString("D2");
		LuckNumber06.Text = list.ElementAt(5).ToString("D2");
 	}

	/// <summary>
	/// Gerando os números da sorte.
	/// </summary>
	private SortedSet<int> GenerateLuckNumbers()
	{
		//SortedSet não deixa os elementos se repetirem e os ordena de forma crescente.
		var list = new SortedSet<int>();

		while(list.Count < 6)
		{
            var random = new Random();
            var luckNumber = random.Next(0, 60);

            list.Add(luckNumber);
        }
		return list;		
	}
}