﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor1.Service
{
    public interface INetworkDetector
    {
        bool HasNetworkConnection();
    }
}
