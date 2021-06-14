using System.Collections.ObjectModel;
using MadameCoco.Data;
using MadameCoco.Models;
using MadameCoco.Tables;
using Xamarin.Forms;
using System.Threading.Tasks;
using MadameCoco.ViewPages;


namespace MadameCoco.ViewModel
{
    public class ShopCartViewModel:BaseViewModel
    {
        public ObservableCollection<UserCartItem> CartItems { get; set; }
        private int _TotalCost;
        public int TotalCost
        {
            set
            {
                _TotalCost = value;
                OnPropertyChanged();
            }
            get
            {
                return _TotalCost;
            }
        }

        public Command PlaceOrdersCommand { get; set; }
        public ShopCartViewModel()
        {
            Title = "Sepetim";
            CartItems = new ObservableCollection<UserCartItem>();
            LoadItems();
            PlaceOrdersCommand = new Command(async () => await PlaceOrdersAsync());
        }

        public async Task PlaceOrdersAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new SepetPage());

        }

        private void LoadItems()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var items = cn.Table<CartItem>().ToList();
            CartItems.Clear();
            foreach (var item in items)
            {
                CartItems.Add(new UserCartItem()
                {
                    CartItemId = item.CartItemId,
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Image = item.ProductImage
                });
                TotalCost += item.Price;
            }
        }
    }
}
