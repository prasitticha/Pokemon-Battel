using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    internal class Pidgeot
    {
        double height;
        double wirght;

        Gender gender;
        Category category;
        Abilities abilities;
        Image image;
        Type type;
        Type weaknesses;

        enum Gender
        {
            male,
            female
        }
        enum Category
        {
            mouse
        }
        enum Abilities
        {
            static_
        }
        enum Type
        {
            electric, ground
        }
    }
}
