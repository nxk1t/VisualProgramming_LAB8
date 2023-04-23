using Avalonia.Controls;
using VisualProgramming_LAB8.ViewModels;

namespace VisualProgramming_LAB8.Views
{
    public partial class ParameterWindow : Window
    {
        public ParameterWindow()
        {
            InitializeComponent();
            DataContext = new ParameterWindowViewModel();
        }
    }
}
