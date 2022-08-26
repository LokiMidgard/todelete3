using System.Windows;

namespace todelete3;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
[Mixin.Mixin(typeof(MyClass))]
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        textx.Text = NameTag;
    }
}

internal class MyClass
{
    private const string NameTag = "Miximn";
}