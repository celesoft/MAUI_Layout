namespace TabsPrimerTest;

public partial class Composicion1 : ContentPage
{
	public Composicion1()
	{
		InitializeComponent();
        BindingContext = new CourseProfileUI.ViewModels.CourseProfileViewModel();
    }
}