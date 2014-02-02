using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Levels
{
    public class Level2
    {

        public interface IMyCoolInterface
        {
            string getName();
            string getDescription();
            int getQuality();
            void increaseQuality();
        }

        public class CoolObject : IMyCoolInterface
        {
            private CoolBuilder builder;

            public CoolObject ()
            {
                builder = new CoolBuilder();
            }

            public CoolObject(CoolBuilder b)
            {
                builder = b;
            }

            public string getName()
            {
                return builder.Name;
            }

            public string getDescription()
            {
                if (char.IsUpper(builder.Name[0]))
                    return string.Format("Name: {0} ; Quality: {1}", builder.Name, builder.Quality);
                else
                {
                    string newName = "";
                    string[] mass = builder.Name.Split(' ');
                    for (int i = 0; i < mass.Length; ++i)
                    {
                        newName += mass[i][0].ToString().ToUpper();
                        for (int j = 1; j < mass[i].Length; ++j)
                            newName += mass[i][j];
                        newName += " ";
                    }
                    return string.Format("Name: {0} ; Quality: {1}", newName, builder.Quality);
                }
            }

            public int getQuality()
            {
                return builder.Quality;
            }

            public void increaseQuality()
            {
                builder.setQuality(builder.Quality+1);
            }
        }


        public class CoolBuilder
        {

            private string name;
            public string Name
            {
                get
                {
                    return name;
                }
            }
            private int quality;
            public int Quality
            {
                get
                {
                    return quality;
                }
            }
            
            public CoolBuilder()
            {
            }

            public CoolBuilder setName(string _name)
            {
                this.name = _name;
                return this;
            }

            public CoolBuilder setQuality(int _quality)
            {
                this.quality = _quality;
                return this;
            }

            

            public IMyCoolInterface build()
            {
                if (Name == null)
                    throw new MissingNameException("Name should be specified");
                return new CoolObject(this);
            }
        }

        public class MissingNameException : Exception
        {
            public MissingNameException(string message):base(message)
            { 
            }
        }




        public enum BitValue
        {
            Zero,One
        }
        public class BitArray:IComparable,ICloneable
        {
            //0 or 1 should return 

            public int getLengthOfArray()
            {
                return 0;
            }

            public BitArray(string init_number)
            {

            }
            public BitArray(int init_number)
            {
                
            }

            public object Clone()
            {
                return new object();
            }

            public int CompareTo(Object ob)
            {
                return 0;
            }

            public void invertBits()
            {
                
            }

            public string getBits()
            {
                return "";
            }

            public int getBitsInt()
            {
                return 0;
            }

        }
    }
}
