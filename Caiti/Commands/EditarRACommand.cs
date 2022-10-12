using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Commands
{
    public class EditarRACommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            AgregarRA agregarRA = new AgregarRA();

            agregarRA.Show();
        }
    }
}
