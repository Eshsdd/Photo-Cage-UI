using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class CharFolder
    {

        //creating values
        protected string CharName;
        protected string CharClass;
        protected string CharLevel;
        protected string CharHealth;
        protected string CharClassAtt01;
        protected string CharClassAtt02;

        public CharFolder(string p_CharName, string p_CharClass, string p_CharLevel, string p_CharHealth, string p_CharClassAtt01, string p_CharClassAtt02)
        {
            CharName = p_CharName;
            CharClass = p_CharClass;
            CharLevel = p_CharLevel;
            CharHealth = p_CharHealth;
            CharClassAtt01 = p_CharClassAtt01;
            CharClassAtt02 = p_CharClassAtt02;
        }

        //tried making a charFolder class but ran out of time.

    }
}
