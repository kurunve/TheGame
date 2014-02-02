using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Levels
{
    public class Level2
    {

        public interface IMyCoolInferface
        {
            string getName();
            string getDescription();
            int getQuality();
            void increaseQuality();
        }


        public class CoolBuilder : IMyCoolInferface
        {

            private string Name;
            private int Quality;
            
            public CoolBuilder()
            {
            }

            public CoolBuilder setName(string name)
            {
                this.Name = name;
                return this;
            }

            public CoolBuilder setQuality(int quality)
            {
                this.Quality = quality;
                return this;
            }

            public string getName()
            {
                return Name;
            }

            public string getDescription()
            {
                if (char.IsUpper(Name[0]))
                    return string.Format("Name: {0} ; Quality: {1}", Name, Quality);
                else
                {
                    string newName = "";
                    string[] mass = Name.Split(' ');
                    for (int i = 0; i < mass.Length; ++i)
                    {
                        newName += mass[i][0].ToString().ToUpper();
                        for (int j = 1; j < mass[i].Length; ++j)
                            newName += mass[i][j];
                        newName += " ";
                    }
                    return string.Format("Name: {0} ; Quality: {1}", newName, Quality);
                }
            }

            public int getQuality()
            {
                return Quality;
            }

            public void increaseQuality()
            {
                Quality++;
            }

            public IMyCoolInferface build()
            {
                if (Name == null)
                    throw new MissingNameException("Name should be specified");
                return (IMyCoolInferface)this;
            }
        }

        public class MissingNameException : Exception
        {
            public MissingNameException(string message):base(message)
            { 
            }
        }
    }
}
