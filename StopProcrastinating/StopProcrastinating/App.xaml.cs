using StopProcrastinating.Views.Pages;
using Xamarin.Forms;

namespace StopProcrastinating
{
    public partial class App : Application
    {
        #region constructor/destructor

        public App()
        {
            InitializeComponent();

            MainPage = new MainPageView();
        }

        #endregion

        #region methods

        protected override void OnResume()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnStart()
        {
        }

        #endregion
    }
}
