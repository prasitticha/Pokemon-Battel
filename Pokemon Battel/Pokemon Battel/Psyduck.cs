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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources._04;
        }
    }
}
