﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer.Contract
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
