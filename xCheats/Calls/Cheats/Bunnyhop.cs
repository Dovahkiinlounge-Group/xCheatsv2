﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using xCheats.Classes;
using xCheats.Utilities;

namespace xCheats.Cheats
{
    public class Bunnyhop
    {
        public static void Run()
        {
            while (true)
            {
                if (Main.S.BunnyhopEnabled) // make sure the cheats enabled in the menu
                {
                    if (Tools.HoldingKey(Keys.VK_SPACE)) // while holding space
                    {
                        // Flags show if you are on the ground or not. 257 is standing on the ground, and 263 is crouching on the ground.
                        if ((G.Engine.LocalPlayer.Flags == 257 || G.Engine.LocalPlayer.Flags == 263) && G.Engine.LocalPlayer.Velocity > 10)
                        {
                            G.Engine.Jump();
                        }
                    }
                }
                Thread.Sleep(5); // reduce cpu usage again
            }
        }
    }
}
