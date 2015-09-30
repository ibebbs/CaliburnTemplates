using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Universal.Windows.ViewModels
{
    public interface IShellViewModel : IScreen
    {
        string Text { get; }
    }

    internal class ShellViewModel : Screen, IShellViewModel
    {
        public ShellViewModel()
        {
            Text = typeof(App).Namespace;
        }

        public string Text { get; private set; }
    }
}
