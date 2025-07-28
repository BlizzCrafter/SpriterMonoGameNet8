// Copyright (C) The original author or authors
//
// This software may be modified and distributed under the terms
// of the zlib license.  See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace SpriterDotNet.Sample
{
    public static class Constants
    {
        public static readonly List<string> ScmlFiles = new List<string>
        {
            "AtlasExample/0",
            "GreyGuy/player",
            "TestSquares/squares",
            "GreyGuyPlus/player_006"
        };

        public static readonly List<string> KeyBindingsList = new List<string>
        {
            "Enter = Next Scml",
            "Space = Next Animation",
            "H/J = Change Anim Speed",
            "R = Reverse Direction",
            "X = Reset Animation",
            "T = Transition to Next Animation",
            "K/L = Push/Pop CharMap",
            "W/A/S/D = Move",
            "Q/E = Rotate",
            "N/M = Scale",
            "F/G = Flip",
            "C = Toggle Colour",
            "O = Toggle Sprite Outlines",
            "V = Toggle VSync"
        };

        public static readonly string KeyBindings = string.Join(Environment.NewLine, KeyBindingsList);

        public static readonly Config Config = new Config
        {
            MetadataEnabled = true,
            EventsEnabled = true,
            PoolingEnabled = true,
            TagsEnabled = true,
            VarsEnabled = true,
            SoundsEnabled = false
        };
    }
}
