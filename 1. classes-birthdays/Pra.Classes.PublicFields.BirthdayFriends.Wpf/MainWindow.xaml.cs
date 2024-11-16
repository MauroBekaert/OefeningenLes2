using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pra.Classes.PublicFields.BirthdayFriends.Core;

namespace Pra.Classes.PublicFields.BirthdayFriends.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            DateTime birthday = dpBirthDay.SelectedDate.Value;

            Friend newFriend = new Friend(name, birthday);

            lstFriends.Items.Add(newFriend);
        }
    }
}
