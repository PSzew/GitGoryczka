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
        public UserPage(Account acc)
        {
            InitializeComponent();
            WebView.Source = acc.Class.Path;
        }

        private void LogOut(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}