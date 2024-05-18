using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using lab2.Builder.interfaces;

namespace lab2.Builder
{
    public class HeroBuilder
    {
        public static IBuilderGender<Hero> Create()
        {
            return new Impl();
        }
        private class Impl : IBuilderGender<Hero>, IBuilderName<Hero>, IBuilderAnother<Hero>
        {
            private Hero character = new Hero();

            private void _reset()
            {
                this.character = new Hero();
            }

            public Impl()
            {
                this._reset();
            }

            public IBuilderName<Hero> BuildGender(string gender)
            {
                this.character.Gender = gender;
                return this;
            }

            public IBuilderAnother<Hero> BuildName(string name)
            {
                this.character.Name = name;
                return this;
            }

            public IBuilderAnother<Hero> BuildHeight(int height)
            {
                this.character.Height = height;
                return this;
            }

            public IBuilderAnother<Hero> BuildBodyType(string bodyType)
            {
                this.character.BodyType = bodyType;
                return this;
            }

            public IBuilderAnother<Hero> BuildHairColor(string hairColor)
            {
                this.character.HairColor = hairColor;
                return this;
            }

            public IBuilderAnother<Hero> BuildEyesColor(string eyesColor)
            {
                this.character.EyesColor = eyesColor;
                return this;
            }

            public IBuilderAnother<Hero> BuildClothes(string clothes)
            {
                this.character.Clothes = clothes;
                return this;
            }

            public IBuilderAnother<Hero> BuildInventory(List<string> inventory)
            {
                this.character.Inventory = inventory;
                return this;
            }
            
            public Hero Build()
            {
                Hero someCharacter = character;
                this._reset();
                return someCharacter;
            }
        }
    }
}
