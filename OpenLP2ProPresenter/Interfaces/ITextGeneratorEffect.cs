﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter.Interfaces
{
    interface ITextGeneratorEffect
    {
        public OpenLPVerse apply(OpenLPVerse original);
    }
}
