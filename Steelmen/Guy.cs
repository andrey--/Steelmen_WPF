﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steelmen
{
    public class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount<=Cash && amount>0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Not ehough " + amount + " say " + Name);
                return 0;
            }
        }
        public int ReceiveCash(int amount)
        {
            if (amount>0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Don't need " + amount + " say " + Name);
                return 0;
            }
        }
    }
}
