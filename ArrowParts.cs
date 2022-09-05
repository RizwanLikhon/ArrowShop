using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ArrowShop
{
    // defining the class of ArrowParts 
    public class ArrowParts
    {
        private int arrowhead = 0;
        private int fletching = 0;
        private double shaft = 0.0;
        double price;

        //initializing gets and sets
        public int ArrowHead
        {
            
            get { return this.arrowhead; }
            set
            {
                
                
                    if (value <= 3 && value > 2)
                    {
                        this.arrowhead = 25;
                    }
                    else if (value <= 2 && value > 1)
                    {
                        this.arrowhead = 17;
                    }
                    else if (value <= 1 && value > 0)
                    {
                        this.arrowhead = 11;
                    }
                    else
                    {
                        Console.WriteLine("We only have these 3 options");
                        Console.WriteLine("Try Again");
                        Console.WriteLine(" 1.Steel 2.Wood 3.Obsidian\n");
                        Console.WriteLine(" Which one you want? ");
                        
                    }
                
            }
        }
        public int Fletching
        {
            get { return this.fletching; }
            set
            {
                
                    if (value <= 3 && value > 2)
                    {
                        this.fletching = 30;
                        
                    }
                    else if (value <= 2 && value > 1)
                    {
                        this.fletching = 20;
                    }
                    else if (value <= 1 && value > 0)
                    {
                        this.fletching = 10;
                    }
                    else
                    {
                        Console.WriteLine("We only have these 3 options");
                        Console.WriteLine("Try Again");
                        Console.WriteLine("1.Plastic feathers 2.Turkey feathers 3.Goose feathers\n");
                        Console.WriteLine("Tell me which one you would like to have?");
                        
                    }
                
            }
        }
        public double Shaft
        {
            get { return this.shaft; }
            set
            {
                
                    if (value >= 60 && value <= 100)
                    {
                        this.shaft = value * 0.05;
                        return;
                    }
                    else 
                    {
                        Console.WriteLine(" Length should be between 60 and 100 cm long");
                        Console.WriteLine(" Try Again");
                        Console.WriteLine(" How long you want your arrow to be: ");
                        
                    }
                

            }
        }
        
        public override string ToString()
        {
            string msg = "";
            msg = msg + " Arrow Head Cost " + this.arrowhead + " Gold \n";
            msg = msg + " Fletching Cost " + this.fletching + " Gold \n";
            msg = msg + " Shaft Cost " + this.shaft + " Gold \n";
            msg = msg + " Total Cost " + this.price + " Gold \n";
        
            return msg;
        }



        // declaring constructors
        public ArrowParts(int aarrowhead, int afletching, double ashaft)
        {
            
            
                Console.WriteLine(" There are 3 kinds of Arrow head\n");
                Console.WriteLine(" 1.Steel 2.Wood 3.Obsidian\n");
                Console.WriteLine(" Steel costs 11 gold,\n" + " Wood costs 17 gold,\n " + "Obsidian costs 25 gold\n ");
                Console.WriteLine(" Which one you want? ");
            
            
            while (true)
            {

                Console.Write(" Ans: "); aarrowhead = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                
                if (aarrowhead>3)
                {
                    Console.WriteLine(" We only have these 3 options");
                    Console.WriteLine(" Try Again");
                    Console.WriteLine(" 1.Steel 2.Wood 3.Obsidian\n");
                    Console.WriteLine(" Which one you want? ");
                    
                }
                else
                    break;
               
            }
                Console.WriteLine("\n\n");
                Console.WriteLine(" There are 3 kinds of the fletching\n");
                Console.WriteLine(" 1.Plastic feathers 2.Turkey feathers 3.Goose feathers\n");
                Console.WriteLine(" Plastic feathers costs 10 gold, \n" + " Turkey feathers costs 20 gold, \n" + " Goose feathers costs 30 gold.\n");
                Console.WriteLine(" Tell me which one you would like to have?");
            
            while (true)
            {

                Console.Write(" Ans: "); afletching = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                
                if (afletching > 3)
                {
                    
                    Console.WriteLine(" We only have these 3 options");
                    Console.WriteLine(" Try Again");
                    Console.WriteLine(" 1.Plastic feathers 2. Turkey feathers 3. Goose feathers\n");
                    Console.WriteLine(" Tell me which one you would like to have?");
                }
                else
                    break;

            }
                Console.WriteLine("\n\n");
                Console.WriteLine(" Now let's get into Shaft");
                Console.WriteLine(" Every centimeter costs 0.05 gold ");
                Console.WriteLine(" Its has to be between 60 and 100 cm long");
                Console.WriteLine(" How long you want your arrow to be");
            
            while (true)
            {

                Console.Write(" Ans: ");  ashaft = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                
                if (ashaft < 60 || ashaft > 100)
                {
                    Console.WriteLine(" Length should be between 60 and 100 cm long");
                    Console.WriteLine(" Try Again");
                    Console.WriteLine(" How long you want your arrow to be: ");
                }
                else
                    break ;

            }
                this.ArrowHead = aarrowhead;
                this.Fletching = afletching;
                this.Shaft = ashaft;
            
                Console.WriteLine("\n\n\n");
            // taking the value and calculating in the Price Section
                this.price = ArrowHead + Fletching + Shaft;
            
        }
    }
}
