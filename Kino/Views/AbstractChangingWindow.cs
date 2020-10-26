using Kino.Utilities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kino.Views
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AbstractChangingWindow, UserControl>))]
    public abstract class AbstractChangingWindow : UserControl
    {
        public Action<AbstractChangingWindow> Change_Window;
    }
}
