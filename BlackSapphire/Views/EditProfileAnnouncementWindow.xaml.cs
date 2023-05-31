using BlackSapphire.ViewModels;
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

namespace BlackSapphire.Views
{
    /// <summary>
    /// Логика взаимодействия для EditProfileAnnouncementWindow.xaml
    /// </summary>
    public partial class EditProfileAnnouncementWindow : Window
    {
        public EditProfileAnnouncementWindow()
        {
            InitializeComponent();
            DataContext = new EditProfileAnnouncementWindowViewModel(null, Dispatcher);
        }
        public EditProfileAnnouncementWindow(AnnouncementApi announcement)
        {
            InitializeComponent();
            DataContext = new EditProfileAnnouncementWindowViewModel(announcement, Dispatcher);
        }
    }
}