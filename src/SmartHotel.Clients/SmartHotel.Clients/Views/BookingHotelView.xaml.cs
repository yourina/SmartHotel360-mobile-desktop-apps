using Xamarin.Forms;
using SmartHotel.Clients.Core.Helpers;

namespace SmartHotel.Clients.Core.Views
{
    public partial class BookingHotelView : ContentPage
    {
        private const int ParallaxSpeed = 4;

        private double _lastScroll;

        private Grid PreGrid = null;

        public BookingHotelView()
        {
            if (Device.RuntimePlatform != Device.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            NavigationPage.SetBackButtonTitle(this, string.Empty);

            InitializeComponent();

            this.HotelButton.Focused += TabFocused;
            this.HotelButton.Unfocused += TabUnfocused;
            this.RoomsButton.Focused += TabFocused;
            this.RoomsButton.Unfocused += TabUnfocused;
            this.ReviewsButton.Focused += TabFocused;
            this.ReviewsButton.Unfocused += TabUnfocused;
            this.BookNowButton.Focused += Button_Focused;
            this.BookNowButton.Unfocused += Button_Unfocused;
        }

        private void TabUnfocused(object sender, FocusEventArgs e)
        {
            PreGrid.IsVisible = false;
        }

        private void TabFocused(object sender, FocusEventArgs e)
        {
            var button = sender as Button;
            if (button == this.HotelButton)
            {
                PreGrid = this.HotelGrid;
            }
            else if (button == this.RoomsButton)
            {
                PreGrid = this.RoomGrid;
            }
            else if (button == this.ReviewsButton)
            {
                PreGrid = this.ReviewsGrid;
            }
            PreGrid.IsVisible = true;
        }

        private void Button_Unfocused(object sender, FocusEventArgs e)
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
                button.Opacity = 0.6;
            }
        }

        protected override void OnAppearing()
        {
            base.OnDisappearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(false);

            ParallaxScroll.ParallaxView = HeaderView;
            ParallaxScroll.Scrolled += OnParallaxScrollScrolled;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            ParallaxScroll.Scrolled -= OnParallaxScrollScrolled;
        }

        private void OnParallaxScrollScrolled(object sender, ScrolledEventArgs e)
        {
            double translation = 0;

            if (_lastScroll == 0)
            {
                _lastScroll = e.ScrollY;
            }

            if (_lastScroll < e.ScrollY)
            {
                translation = 0 - ((e.ScrollY / ParallaxSpeed));

                if (translation > 0) translation = 0;
            }
            else
            {
                translation = 0 + ((e.ScrollY / ParallaxSpeed));

                if (translation > 0) translation = 0;
            }

            SubHeaderView.FadeTo(translation < -40 ? 0 : 1);
   
            _lastScroll = e.ScrollY;
        }
    }
}