using System.Windows;
using UIStateManagerLibrary;

namespace Example
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // 여러곳에서 사용하기 위해 App.xaml.cs에 객체 생성.
        public static UIStateManager uIStateManager = new UIStateManager();
    }
}
