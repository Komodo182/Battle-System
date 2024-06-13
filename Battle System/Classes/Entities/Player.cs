using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        protected string ClassName;
        public Player(string name) : base(name)
        {
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
            ClassName = "None";
        }
        internal void GiveItem(Item item)
        {
            
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
            ClassName = "Fighter";
            EquipItem(new Weapon("Great British Broad Sword", "Brutal two handed blade that is said to be able to split countries in half.", 1));
        }
        public override int Attack()
        {
            string playerAttackChoice = OptionCheck("Select your attack from the list below:\n" +
                "1: Basic Attack\n" +
                "2: Charge Strike (Requires minimum of 2 mana)\n" +
                "3: Swing (Requires minimum of 5 mana)\n"+
                "4: Split (Reuqires minimum of 12 mana)",
                new string[] { "1", "2", "3" , "4" });

            if (playerAttackChoice == "1")
            {
                Console.WriteLine("You chose 'Basic Attack' you've dealt 2 Damage.");
                return 2;
            }

            if (playerAttackChoice == "2" && mp >= 2)
            {
                mp = mp - 2;
                Console.WriteLine("You chose 'Charge Strike' you've dealt 5 Damage by charging and penetrating the enemy in the torso");
                return 5;
            }

            if (playerAttackChoice == "3" && mp >= 5)
            {
                mp = mp - 5;
                Console.WriteLine("You chose 'Swing' you've dealt 10 Damage by swinging the blade across the enemy.");
                return 10;
            }

            if (playerAttackChoice == "4" && mp >= 12)
            {
                mp = mp - 12;
                Console.WriteLine("You chose 'Split' you've dealt a deadly blow dragging the blade from the scalp down to the crotch.");
                return 1000;
            }
            else
            {
                Console.WriteLine("You didnt fit the requirements of the attack selected.\nTherefore you're doing a basic attack. ");
                return 2;
            }

            static string PresenceCheck(string message)
            {
                string userInput = "";
                while (userInput.Length == 0)
                {
                    Console.WriteLine(message);
                    userInput = Console.ReadLine();
                }
                return userInput;
            }

            static string OptionCheck(string message, string[] options)
            {
                string userInput = "";
                while (!options.Contains(userInput))
                {
                    userInput = PresenceCheck(message);
                }
                return userInput;
            }
        }
    }
    public class Archer : Player
    {
        public Archer(string name) : base(name)
        {
            strength = 3;
            ClassName = "Archer";
            EquipItem(new Weapon("French Long Bow", "A powerful long range bow able to hit enemies from great distances.", 1));
        }
        public override int Attack()
        {
            string playerAttackChoice = OptionCheck("Select your attack from the list below:\n" +
                "1: Basic Attack\n" +
                "2: Charge Strike (Requires minimum of 2 mana)\n" +
                "3: Flame Arrow (Requires minimum of 5 mana)\n" +
                "4: Deadly Precision (Reuqires minimum of 12 mana)",
                new string[] { "1", "2", "3", "4" });

            if (playerAttackChoice == "1")
            {
                Console.WriteLine("You chose 'Basic Attack' you've dealt 2 Damage.");
                return 2;
            }

            if (playerAttackChoice == "2" && mp >= 2)
            {
                mp = mp - 2;
                Console.WriteLine("You chose 'Charge Strike' you've dealt 5 Damage by hitting the enemy with a well charged shot.");
                return 5;
            }

            if (playerAttackChoice == "3" && mp >= 5)
            {
                mp = mp - 5;
                Console.WriteLine("You chose 'Flame Arrow' you've dealt 10 Damage hitting the enermy with a flaming arrow.");
                return 10;
            }

            if (playerAttackChoice == "4" && mp >= 12)
            {
                mp = mp - 12;
                Console.WriteLine("You chose 'Deadly Precision' you've dealt a deadly blow by deadly precision of the arrow to the head.");
                return 1000;
            }
            else
            {
                Console.WriteLine("You didnt fit the requirements of the attack selected.\nTherefore you're doing a basic attack. ");
                return 2;
            }

            static string PresenceCheck(string message)
            {
                string userInput = "";
                while (userInput.Length == 0)
                {
                    Console.WriteLine(message);
                    userInput = Console.ReadLine();
                }
                return userInput;
            }

            static string OptionCheck(string message, string[] options)
            {
                string userInput = "";
                while (!options.Contains(userInput))
                {
                    userInput = PresenceCheck(message);
                }
                return userInput;
            }
        }
    }
    public class Brute : Player
    {
        public Brute(string name) : base(name)
        {
            strength = 15;
            ClassName = "Fighter";
            EquipItem(new Weapon("Fists", "If used well can dominate by spilling blood on any battlefield.", 1));
        }
        public override int Attack()
        {
            string playerAttackChoice = OptionCheck("Select your attack from the list below:\n" +
                "1: Basic Attack\n" +
                "2: Ground Smash (Requires minimum of 2 mana)\n" +
                "3: Tear (Requires minimum of 5 mana)\n"+
                "4: Left Right Goodnight (Reuqires minimum of 12 mana)",
                new string[] { "1", "2", "3" , "4" });

            if (playerAttackChoice == "1")
            {
                Console.WriteLine("You chose 'Basic Attack' you've dealt 2 Damage.");
                return 2;
            }

            if (playerAttackChoice == "2" && mp >= 2)
            {
                mp = mp - 2;
                Console.WriteLine("You chose 'Ground Smash' you've dealt 5 Damage by charging and penetrating the enemy in the torso");
                return 5;
            }

            if (playerAttackChoice == "3" && mp >= 5)
            {
                mp = mp - 5;
                Console.WriteLine("You chose 'Tear' you've dealt 10 Damage by swinging the blade across the enemy.");
                return 10;
            }

            if (playerAttackChoice == "4" && mp >= 12)
            {
                mp = mp - 12;
                Console.WriteLine("You chose 'Left,Right,Goodnight' you've dealt a deadly blow dragging the blade from the scalp down to the crotch.");
                return 1000;
            }
            else
            {
                Console.WriteLine("You didnt fit the requirements of the attack selected.\nTherefore you're doing a basic attack. ");
                return 2;
            }

            static string PresenceCheck(string message)
            {
                string userInput = "";
                while (userInput.Length == 0)
                {
                    Console.WriteLine(message);
                    userInput = Console.ReadLine();
                }
                return userInput;
            }

            static string OptionCheck(string message, string[] options)
            {
                string userInput = "";
                while (!options.Contains(userInput))
                {
                    userInput = PresenceCheck(message);
                }
                return userInput;
            }
        }
    }
    static string PresenceCheck(string message)
    {
        string userInput = "";
        while (userInput.Length == 0)
        {
            Console.WriteLine(message);
            userInput = Console.ReadLine();
        }
        return userInput;
    }

    static string OptionCheck(string message, string[] options)
    {
        string userInput = "";
        while (!options.Contains(userInput))
        {
            userInput = PresenceCheck(message);
        }
        return userInput;
    }
}
