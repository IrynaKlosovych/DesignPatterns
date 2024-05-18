using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Builder.interfaces
{
    public interface IBuilderAnother<T> where T : Character
    {
        IBuilderAnother<T> BuildHeight(int height);
        IBuilderAnother<T> BuildBodyType(string bodyType);
        IBuilderAnother<T> BuildHairColor(string hairColor);
        IBuilderAnother<T> BuildEyesColor(string eyesColor);
        IBuilderAnother<T> BuildClothes(string clothes);
        IBuilderAnother<T> BuildInventory(List<string> inventory);
        T Build();
    }
}
