using System.Windows;
using UIStateManagerLibrary;

namespace Example.Controls
{
    /// <summary>
    /// Interaction logic for PayControl.xaml
    /// </summary>
    public partial class PayControl : CustomControlModel
    {
        public PayControl()
        {
            InitializeComponent();
        }

        private void btnMoveToPlace_Click(object sender, RoutedEventArgs e)
        {
            App.uIStateManager.SwitchCustomControl(CustomControlType.PLACE);
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            App.uIStateManager.SwitchCustomControl(CustomControlType.PLACE);
        }
    }
}
