using SmartHotel.Clients.Core.Helpers;
using SmartHotel.Clients.Core.ViewModels.Base;
using Xamarin.Forms;
using Tizen;

namespace SmartHotel.Clients.Core.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            this.BookRoomButton.Focused += Button_Focused;
            this.BookRoomButton.Unfocused += Button_Unfocused;
            this.BookConferenceButton.Focused += Button_Focused;
            this.BookConferenceButton.Unfocused += Button_Unfocused;
            this.SuggestionsButton.Focused += Button_Focused;
            this.SuggestionsButton.Unfocused += Button_Unfocused;
            this.BookRestaurantButton.Focused += Button_Focused;
            this.BookRestaurantButton.Unfocused += Button_Unfocused;

            this.GoMyRoomButton.Focused += Button_Focused;
            this.GoMyRoomButton.Unfocused += Button_Unfocused;
            this.SuggestionsButtonInBooking.Focused += Button_Focused;
            this.SuggestionsButtonInBooking.Unfocused += Button_Unfocused;
            this.BookConferenceButtonInBooking.Focused += Button_Focused;
            this.BookConferenceButtonInBooking.Unfocused += Button_Unfocused;
        }

        private void Button_Unfocused(object sender, FocusEventArgs e)
        {
            var button = sender as Button;
            if (button != null) {
                button.Opacity = 0.0;
            }
        }

        private void Button_Focused(object sender, FocusEventArgs e)
        {
            var button = sender as Button;
            if (button != null) {
                button.Opacity = 0.3;
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(true);

            if (BindingContext is IHandleViewAppearing viewAware)
            {
                await viewAware.OnViewAppearingAsync(this);
            }
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();

            if (BindingContext is IHandleViewDisappearing viewAware)
            {
                await viewAware.OnViewDisappearingAsync(this);
            }
        }
    }
}