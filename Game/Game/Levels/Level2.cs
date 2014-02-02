using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Levels
{
    class Level2
    {

        public interface IMyCoolInferface
        {
            string getName();
            string getDescription();
            int getQuality();
            void increaseQuality();
        }


        public class CoolBuilder
        {
            //fields and methods can be added
            public CoolBuilder()
            {
                //can be updated
            }

            public CoolBuilder setName(string name)
            {
                return null;
            }

            public CoolBuilder setQuality(int quality)
            {
                return null;
            }

            public IMyCoolInferface build()
            {
                return null;
            }
        }

        public class MissingNameException : Exception
        {
        }
    }
}
