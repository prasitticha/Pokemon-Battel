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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources._05;
        }
    }
}
