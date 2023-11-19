using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IMealBuilder
    {
        void BuildMainCourse();
        void BuildSide();
        void BuildDrink();
        Meal GetMeal();
    }
}
