﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFightGame
{
      public interface ISpecialActionArcher
    {
        int Range { get; }
        int Power { get; }
        void DoSpecialAttack(IUnit target, Team ownTeam);
    }
}
