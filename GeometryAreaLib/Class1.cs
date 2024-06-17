namespace GeometryAreaLib
{
    public static class TwoDimensionalAreaCalculator
    {
        /// <summary>
        /// Calculates the area of a circle given its radius
        /// </summary>
        /// <param name="radius">The radius of the circle. Must be greater than zero</param>
        /// <returns>The area of the circle</returns>
        /// <exception cref="ArgumentException">Thrown when the radius is negative</exception>
        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculates the area of a triangle given its three sides using Heron's formula.
        /// </summary>
        /// <param name="a">The length of side a of the triangle. Must be greater than zero</param>
        /// <param name="b">The length of side b of the triangle. Must be greater than zero</param>
        /// <param name="c">The length of side c of the triangle. Must be greater than zero</param>
        /// <returns>The area of the triangle</returns>
        /// <exception cref="ArgumentException">Thrown when any of the sides are non-positive or the sides do not form a valid triangle</exception>
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (!CheckSidesFormTriangle(a, b, c))
            {
                throw new ArgumentException("The sides do not form a valid triangle");
            }

            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        /// <summary>
        /// Determines if a triangle with the given side lengths is a right triangle
        /// </summary>
        /// <param name="a">The length of side a of the triangle. Must be greater than zero</param>
        /// <param name="b">The length of side b of the triangle. Must be greater than zero</param>
        /// <param name="c">The length of side c of the triangle. Must be greater than zero</param>
        /// <returns>True if the triangle is a right triangle; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown when any of the sides are non-positive or the sides do not form a valid triangle</exception>
        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (!CheckSidesFormTriangle(a, b, c))
            {
                throw new ArgumentException("The sides do not form a valid triangle.");
            }
            double[] sides = { a, b, c };
            Array.Sort(sides);
            double x = sides[0];
            double y = sides[1];
            double z = sides[2];

            if(z * z == x*x + y*y)
            { 
                return true; 
            }
            return false;
        }

        /// <summary>
        /// Determines whether sides a b c can form a triangle
        /// </summary>
        public static bool CheckSidesFormTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            return true;
        }
    }
}
