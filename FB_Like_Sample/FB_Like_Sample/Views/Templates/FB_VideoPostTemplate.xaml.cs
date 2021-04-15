using Syncfusion.XForms.Buttons;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FB_Like_Sample.Views.Templates
{
    /// <summary>
    /// FB video post template.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPostTemplate : Grid
    {
        public VideoPostTemplate()
        {
            InitializeComponent();
            playButton.Text = "\ue75e";
        }

        private void MediaElement_MediaOpened(object sender, System.EventArgs e)
        {
            loading.IsVisible = false;
            playButton.IsVisible = true;
        }

        private void SfButton_Clicked(object sender, System.EventArgs e)
        {
            if (playButton.Text == "\ue75e")
            {
                mediaElement.Play();
                playButton.Text = "\ue75d";
            }
            else
            {
                mediaElement.Pause();
                playButton.Text = "\ue75e";
            }
        }
    }
}