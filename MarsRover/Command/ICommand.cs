﻿using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Command
{
    public interface ICommand
    {
        public void Execute(Rover rover);
    }
}
