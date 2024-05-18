using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Builder.interfaces
{
    public interface IBuilderGender<T> where T : Character
    {
        IBuilderName<T> BuildGender(string gender);
    }
}
