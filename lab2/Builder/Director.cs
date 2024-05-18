using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.Builder.interfaces;

namespace lab2.Builder
{
    public class Director
    {
        public Hero GetHero()
        {
            return HeroBuilder.Create().
                BuildGender("female")
                .BuildName("Iryna")
                .BuildHeight(169)
                .BuildHairColor("Red")
                .BuildEyesColor("Hazel")
                .BuildClothes("red dress")
                .Build();
        }

        public Enemy GetEnemy()
        {
            return EnemyBuilder.Create()
               .BuildGender("frog")
               .BuildName("some")
               .BuildBodyType("froggy")
               .BuildEyesColor("green")
               .Build();
        }
    }
}
