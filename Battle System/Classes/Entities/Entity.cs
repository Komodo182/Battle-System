using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle_System.Classes.Items;

namespace Battle_System.Classes.Entities
{
    public class Entity
    {
        protected Random rng;
        protected int hp;
        protected int mp;
        protected string name;

        protected int strength;
        protected float accuracy;

        private Inventory inventory;
        protected Weapon weapon = new Weapon("No weapon", "you do not have a weapon", 1);

        public Entity(string name)
        {
            this.name = name;
            hp = 10;
            mp = 10;
            strength = 1;
            rng = new Random();
            accuracy = 0.8f;
        }
        public string GetName()
        {
            return name;
        }
        public virtual int Attack()
        {
            if (rng.NextDouble() < accuracy)
            {
                return strength * weapon.getAttack();
            }
            else
            {
                Console.WriteLine($"{name} missed!");
                return 0;
            }
        }
        public void Damage(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
        public int GetHp()
        {
            return hp;
        }
        public void GiveItem(Item item)
        {
            inventory.addItem(item);
        }
        public void EquipItem(Item item)
        {
            if (item.IsEquipable())
            {
                weapon = (Weapon)item;
            }
        }
        public string GetWeaponName()
        {
            return weapon.GetName();
        }
        public string GetWeaponDescription()
        {
            return weapon.GetDescription();
        }
        public int GetMp()
        {
            return mp;
        }
    }
}
