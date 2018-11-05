using SmartHotel.Clients.Core.Helpers;
using Xamarin.Forms;

namespace SmartHotel.Clients.Core.Views
{
    public partial class BookingView : ContentPage
    {
        public BookingView()
        {
            if (Device.RuntimePlatform != Device.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            NavigationPage.SetBackButtonTitle(this, string.Empty);

            InitializeComponent();

            this.NextButton.Focused += Button_Focused;
            this.NextButton.Unfocused += Book_Unfocused;
        }

        private void Book_Unfocused(object sender, FocusEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Opacity = 0.0;
            }
        }

        private void Button_Focused(object sender, FocusEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Opacity = 0.2;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(true);
        }
    }
}