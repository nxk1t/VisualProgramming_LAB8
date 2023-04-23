﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming_LAB8.Models.Serializers
{
    public interface IShapeSaver { 
        void Save(ObservableCollection<AbstractElement> figures, string path);
    }
}
