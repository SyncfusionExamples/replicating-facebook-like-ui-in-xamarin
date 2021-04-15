using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FB_Like_Sample.Behaviors
{
    public class SfListViewExtendHeightBehavior : Behavior<SfListView>
    {
        #region Field

        /// <summary>
        /// Gets or sets the visual container of the list view.
        /// </summary>
        private VisualContainer container;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the listView.
        /// </summary>
        public SfListView ListView { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when adding list view to view.
        /// </summary>
        /// <param name="listView">The SfListView</param>
        protected override void OnAttachedTo(SfListView listView)
        {
            base.OnAttachedTo(listView);
            this.ListView = listView;
            this.container = listView.GetVisualContainer();
            this.container.PropertyChanged += this.Container_PropertyChanged;
        }

        /// <summary>
        /// Invoked when exit from the view.
        /// </summary>
        /// <param name="listView">The SfListView</param>
        protected override void OnDetachingFrom(SfListView listView)
        {
            base.OnDetachingFrom(listView);
            this.container.PropertyChanged -= this.Container_PropertyChanged;
            this.container = null;
            this.ListView = null;
        }

        /// <summary>
        /// Invoked when the container property is changed.
        /// </summary>
        /// <param name="sender">The VisualContainer</param>
        /// <param name="eventArgs">The property changed event args</param>
        private async void Container_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs eventArgs)
        {
            if (eventArgs.PropertyName == "Height")
            {
                await Task.Delay(500);
                var extent = (double)this.container.GetType().GetRuntimeProperties()
                    .FirstOrDefault(container => container.Name == "TotalExtent").GetValue(this.container);
                this.ListView.HeightRequest = extent + 1;
            }
        }

        #endregion
    }
}
