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
    public partial class Profile : ContentPage
    {
        public Account acctmp;
        public Profile(Account acc)
        {
            InitializeComponent();
            picker.ItemsSource = PublicClass.Clases;
            picker.SelectedItem = acc.Class;
            Name.Text = acc.Login;
            acctmp = acc;
        }

        private void LogOut(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void SaveChange(object sender, EventArgs e)
        {
            Account newacc = new Account(acctmp.Login,acctmp.Password,picker.SelectedItem as UserClass);
            PublicClass.accounts.Remove(acctmp);
            PublicClass.accounts.Add(newacc);
            Navigation.PopToRootAsync();
        }
    }
}