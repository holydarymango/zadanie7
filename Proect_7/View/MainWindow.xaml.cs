using Proect_7.Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proect_7;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ModelContext? _db = null;
    public MainWindow()
    {
        InitializeComponent();
        _db = new ModelContext();
    }

    private void BtnLogin_Click(object sender, RoutedEventArgs e)
    {
        User? userModel = _db.Users.FirstOrDefault(predicate: x => x.Login == TbLogin.Text && x.Password == PbPassword.Password);
        if (userModel != null)
        {
            switch (userModel.Role.RoleID)
            {
                case 1:
                    MessageBox.Show("Администратор",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    break;

                case 2:
                    MessageBox.Show("Пользователь",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    break;
                case 3:
                    MessageBox.Show("Гость",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    break;
            }
        }
        else
        {

            MessageBox.Show("ошибка ввода данных",
                            "Системное сообщение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);

        }
    }

    private void BtnRegister_Click(object sender, RoutedEventArgs e)
    {

    }

    private void BtnFullAutentication_Click(object sender, RoutedEventArgs e)
    {

    }
}