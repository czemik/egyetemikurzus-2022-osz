﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OQQA67.Commands
{
    internal sealed class PlayCommand : IBlackJackCommands
    {
        public string Name => "!play";

        public void Execute(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
