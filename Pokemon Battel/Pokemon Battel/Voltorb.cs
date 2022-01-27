using Pokemon_Battel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    internal class Voltorb : Pokemon
    {
        public Voltorb()
        {
            base.name = "Voltorb";
            base.height = 1.08;
            base.wirght = 22.9;

            base.hp = 40;
            base.atk = 30;
            base.def = 50;
            base.speed = 55;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = new Abilities[] { Abilities.static_, Abilities.soundproof };
            base.type = new Type[] { Type.electric };
            base.weaknesses = new Type[] { Type.grass, Type.ground };

            base.image = Resources._06;
        }
    }
}
