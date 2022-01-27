using Pokemon_Battel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    internal class Poliwag : Pokemon
    {
        public Poliwag()
        {
            base.name = "Poliwag";
            base.height = 2.00;
            base.wirght = 27.3;

            base.hp = 40;
            base.atk = 50;
            base.def = 40;
            base.speed = 40;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = new Abilities[] { Abilities.damp, Abilities.water_absorb };
            base.type = new Type[] { Type.water };
            base.weaknesses = new Type[] { Type.grass, Type.electric };

            base.image = Resources._05;
        }
    }
}
