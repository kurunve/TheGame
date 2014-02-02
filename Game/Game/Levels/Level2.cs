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
            BitValue[] bits; 

            public int getLengthOfArray()
            {
                return bits.Length;
            }

            public BitArray()
            { 
            }

            public BitArray(string init_number)
            {
                int parameter;
                bool flag = Int32.TryParse(init_number, out parameter);
                if (flag)
                    bits = TransferNumber(parameter);
            }

            public BitArray(int init_number)
            {
                bits = TransferNumber(init_number);
            }

            private BitValue[] TransferNumber(int init_number)
            {
                System.Text.StringBuilder str = new System.Text.StringBuilder();
                while (init_number != 0)
                {
                    str.Append(init_number % 2);
                    init_number /= 2;
                }
                
                BitValue[] mass = new BitValue[str.Length];
                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[str.Length - 1 - i] == '1')
                        mass[i] = BitValue.One;
                    else
                        if (str[str.Length - 1 - i] == '0')
                            mass[i] = BitValue.Zero;
                }
                return mass;
            }

            public object Clone()
            {
                BitArray anotherArray = new BitArray();
                anotherArray.bits = new BitValue[this.getLengthOfArray()];
                for (int i = 0; i < this.getLengthOfArray(); ++i)
                    anotherArray.bits[i] = this.bits[i];
                return anotherArray;
            }

            public int CompareTo(Object obj)
            {
                BitArray anotherArray = obj as BitArray;
                if (anotherArray != null)
                    return this.getBitsInt().CompareTo(anotherArray.getBitsInt());
                else
                    throw new System.ArgumentException("Invalid parameter");
                
            }

            public void invertBits()
            {
                for (int i = 0; i < bits.Length; ++i)
                {
                    if (bits[i] == BitValue.One)
                        bits[i] = BitValue.Zero;
                    else
                        if (bits[i] == BitValue.Zero)
                            bits[i] = BitValue.One;
                }
            }

            public string getBits()
            {
                System.Text.StringBuilder str = new System.Text.StringBuilder(bits.Length);
                for (int i = 0; i < bits.Length; ++i)
                    str.Append((int)bits[i]);
                return str.ToString();
            }

            public int getBitsInt()
            {
                int rez = 0;
                for (int i = 0; i < this.getLengthOfArray(); ++i)
                {
                    rez += ((int)(bits[this.getLengthOfArray() - 1 - i])) * (int)System.Math.Pow(2, i);
                }
                return rez;
            }

        }
    }
}
