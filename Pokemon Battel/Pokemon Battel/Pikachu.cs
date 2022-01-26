using Pokemon_Battel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            base.name = "Pikachu";
            base.height = 1.04;
            base.wirght = 13.2;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources._01;
        }
    }
}
