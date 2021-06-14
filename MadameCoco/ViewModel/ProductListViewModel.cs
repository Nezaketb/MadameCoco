using System;
using System.Collections.ObjectModel;
using System.Linq;
using MadameCoco.Data;
using MadameCoco.Models;
using MadameCoco.Tables;
using Xamarin.Forms;

namespace MadameCoco.ViewModel
{
    public class ProductListViewModel:BaseViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductListViewModel()
        {
            Title = "Ürünler";

            Products = new ObservableCollection<Product>();

            Products.Add(new Product
            {
                CatagoryID = 1,
                SubCategoryID = 2,
                Name = "Roxane Yüz Havlusu - Beyaz - 50x80 cm",
                ImageURL = "roxanehavlu.jpeg",
                Price = 19,
                ProductID = 1,
                Renk = "Beyaz"
            });
            Products.Add(new Product
            {
                CatagoryID = 1,
                SubCategoryID = 2,
                Name = "Verney Kroşeli El Havlusu -30x46 cm",
                ImageURL = "verneyhavlu.jpeg",
                Price = 17,
                ProductID = 2,
                Renk = "Ekru"
            });
            Products.Add(new Product
            {
                CatagoryID = 1,
                SubCategoryID = 3,
                Name = "Aimée Banyo Paspası - Koyu Mürdüm",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/03/26/94075/72da04ac-6759-4763-a4a8-3a6bc228bfd4_size437x330_cropCenter.jpg",
                Price = 153,
                ProductID = 3,
                Renk = "Mürdüm"

            });
            Products.Add(new Product
            {
                CatagoryID = 1,
                SubCategoryID = 3,
                Name = "Darvell Banyo Paspası - Pudra - 100x150 cm",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/03/23/94052/2750db66-fbcd-4dba-8313-af44a43ff24f_size437x330_cropCenter.jpg",
                Price = 174,
                ProductID = 4,
                Renk = "Pudra"
            });
            Products.Add(new Product
            {
                CatagoryID = 1,
                SubCategoryID = 1,
                Name = "Bois 2'li Banyo Seti - Soft Ekru",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/04/07/101018/c4a116e1-31a0-48a8-aad6-8560283c155d_size570x432_quality100.jpg",
                Price = 103,
                ProductID = 5,
                Renk = "Ekru"
            });
            Products.Add(new Product
            {
                CatagoryID = 2,
                SubCategoryID = 1,
                Name = "Terre Seramik Fırın Kabı - 31 cm",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2018/07/30/29581/09a25c0d-d2ff-43fb-ab79-a6f46558c98e_size437x330_cropCenter.jpg",
                Price = 55,
                ProductID = 6,
                Renk = "Kahverengi"

            });
            Products.Add(new Product
            {
                CatagoryID = 2,
                SubCategoryID = 3,
                Name = "Jeannet Masa Örtüsü - Bej / Gül Kurusu - 140x140 cm",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/17/101594/e4076214-0332-4f2f-baac-f42e38580642_size437x330_cropCenter.jpg",
                Price = 24,
                ProductID = 7,
                Renk = "Pembe"
            });
            Products.Add(new Product
            {
                CatagoryID = 2,
                SubCategoryID = 3,
                Name = "Fiori Mutfak Önlüğü - Yeşil",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/09/104704/b747dc01-efb4-4d49-b901-319c6ef6ac3a_size1400x1400_quality100_cropCenter.jpg",
                Price = 79,
                ProductID = 8,
                Renk = "Yeşil"
            });
            Products.Add(new Product
            {
                CatagoryID = 2,
                SubCategoryID = 2,
                Name = "Daily 2'li Kare Saklama Kabı 1075-575 Ml - Soft Gri",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/03/30/101385/951f165b-2b04-4c32-b25a-8841d34cdd04_size1400x1400_quality100_cropCenter.jpg",
                Price = 29,
                ProductID = 9,
                Renk = "Gri"
            });
            Products.Add(new Product
            {
                CatagoryID = 2,
                SubCategoryID = 1,
                Name = "Narenciye Sıkacağı - Carmen Kırmızı",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/03/22/97312/b7c9beb8-0ccf-4744-a673-1698981df3f3_size437x330_cropCenter.jpg",
                Price = 8,
                ProductID = 10,
                Renk = "Kırmızı"

            });
            Products.Add(new Product
            {
                CatagoryID = 3,
                SubCategoryID = 1,
                Name = "Histone Çift Kişilik Baskılı Yatak Örtüsü - Mavi",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/25/103051/99e4f01d-83c7-4bda-82fd-9aba2b737670_size437x330_cropCenter.jpg",
                Price = 109,
                ProductID = 11,
                Renk = "Mavi"

            });
            Products.Add(new Product
            {
                CatagoryID = 3,
                SubCategoryID = 3,
                Name = "Exorde Tek Kişilik Baskılı Pike - Sarı",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/24/105820/3f9fe8f6-efac-4e14-879f-049442eb9eb7_size437x330_cropCenter.jpg",
                Price = 59,
                ProductID = 12,
                Renk = "Sarı"
            });
            Products.Add(new Product
            {
                CatagoryID = 3,
                SubCategoryID = 2,
                Name = "Çiçek Desen Baskılı Hurç - Beyaz",
                ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/10/105759/5bfe86a6-85ab-4cef-9520-f0db9419f6c5_size437x330_cropCenter.jpg",
                Price = 39,
                ProductID = 13,
                Renk = "Beyaz"
            });

        }
        public ProductListViewModel(int categoryID, int subCategoryID)
        {
            Products = new ObservableCollection<Product>();

            #region c
            if (categoryID == 1)
            {
                if (subCategoryID == 1)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 1,
                        SubCategoryID = 1,
                        Name = "Bois 2'li Banyo Seti - Soft Ekru",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2021/04/07/101018/c4a116e1-31a0-48a8-aad6-8560283c155d_size570x432_quality100.jpg",
                        Price = 103,
                        ProductID = 5,
                        Renk = "Ekru"
                    });
                }
                else if (subCategoryID == 2)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 1,
                        SubCategoryID = 2,
                        Name = "Roxane Yüz Havlusu - Beyaz - 50x80 cm",
                        ImageURL = "roxanehavlu.jpeg",
                        Price = 19,
                        ProductID = 1,
                        Renk = "Beyaz"
                    });
                    
                }
                else if (subCategoryID == 3)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 1,
                        SubCategoryID = 3,
                        Name = "Aimée Banyo Paspası - Koyu Mürdüm",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2021/03/26/94075/72da04ac-6759-4763-a4a8-3a6bc228bfd4_size437x330_cropCenter.jpg",
                        Price = 153,
                        ProductID = 3,
                        Renk = "Mürdüm"

                    });
                   
                }
            }
            else if (categoryID == 2)
            {
                if (subCategoryID == 1)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 2,
                        SubCategoryID = 1,
                        Name = "Terre Seramik Fırın Kabı - 31 cm",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2018/07/30/29581/09a25c0d-d2ff-43fb-ab79-a6f46558c98e_size437x330_cropCenter.jpg",
                        Price = 55,
                        ProductID = 6,
                        Renk = "Kahverengi"

                    });
                    
                }
                else if (subCategoryID == 2)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 2,
                        SubCategoryID = 2,
                        Name = "Daily 2'li Kare Saklama Kabı 1075-575 Ml - Soft Gri",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2021/03/30/101385/951f165b-2b04-4c32-b25a-8841d34cdd04_size1400x1400_quality100_cropCenter.jpg",
                        Price = 29,
                        ProductID = 9,
                        Renk = "Gri"
                    });
                }
                else if (subCategoryID == 3)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 2,
                        SubCategoryID = 3,
                        Name = "Jeannet Masa Örtüsü - Bej / Gül Kurusu - 140x140 cm",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/17/101594/e4076214-0332-4f2f-baac-f42e38580642_size437x330_cropCenter.jpg",
                        Price = 24,
                        ProductID = 7,
                        Renk = "Pembe"
                    });
                   
                }
            }
            else if (categoryID == 3)
            {
                if (subCategoryID == 1)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 3,
                        SubCategoryID = 1,
                        Name = "Histone Çift Kişilik Baskılı Yatak Örtüsü - Mavi",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/25/103051/99e4f01d-83c7-4bda-82fd-9aba2b737670_size437x330_cropCenter.jpg",
                        Price = 109,
                        ProductID = 11,
                        Renk = "Mavi"

                    });
                }
                else if (subCategoryID == 2)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 3,
                        SubCategoryID = 2,
                        Name = "Çiçek Desen Baskılı Hurç - Beyaz",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/10/105759/5bfe86a6-85ab-4cef-9520-f0db9419f6c5_size437x330_cropCenter.jpg",
                        Price = 39,
                        ProductID = 13,
                        Renk = "Beyaz"
                    });
                }
                else if (subCategoryID == 3)
                {
                    Products.Add(new Product
                    {
                        CatagoryID = 3,
                        SubCategoryID = 3,
                        Name = "Exorde Tek Kişilik Baskılı Pike - Sarı",
                        ImageURL = "https://cdn-mgsm.akinon.net/products/2021/05/24/105820/3f9fe8f6-efac-4e14-879f-049442eb9eb7_size437x330_cropCenter.jpg",
                        Price = 59,
                        ProductID = 12,
                        Renk = "Sarı"
                    });
                }
            }
            #endregion
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(() => ViewCart());
        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductId = SelectedProduct.ProductID,
                    ProductName = SelectedProduct.Name,
                    Price = SelectedProduct.Price
                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault(c => c.ProductId == SelectedProduct.ProductID);
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Cart", "Selected Item Added to Cart", "OK");
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                cn.Close();
            }
        }

        private void ViewCart()
        {
            throw new NotImplementedException();
        }

       // private Product _SelectedProduct;
        public Product SelectedProduct;

        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }
    }
    }
