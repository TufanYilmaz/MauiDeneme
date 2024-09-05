using DataAccess.Abstract;

namespace MauiDeneme
{
	public partial class MainPage : ContentPage
	{
		int count = 0;
		private readonly IAuth _authService;

		public MainPage(IAuth authService)
		{
			_authService = authService;
			InitializeComponent();
		}

		private async void OnCounterClicked(object sender, EventArgs e)
		{
			if (count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";
			count++;

			var res = await _authService.ChallengeAuth("deneme", "deneme");
			if (res && count>3)
			{
				await Navigation.PushAsync(new LandingPage());
			}
			await DisplayAlert("Uyarı !", "Daha Yeerince basılmadı", "iptal");
			

			SemanticScreenReader.Announce(CounterBtn.Text);
		}
	}

}
