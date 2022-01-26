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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources._06;
        }
    }
}
