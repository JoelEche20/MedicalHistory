using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    abstract class Person
    {
        protected String Name { get; set; }
        protected String Ci { get; set; }

        public void SetData(String name, String ci)
        {
            this.Name = name;
            this.Ci = ci;
        }
        public abstract void GetData();
    }
}
