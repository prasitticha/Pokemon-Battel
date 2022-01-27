using Pokemon_Battel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    internal class Psyduck : Pokemon
    {
        public Psyduck()
        {
            base.name = "Psyduck";
            base.height = 2.07;
            base.wirght = 43.2;

            base.hp = 50;
            base.atk = 52;
            base.def = 48;
            base.speed = 65;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = new Abilities[] { Abilities.damp, Abilities.cloud_nine };
            base.type = new Type[] { Type.water };
            base.weaknesses = new Type[] { Type.grass, Type.electric };

            base.image = Resources._04;
        }
    }
}
