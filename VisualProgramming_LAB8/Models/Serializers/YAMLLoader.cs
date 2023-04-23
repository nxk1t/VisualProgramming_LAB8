﻿using System.Collections.ObjectModel;
using System.IO;
using YamlDotNet.Serialization;

namespace VisualProgramming_LAB8.Models.Serializers
{
    public class YAMLLoader : IShapeLoader
    {
        public ObservableCollection<AbstractElement> Load(string path)
        {
            var deserializer = new DeserializerBuilder()
                .WithTagMapping("!grid", typeof(SerializebleGrid))
                .WithTagMapping("!line", typeof(SerializebleLine))
                .Build();
            string input;
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }
            var ser = deserializer.Deserialize<ObservableCollection<SerializebleElement>>(input);
            return ConvertElementToSerializeObject.FromSerializer(ser);
        }
    }
}