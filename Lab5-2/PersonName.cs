using System;

namespace Lab5_2
{
    public class PersonName
    {
        public string personName;
    }

    [Serializable]
    class Invalid : Exception
    {
        public Invalid()
        {
        }

        public Invalid(string Msg) : base(Msg)
        {
        }
    }
}