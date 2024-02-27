using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class child : Component
    {
        public child()
        {
            InitializeComponent();
        }

        public child(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
