using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterK
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profile.Source = ImageSource.FromFile("mmmm.png");
            aboutlist.ItemsSource = GetMenuList();
            var homepage = typeof(view.aboutme);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }

        private List<pervi> GetMenuList()
        {
            var list = new List<pervi>();
            list.Add(new pervi()
            {
                Text = "aa",
                Detail = "ДОПОЛГИТНЛЬНАЯ ИНФОРМАЦИЯ",
                ImagePath = "mmmm.png",
                TargetPage = typeof(view.aboutme)
                
            });

            list.Add(new pervi()
            {
                Text = "aa",
                Detail = "что я сделал",
                ImagePath = "mmmm.png",
                TargetPage = typeof(view.achivment1)

            });

            list.Add(new pervi()
            {
                Text = "aa",
                Detail = "мой опыт",
                ImagePath = "mmmm.png",
                TargetPage = typeof(view.experience)

            });

            list.Add(new pervi()
            {
                Text = "aa",
                Detail = "возможности",
                ImagePath = "mmmm.png",
                TargetPage = typeof(view.skills)

            });
            return list;
        }

        private void aboutlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecte = (pervi)e.SelectedItem;
            Type selectedpage = selecte.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}
