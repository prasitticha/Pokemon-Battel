using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battel
{
    public class Pokemon
    {
        protected int hp;
        protected int atk;
        protected int def;
        protected int speed;

        protected string name;
        protected double height;
        protected double wirght;

        protected Gender gender;
        protected Category category;
        protected Abilities[] abilities;
        protected Bitmap image;
        protected Type[] type;
        protected Type[] weaknesses;

        public string getName()
        {
            return this.name;
        }
        public Image getImage()
        {
            return this.image;
        }
        public int getHP() { return hp; }
        private void setHP(int newHP) { hp = newHP; }
        public int getATK() { return this.atk; }
        public int getDEF() { return this.def; }
        public int getSPEED() { return this.speed; }
        public void attackPokemon(ref Pokemon enemy)
        {
            int damage = this.atk - enemy.getDEF();
            int newHP = enemy.getHP() - damage;
            enemy.setHP(newHP);
        }
    }
    public enum Gender
        {
            male,
            female
        }
    public enum Category
        {
            mouse,
            lizard,
            seed,
            superpower
        }
    public enum Abilities
        {
            static_, blaze, overgrow, guts, no_gurad, keen_eye, tangled_feet, cute_charm,
            magic_guard, damp, cloud_nine, water_absorb, soundproof
    }
    public enum Type
        {
            electric, ground, fire, water, rock, grass, poison, phychic, flying, ice, fighting,
            fairy, normal, steel
    }
    
}
