using TrackerSpain.ViewModels;

namespace TrackerSpain.Views;

public partial class Next7DWidget
{
    public Next7DWidget()
    {
        InitializeComponent();

        BindingContext = new HomeViewModel();
    }
}
