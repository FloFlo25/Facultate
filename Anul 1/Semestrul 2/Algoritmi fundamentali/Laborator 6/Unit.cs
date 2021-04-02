using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laborator_6
{
    public enum default_units
    {
        [army_attribute (10, 15, 150, 10, 15)] soldier,
        [army_attribute(25, 5, 100, 10, 15)] archer,
        [army_attribute(30, 10, 500, 20, 5)] orc,
        [army_attribute(10, 10, 100, 10, 15)] gnome
    }

    public class army_attribute : Attribute
    {
        public int Attack; // trainning in attack
        public int Deffense; // trainning in defense
        public int HP; //hp = 0 --> unitatea este distrusa
        public int FirePower; //putere de attack
        public int Armor; //amura
        public army_attribute(int Attack, int Deffense, int HP, int FirePower, int Armor)
        {
            this.Attack = Attack;
            this.Deffense = Deffense;
            this.HP = HP;
            this.FirePower = FirePower;
            this.Armor = Armor;
        }
    }

    public class Unit
    {
        public string Name;
        public int Attack; // trainning in attack
        public int Deffense; // trainning in defense
        public int HP; //hp = 0 --> unitatea este distrusa
        public int FirePower; //putere de attack
        public int Armor; //amura
        public int size;

        //TODO range, movement
        //

        Color fillColor;
        Color drawColor;
        PointF mapLocation;

        public bool Destroyed;


        public Unit(default_units T)
        {

        }

        public Unit(int Attack, int Deffense, int HP, int FirePower, int Armor)
        {
            this.Attack = Attack;
            this.Deffense = Deffense;
            this.HP = HP;
            this.FirePower = FirePower;
            this.Armor = Armor;
            this.Name = "";
            this.Destroyed = false;
            this.size = 7 + HP / 50;

        }

        public void setColor(Color fillColor, Color drawColor)
        {
            this.fillColor = fillColor;
            this.drawColor = drawColor;
        }

        public void setMapLocation(PointF mapLocation)
        {
            this.mapLocation = mapLocation;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public void draw(Graphics toDraw)
        {
            
            toDraw.FillEllipse(new SolidBrush(fillColor), mapLocation.X - size, mapLocation.Y - size, size * 2 + 1, size * 2 + 1);
            toDraw.DrawEllipse(new Pen(drawColor), mapLocation.X - size, mapLocation.Y - size, size * 2 + 1, size * 2 + 1);
            if (Name!="")
            {
                toDraw.DrawString(Name, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(drawColor), mapLocation);
            }
            toDraw.DrawString(HP.ToString(), new Font("Arial", 10, FontStyle.Bold), new SolidBrush(drawColor), new PointF(mapLocation.X,mapLocation.Y));
        }
    }

    public class Leader : Unit
    {
        public Leader(int Attack, int Deffense, int HP, int FirePower, int Armor) : base(Attack, Deffense, HP, FirePower, Armor)
        {

        }
    }
}
