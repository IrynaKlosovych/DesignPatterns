using lab2.Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Builder
{
    public class EnemyBuilder
    {
        public static IBuilderGender<Enemy> Create()
        {
            return new Impl();
        }
        private class Impl : IBuilderGender<Enemy>, IBuilderName<Enemy>, IBuilderAnother<Enemy>
        {
            private Enemy character = new Enemy();

            private void _reset()
            {
                this.character = new Enemy();
            }

            public Impl()
            {
                this._reset();
            }

            public IBuilderName<Enemy> BuildGender(string gender)
            {
                this.character.Gender = gender;
                return this;
            }

            public IBuilderAnother<Enemy> BuildName(string name)
            {
                this.character.Name = name;
                return this;
            }

            public IBuilderAnother<Enemy> BuildHeight(int height)
            {
                this.character.Height = height;
                return this;
            }

            public IBuilderAnother<Enemy> BuildBodyType(string bodyType)
            {
                this.character.BodyType = bodyType;
                return this;
            }

            public IBuilderAnother<Enemy> BuildHairColor(string hairColor)
            {
                this.character.HairColor = hairColor;
                return this;
            }

            public IBuilderAnother<Enemy> BuildEyesColor(string eyesColor)
            {
                this.character.EyesColor = eyesColor;
                return this;
            }

            public IBuilderAnother<Enemy> BuildClothes(string clothes)
            {
                this.character.Clothes = clothes;
                return this;
            }

            public IBuilderAnother<Enemy> BuildInventory(List<string> inventory)
            {
                this.character.Inventory = inventory;
                return this;
            }
            public Enemy Build()
            {
                Enemy someCharacter = this.character;
                this._reset();
                return someCharacter;
            }
        }

    }
}
