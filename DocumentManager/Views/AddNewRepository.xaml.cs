using System.Windows;

namespace DocumentManager.Views
{
    /// <summary>
    /// Interaction logic for AddNewRepository.xaml
    /// </summary>
    public partial class AddNewRepository
    {
        public string FolderName { get; set; }
        public AddNewRepository()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Validate_OnClick(object sender, RoutedEventArgs e)
        {
            FolderName = FolderTextBox.Text;
            this.Close();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            FolderName = FolderTextBox.Text;
            this.Close();
        }
    }
}
