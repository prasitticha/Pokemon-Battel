﻿using Pokemon_Battel.Properties;
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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources._02;
        }
    }
}
