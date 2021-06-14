using System.Collections.Generic;
using System.Collections.ObjectModel;
using MadameCoco.Tables;
using MadameCoco.Models;

namespace MadameCoco.ViewModel
{
    public class CatagoryViewModel:BaseViewModel
    {
        public ObservableCollection<Catagory> Catagory { get; set; }
        public List<Catagory> Cat { get; set; }
        public CatagoryViewModel()
        {
            Title = "Kategoriler";

            Catagory = new ObservableCollection<Catagory>();
            Cat = new List<Catagory>();

            Catagory.Add(new Catagory { CatagoryName="Banyo" });
            Catagory.Add(new Catagory { CatagoryName="Mutfak" });
            Catagory.Add(new Catagory { CatagoryName="Yatak"});
        }
        public void SubCats(int Catid)
        {
            Catagory.Clear();
            if (Catid == 1)
            {
                Catagory.Add(new Catagory { CatagoryName="Banyo Aksesuarları" });
                Catagory.Add(new Catagory { CatagoryName="Havlu"});
                Catagory.Add(new Catagory { CatagoryName="Banyo Yer Aksesuarları" });
            }

            if (Catid == 2)
            {
                Catagory.Add(new Catagory { CatagoryName="Pişirme" });
                Catagory.Add(new Catagory { CatagoryName="Saklama"});
                Catagory.Add(new Catagory { CatagoryName="MutfakTekstili"});
            }

            if (Catid == 3)
            {
                Catagory.Add(new Catagory { CatagoryName="Nevresim"});
                Catagory.Add(new Catagory { CatagoryName="Alez-Hurç" });
                Catagory.Add(new Catagory {CatagoryName="Pike" });
            }
        }
    }
}
