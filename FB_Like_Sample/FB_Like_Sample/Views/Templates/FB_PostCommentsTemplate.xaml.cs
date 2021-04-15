using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FB_Like_Sample.Views.Templates
{
    /// <summary>
    /// FB Post Comments section template.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostCommentsTemplate : Grid
    {
        public PostCommentsTemplate()
        {
            InitializeComponent();
        }
    }
}