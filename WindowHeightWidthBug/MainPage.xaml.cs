namespace WindowHeightWidthBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnGetDimensionsClicked(object sender, EventArgs e)
    {
        PageWidth.Text = Application.Current.MainPage.Width.ToString();
        PageHeight.Text = Application.Current.MainPage.Height.ToString();
        
        WindowWidth.Text = Application.Current.Windows[0].Width.ToString();
        WindowHeight.Text = Application.Current.Windows[0].Height.ToString();
    }
}