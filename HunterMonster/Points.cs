using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster
{
    internal class Points
    {
        public int Amount = 0;
        public string Name;

        public static readonly List<Points> points = new List<Points>()
        {
            new Points
            {
                Name = "Gold",
                Amount = 10000,
            },
            new Points
            {
                Name = "DinoMat",
            },
            new Points
            {
                Name = "SaurusMat",
            },
        };

    }
}
