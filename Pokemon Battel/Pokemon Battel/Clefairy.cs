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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources._03;
        }
    }
}
