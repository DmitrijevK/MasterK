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
            profile.Source = ImageSource.FromFile("musja.jpg");
            aboutlist.ItemsSource = GetMenuList();
            var homepage = typeof(view.aboutme);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }

        private List<pervik> GetMenuList()
        {
            var list = new List<pervik>();
            list.Add(new pervik()
            {
                Text = "aa",
                Detail = "ДОПОЛГИТНЛЬНАЯ ИНФОРМАЦИЯ",
                ImagePath = "musja.jpg",
                TargetPage = typeof(view.aboutme)
                
            });
            return list;
        }

        private void aboutlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecte = (pervik)e.SelectedItem;
            Type selectedpage = selecte.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}
