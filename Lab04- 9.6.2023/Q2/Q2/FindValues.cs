using System;

namespace Q2
{
    internal class FindValues

    {
        public float area;
        public float circum;

        public float findArea(float r)
        {
            area = (float)(r * r * Math.PI);

            return (float)area;
        }
        public float findCircumference(float r)
        {
            circum = (float)(2 * r * Math.PI);
            return (float)circum;
        }
    }
}
