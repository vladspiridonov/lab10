using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_gradus
{
    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Gradus += value / 60;
                sec = value % 60;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        public double ToRadians()
        {
            return Math.PI / 180 * gradus + Math.PI / 180 / 60 * min + Math.PI / 180 / 60 / 60 * sec;
        }
    }
}
