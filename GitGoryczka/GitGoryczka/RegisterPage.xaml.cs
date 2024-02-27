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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            picker.ItemsSource = PublicClass.Clases;
        }

        private void Register(object sender, EventArgs e)
        {
            UserClass Class = new UserClass();
            if (picker.SelectedIndex != 0)
            {
                Class = picker.SelectedItem as UserClass;
            }
            if (PasswordTxT.Text == RepeatPasswordTxT.Text)
            {
                bool isUnicate = true;
                foreach (var account in PublicClass.accounts)
                {
                    if (LoginTxT.Text == account.Login)
                    {
                        isUnicate = false;
                    }
                }
                if (isUnicate)
                {
                    Class = picker.SelectedItem as UserClass;
                    PublicClass.accounts.Add(new Account(LoginTxT.Text, PasswordTxT.Text,Class));
                    Navigation.PopAsync();
                }
            }
        }        
    }
}