using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


class Trainer 
{
    /* Fields */


    //fuck you ryan

    private int[] attributes;
    public int X { get; set; }
    public int Y { get; set; }
    public int speed { get; set; }
    public int Facing { get; set; }

    public int Initiative { get; set; }
    public Items[] inventory { get; set; }
    public string[] rivels { get; set; }
    public Pokemon[] PC { get; set; }
    public Pokemon[] party { get; set; }

    /* methods */
    public void MoveNorth()
    {
        this.Y = this.Y - this.speed;
    }

    public void MoveWest()
    {
        this.X = this.X - this.speed;
    }

    public void MoveEast()
    {
        this.X = this.X + this.speed;
    }

    public void MoveSouth()
    {
        this.Y = this.Y + this.speed;
    }

    public void TurnLeft()
    {
        this.Facing = this.Facing - 45;
    }

    public void TurnRight()
    {
        this.Facing = this.Facing + 45;
    }

    public void Turn(int degrees)
    {
        this.Facing = this.Facing + degrees;
    }

    public void GoTo(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public void swapHands()
    {
        Console.WriteLine();
    }
    //Display hands and items
    public string showInventory()
    {
        string output =
          "\n========================\n" +
          "        Inventory" +
          "\n========================\n";
        for (int index = 0; index < inventory.Length; index++)
        {
            if (inventory[index] == null)
            {
                output = output + (index + 1) + ": ... \n";
            }
            else
            {
                output = output + (index + 1) + ": " + inventory[index].Name + "\n";
            }

        }
        output = output + "========================\n";
        return output;

    }
    public string showPC()//pokemon off hand
    {
        string output =
          "\n========================\n" +
          "        PC" +
          "\n========================\n";
        for (int index = 0; index < PC.Length; index++)
        {
            if (PC[index] == null)
            {
                output = output + (index + 1) + ": ... \n";
            }
            else
            {
                output = output + (index + 1) + ": " + PC[index].Name + "\n";
            }

        }
        output = output + "========================\n";
        return output;

    }
    public string showparty()//pockemon on hand
    {
        string output =
          "\n========================\n" +
          "        party" +
          "\n========================\n";
        for (int index = 0; index < party.Length; index++)
        {
            if (party[index] == null)
            {
                output = output + (index + 1) + ": ... \n";
            }
            else
            {
                output = output + (index + 1) + ": " + party[index].Name + "\n";
            }

        }
        output = output + "========================\n";
        return output;

    }
    public void SwapHands() //Swap Hands
    {
        Console.WriteLine(showPC());
        Console.WriteLine("Pick what pokemon you would like to put in your party");
        int PCslot = Int32.Parse(Console.ReadLine());
        Console.WriteLine(showparty());
        Console.WriteLine("Pick what slot you would like your pokemon to go");
        int partySlot = Int32.Parse(Console.ReadLine());

        Pokemon temp = this.PC[PCslot];
        this.PC[PCslot] = this.party[partySlot];
        this.party[partySlot] = temp;
    }
}


