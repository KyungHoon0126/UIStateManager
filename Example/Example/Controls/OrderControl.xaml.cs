using System.Windows;
using UIStateManagerLibrary;

namespace Example.Controls
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : CustomControlModel
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void btnMoveToPlace_Click(object sender, RoutedEventArgs e)
        {
            App.uIStateManager.SwitchCustomControl(CustomControlType.PLACE);
        }
    }
}
