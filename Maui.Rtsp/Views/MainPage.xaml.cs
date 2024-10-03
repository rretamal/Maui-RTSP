namespace Maui.Rtsp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnbtnCheckClicked(object sender, EventArgs e)
        {
            cameraView.User = txtUser.Text;
            cameraView.Password = txtPassword.Text;
            cameraView.Url = txtUrl.Text;   

            
        }
    }

}
