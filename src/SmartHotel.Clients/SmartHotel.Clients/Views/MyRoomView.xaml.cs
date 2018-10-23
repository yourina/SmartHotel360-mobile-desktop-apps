using SmartHotel.Clients.Core.Helpers;
using Xamarin.Forms;
using Tizen;

namespace SmartHotel.Clients.Core.Views
{
    public partial class MyRoomView : ContentPage
    {
        Grid PreGrid = null;

        public MyRoomView()
        {
            InitializeComponent();
            this.AmbientSettingButton.Focused += TabFocused;
            this.AmbientSettingButton.Unfocused += TabUnfocused;
            this.NeedButton.Focused += TabFocused;
            this.NeedButton.Unfocused += TabUnfocused;
            this.FindButton.Focused += TabFocused;
            this.FindButton.Unfocused += TabUnfocused;

            this.CheckoutButton.Focused += CheckoutButton_Focused;
            this.CheckoutButton.Unfocused += CheckoutButton_Unfocused;

            this.DisturbButton.Focused += DisturbButton_Focused;
            this.DisturbButton.Unfocused += DisturbButton_Unfocused;

            this.EcoModeButton.Focused += Button_Focused;
            this.EcoModeButton.Unfocused += Button_Focused;

            this.IceButton.Focused += Button_Focused;
            this.IceButton.Unfocused += Button_Focused;

            this.ToothbrushButton.Focused += Button_Focused;
            this.ToothbrushButton.Unfocused += Button_Focused;

            this.TowelsButton.Focused += Button_Focused;
            this.TowelsButton.Unfocused += Button_Focused;

            this.LeakButton.Focused += Button_Focused;
            this.LeakButton.Unfocused += Button_Focused;
        }

        private void TabUnfocused(object sender, FocusEventArgs e)
        {
            PreGrid.IsVisible = false;
        }

        private void TabFocused(object sender, FocusEventArgs e)
        {
            var button = sender as Button;
            if (button == this.AmbientSettingButton)
            {
                PreGrid = this.AmbientGrid;
            }
            else if (button == this.NeedButton)
            {
                PreGrid = this.NeedGrid;
            }
            else if (button == this.FindButton)
            {
                PreGrid = this.FindGrid;
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
                button.Opacity = 0.5;
            }
        }

        private void DisturbButton_Unfocused(object sender, FocusEventArgs e)
        {
            this.DisturbLabel.TextColor = Color.White;
        }

        private void DisturbButton_Focused(object sender, FocusEventArgs e)
        {
            this.DisturbLabel.TextColor = Color.FromHex("#378D93"); ;
        }

        private void CheckoutButton_Unfocused(object sender, FocusEventArgs e)
        {
            this.CheckoutLabel.TextColor = Color.White;
        }

        private void CheckoutButton_Focused(object sender, FocusEventArgs e)
        {
            this.CheckoutLabel.TextColor = Color.FromHex("#378D93"); ;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(false);

            this.SizeChanged += OnSizeChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            this.SizeChanged -= OnSizeChanged;
        }

        private void OnSizeChanged(object sender, System.EventArgs e)
        {
            AmbientLightSlider.WidthRequest = Width;
        }
    }
}