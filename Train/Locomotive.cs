using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Locomotive
    {
        Person driver;
        Engine engine;

        public Locomotive()
        {

        }

        public Locomotive(Person driver, Engine engine)
        {
            this.driver = driver;
            this.engine = engine;
        }

        internal Engine Engine { get => engine; set => engine = value; }
        internal Person Driver { get => driver; set => driver = value; }

        public override string ToString()
        {
            return $"{Engine}, driver: {Driver}";
        }
    }
}
