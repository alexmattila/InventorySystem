using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model
{
    [Serializable]
    class Items
    {
        private int itemID;
        private string name;
        private int attack;
        private int speed;
        private int magic;
        private int defence;

        public Items()
        {
            this.name = "No Name";
            this.attack = 0;
            this.speed = 0;
            this.magic = 0;
            this.defence = 0;
        }

        public Items(string inNamn,
                    int inAttack,
                    int inSpeed,
                    int inMagic,
                    int inDefence)
        {
            this.name = inNamn;
            this.attack = inAttack;
            this.speed = inSpeed;
            this.magic = inMagic;
            this.defence = inDefence;
        }

        public void setItemID(int inItemID)
        {
            this.itemID = inItemID;
        }
        public int getItemID()
        {
            return this.itemID;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAttack()
        {
            return this.attack;
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public int getMagic()
        {
            return this.magic;
        }
        public int getDefence()
        {
            return this.defence;
        }

        public void setName(string inName)
        {
            this.name = inName;
        }
        public void setAttack(int inAttack)
        {
            this.attack = inAttack;
        }
        public void setSpeed(int inSpeed)
        {
            this.speed = inSpeed;
        }
        public void setMagic(int inMagic)
        {
            this.magic = inMagic;
        }
        public void setDefence(int inDefence)
        {
            this.defence = inDefence;
        }

        public override string ToString()
        {
            string response =
                "ID:" + this.itemID + "\n" +
                "Name:" + this.name + "\n" +
                "Attack:" + this.attack + "\n" +
                "Speed:" + this.speed + "\n" +
                "Magic:" + this.magic + "\n" +
                "Defence:" + this.defence;
            return response;
        }
    }
}






