using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace VisualProgramming_LAB8.Views.Control
{
    public class CompositionLineControl : TemplatedControl
    {
        public static readonly StyledProperty<double> LenghtProperty =
            AvaloniaProperty.Register<CompositionLineControl, double>("Lenght");

        public double Lenght
        {
            get => GetValue(LenghtProperty);
            set => SetValue(LenghtProperty, value);
        }
    }
}
