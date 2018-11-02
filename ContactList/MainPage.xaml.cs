using System;
using ContactList.Entity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ContactList
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Contact> contacts = new List<Contact>();
        private ObservableCollection<Contact> listcontact = new ObservableCollection<Contact>();
        private Contact newcontact = new Contact();
        public MainPage()
        {
            this.InitializeComponent();
            contacts.Add(new Contact("Dao", "Tu", "Assets/male-01.png"));
            contacts.Add(new Contact("Thanh", "Vu", "Assets/male-02.png"));
            contacts.Add(new Contact("Tuoi", "Pham", "Assets/female-01.png"));
            foreach (var elm in contacts)
            {
                listcontact.Add(elm);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (firstName.Text == string.Empty || lastName.Text == string.Empty)
            {
                Error.Text = "* Nhập đầy đủ First Name và Last Name!";
            }
            else
            {
                Error.Text = "";
                newcontact.firstName = firstName.Text;
                newcontact.lastName = lastName.Text;
                listcontact.Add(newcontact);
                firstName.Text = string.Empty;
                lastName.Text = string.Empty;
            }
        }
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = e.AddedItems[0] as ComboBoxItem;
            switch (item.Name)
            {
                case "male1":
                    newcontact.avatar = "Assets/male-01.png";
                    break;
                case "male2":
                    newcontact.avatar = "Assets/male-02.png";
                    break;
                case "male3":
                    newcontact.avatar = "Assets/male-03.png";
                    break;
                case "female1":
                    newcontact.avatar = "Assets/female-01.png";
                    break;
                case "female2":
                    newcontact.avatar = "Assets/female-02.png";
                    break;
                case "female3":
                    newcontact.avatar = "Assets/female-03.png";
                    break;
            }
        }
    }
}

