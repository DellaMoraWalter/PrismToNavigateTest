using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PrismNavigateToTest.Model;


namespace PrismNavigateToTest.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        private Product _product = null;
        public Product product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }



        public ProductViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Product Page";
        }



        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            /*if (parameters.TryGetValue(KnownNavigationParameters.XamlParam, out IList<object> selectedItems))
            {
                product = selectedItems.FirstOrDefault() as Product;
            }*/
        }

    }
}
