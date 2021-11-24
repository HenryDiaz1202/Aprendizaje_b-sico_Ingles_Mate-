using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto
{
    [RunInstaller(true)]
    public partial class Instalador : System.Configuration.Install.Installer
    {
        public Instalador()
        {
            InitializeComponent();
        }
    }
}
