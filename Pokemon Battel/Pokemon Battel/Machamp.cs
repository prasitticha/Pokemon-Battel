using Pokemon_Battel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    internal class Machamp : Pokemon
    {
        public Machamp()
        {
            base.name = "Machamp";
            base.height = 5.03;
            base.wirght = 286.8;

            base.hp = 90;
            base.atk = 130;
            base.def = 80;
            base.speed = 65;

            base.gender = Gender.male;
            base.category = Category.superpower;
            base.abilities = new Abilities[] { Abilities.guts, Abilities.no_gurad };
            base.type = new Type[] { Type.fighting };
            base.weaknesses = new Type[] { Type.phychic, Type.flying, Type.fairy };

            base.image = Resources._07;
        }
    }
}
