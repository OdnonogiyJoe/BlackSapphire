using BlackSapphire.ViewModelsAutorization;
using BlackSapphire.Views;
using ModelsApi;
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
using System.Windows.Shapes;

namespace BlackSapphire.ViewsAutorization
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            DataContext = new RegisterViewModel(null);
        }
        public RegisterWindow(UserApi user)
        {
            InitializeComponent();
            DataContext = new RegisterViewModel(user);
        }

        private void erger(object sender, RoutedEventArgs e)
        {
            StartWindow qq = new StartWindow();
            qq.Show();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

    }
}
