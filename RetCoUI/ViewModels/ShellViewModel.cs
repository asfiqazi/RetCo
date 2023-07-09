  using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetCoUI.ViewModels
{
    public class ShellViewModel
    {
        private ComputationBase compBase;
        public ShellViewModel(ComputationBase computationBase)
        {
            compBase = computationBase;
        }
    }
}
