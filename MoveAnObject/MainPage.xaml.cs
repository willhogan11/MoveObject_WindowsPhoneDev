using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MoveAnObject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown; // For adding event handlers
        }

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            if (args.VirtualKey == VirtualKey.Down)
            {
                System.Diagnostics.Debug.WriteLine("Key Down Pressed");
                myRectangle.SetValue(Canvas.TopProperty, (double)myRectangle.GetValue(Canvas.TopProperty) + 1);
            }
            if (args.VirtualKey == VirtualKey.Up)
            {
                System.Diagnostics.Debug.WriteLine("Key Up Pressed");
                myRectangle.SetValue(Canvas.TopProperty, (double)myRectangle.GetValue(Canvas.TopProperty) - 1);
            }
            if (args.VirtualKey == VirtualKey.Left)
            {
                System.Diagnostics.Debug.WriteLine("Key Left Pressed");
                myRectangle.SetValue(Canvas.LeftProperty, (double)myRectangle.GetValue(Canvas.LeftProperty) - 1);
            }
            if (args.VirtualKey == VirtualKey.Right)
            {
                System.Diagnostics.Debug.WriteLine("Key Right Pressed");
                myRectangle.SetValue(Canvas.LeftProperty, (double)myRectangle.GetValue(Canvas.LeftProperty) + 1);
            }
            if ((args.VirtualKey == VirtualKey.Down) && (args.VirtualKey == VirtualKey.Left))
            {
                myRectangle.SetValue(Canvas.TopProperty, (double)myRectangle.GetValue(Canvas.TopProperty) + 1);
                myRectangle.SetValue(Canvas.LeftProperty, (double)myRectangle.GetValue(Canvas.LeftProperty) - 1);
            }
        }
    }
}
