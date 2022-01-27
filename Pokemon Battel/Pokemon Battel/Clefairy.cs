using Pokemon_Battel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    public class Clefairy : Pokemon
    {
        public Clefairy()
        {
            base.name = "Clefairy";
            base.height = 2.00;
            base.wirght = 16.5;

            base.hp = 70;
            base.atk = 45;
            base.def = 48;
            base.speed = 60;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = new Abilities[] { Abilities.cute_charm, Abilities.magic_guard };
            base.type = new Type[] { Type.fairy };
            base.weaknesses = new Type[] { Type.steel, Type.poison };

            base.image = Resources._03;
        }
    }
}
