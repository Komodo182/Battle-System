using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    internal class Enemy : Entity
    {
        public Enemy(string name) : base(name)
        {
        
        }
    }
    internal class Skeleton : Enemy
    {
        public Skeleton() : base("Skeleton")
        {
            strength = 2;
            EquipItem(new Weapon("Rusty sword", "Flimsy at first look but can cause a infection!", 1));
        }
    }
    internal class Goblin : Enemy
    {
        public Goblin() : base("Goblin")
        {
            strength = 3;
            EquipItem(new Weapon("Dull dagger", "Small but quick and deadly.", 1));
        }
    }
    internal class Ogre : Enemy
    {
        public Ogre() : base("Ogre")
        {
            strength = 5;
            EquipItem(new Weapon("Lamb's left leg", "Unusual choice of weapon but still hurts.", 1));
        }
    }
}
