using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TemplateDesignPattren
{
    class HomePage : PageTemplate
    {
        protected override void DisplayContent()
        {
            Console.WriteLine("Displaying Home Page Content");
        }

    }
}
