namespace TestUno
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            _= Frame.Navigate(typeof(TestPage));


        }
    }
}