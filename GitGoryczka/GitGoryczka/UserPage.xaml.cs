using GitGoryczka.ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitGoryczka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public Account acctmp;
        public UserPage(Account acc)
        {
            InitializeComponent();
            WebView.Source = acc.Class.Path;
            acctmp = acc;
        }

        private void Profil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile(acctmp));
        }
    }
}