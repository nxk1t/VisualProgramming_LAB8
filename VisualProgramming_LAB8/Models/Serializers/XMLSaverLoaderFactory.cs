﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VisualProgramming_LAB8.Models.Serializers
{
    public class XMLSaverLoaderFactory : ISaverLoaderFactory
    {
        public IShapeLoader CreateLoader()
        {
            return new XMLLoader();
        }

        public IShapeSaver CreateSaver()
        {
            return new XMLSaver();
        }

        public bool IsMatch(string path)
        {
            return ".xml".Equals(Path.GetExtension(path));
        }
    }
}
