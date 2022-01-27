using Pokemon_Battel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    public class Pidgeot : Pokemon
    {
        public Pidgeot()
        {
            base.name = "Pidgeot";
            base.height = 4.11;
            base.wirght = 87.1;

            base.hp = 83;
            base.atk = 80;
            base.def = 75;
            base.speed = 70;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = new Abilities[] { Abilities.keen_eye, Abilities.tangled_feet };
            base.type = new Type[] { Type.normal, Type.flying };
            base.weaknesses = new Type[] { Type.electric, Type.ice, Type.rock };

            base.image = Resources._02;

        }
    }
}
