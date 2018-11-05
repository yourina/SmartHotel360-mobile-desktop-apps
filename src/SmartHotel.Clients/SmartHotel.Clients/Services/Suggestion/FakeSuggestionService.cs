using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHotel.Clients.Core.Services.Suggestion
{
    public class FakeSuggestionService : ISuggestionService
    {
        public async Task<ObservableCollection<Models.Suggestion>> GetSuggestionsAsync(double latitude, double longitude)
        {
            if (latitude == 0 || longitude == 0)
            {
                return null;
            }

            //await Task.Delay(500);
            return new ObservableCollection<Models.Suggestion>
            {
                new Models.Suggestion
                {
                    Name = "The Salty Chicken",
                    Description = "With a downtown location in vibrant San Francisco, ",
                    Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_1.png" : (Device.RuntimePlatform == Device.Tizen?"i_hotel_1.jpg":"img_1"),
                    Rating = 4, Votes = 81,
                    SuggestionType = Models.SuggestionType.Restaurant,
                    Latitude = (Device.RuntimePlatform == Device.Tizen) ? 37.784454 : 47.5743905f,
                    Longitude = (Device.RuntimePlatform == Device.Tizen) ? -122.403946 :-122.4323376f
                },
                new Models.Suggestion
                {
                    Name = "The Autumn Club",
                    Description = "50 McAllister St, San Francisco, CA",
                    Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_2.png" : (Device.RuntimePlatform == Device.Tizen?"i_hotel_2.jpg":"img_2"),
                    Rating = 4, Votes = 66,
                    SuggestionType = Models.SuggestionType.Event,
                    Latitude = (Device.RuntimePlatform == Device.Tizen) ? 37.744454 : 47.5790791f,
                    Longitude = (Device.RuntimePlatform == Device.Tizen) ? -122.433946 :-122.4136163f
                },
                new Models.Suggestion
                {
                    Name = "Bike Rider",
                    Description = "Loren ipsum dolor sit amet, consectetur adipisicing elit.",
                    Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_3.png" : (Device.RuntimePlatform == Device.Tizen?"i_hotel_3.jpg":"img_3"),
                    Rating = 5, Votes = 22,
                    SuggestionType = Models.SuggestionType.Event,
                    Latitude = (Device.RuntimePlatform == Device.Tizen) ? 37.764454 : 47.5766275f,
                    Longitude = (Device.RuntimePlatform == Device.Tizen) ? -122.453946 :-122.4217906f
                },
                new Models.Suggestion
                {
                    Name = "C# Conference",
                    Description = "Central downtown San Francisco location, with views of the city and bay",
                    Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_1.png" : (Device.RuntimePlatform == Device.Tizen?"i_hotel_4.jpg":"img_1"),
                    Rating = 4, Votes = 17,
                    SuggestionType = Models.SuggestionType.Event,
                    Latitude = (Device.RuntimePlatform == Device.Tizen) ? 37.754454 : 47.5743905f,
                    Longitude = (Device.RuntimePlatform == Device.Tizen) ? -122.463946 :-122.4023376f
                },
                new Models.Suggestion
                {
                    Name = "The Autumn Club",
                    Description = "Views of San Francisco from up to 32 Floors",
                    Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_2.png" : (Device.RuntimePlatform == Device.Tizen?"i_hotel_5.jpg":"img_2"),
                    Rating = 5, Votes = 132,
                    SuggestionType = Models.SuggestionType.Restaurant,
                    Latitude = (Device.RuntimePlatform == Device.Tizen) ? 37.804454 : 47.5743905f,
                    Longitude = (Device.RuntimePlatform == Device.Tizen) ? -122.433946 : -122.4023376f
                },
                new Models.Suggestion
                {
                    Name = "The White Garden",
                    Description = "Diverse selection of restaurants within immediate area",
                    Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_1.png" : (Device.RuntimePlatform == Device.Tizen?"i_hotel_6.jpg":"img_2"),
                    Rating = 3, Votes = 80,
                    SuggestionType = Models.SuggestionType.Restaurant,
                    Latitude = (Device.RuntimePlatform == Device.Tizen) ? 37.754454 : 47.5743905f,
                    Longitude = (Device.RuntimePlatform == Device.Tizen) ? -122.433746 : -122.4023376f
                },
                new Models.Suggestion
                {
                    Name = "The Time Resort",
                    Description = "24-hr Fitness Center, equipped with the very latest exercise and wellness technology",
                    Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_3.png" : (Device.RuntimePlatform == Device.Tizen?"i_hotel_7.jpg":"img_2"),
                    Rating = 5, Votes = 200,
                    SuggestionType = Models.SuggestionType.Restaurant,
                    Latitude = (Device.RuntimePlatform == Device.Tizen) ? 37.764454 : 47.5743905f,
                    Longitude = (Device.RuntimePlatform == Device.Tizen) ? -122.403946 : -122.4023376f
                }
            };
        }
    }
}