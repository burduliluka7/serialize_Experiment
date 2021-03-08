using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialize_Experiment
{
    class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Age { get; private set; }
        public Class1(int id, string name, string lastName, double age)
            {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;

           
        }
        public string GetInfo()
        {
            return $"user id is: {Id}, Name: {Name}, LastName: {LastName}, Age:{Age};";

        }
        public void SerializeNow()
        {
            File f = new File("temp.dat");
            Stream s = f.Open(FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, Id);
            s.Close();
        }
         




    }
}
