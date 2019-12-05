﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD.TicTacToe
{
    public enum State
    {
        Cross,
        Zero,
        Unset
    }

    public enum Winner
    {
        Zeroes,
        Crosses,
        Draw,
        GameIsUnfinished
    }
}
