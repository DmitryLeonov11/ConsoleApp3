﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            bool shouldFire = true;
            if (!enemyInFront || enemyInFront && (enemyName == "boss") && (robotHealth < 50))
            {
                shouldFire = false;
            }
            return shouldFire;
        }
    }
}
