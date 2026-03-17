using System;

namespace LinearAlgebra
{
    /// <summary>
    /// Provides mathematical operations for vectors.
    /// </summary>
    public class VectorMath
    {
        /// <summary>
        /// Calculates and returns the magnitude (length) of a 2D or 3D vector.
        /// </summary>
        /// <param name="vector">An array of doubles representing the vector.</param>
        /// <returns>
        /// The magnitude of the vector rounded to the nearest hundredth.
        /// Returns -1 if the vector is not 2D or 3D.
        /// </returns>
        public static double Magnitude(double[] vector)
        {
            if (vector == null)
                return -1;

            if (vector.Length == 2)
            {
                double x = vector[0];
                double y = vector[1];
                double length = Math.Sqrt(x * x + y * y);
                return Math.Round(length, 2);
            }
            else if (vector.Length == 3)
            {
                double x = vector[0];
                double y = vector[1];
                double z = vector[2];
                double length = Math.Sqrt(x * x + y * y + z * z);
                return Math.Round(length, 2);
            }
            else
            {
                // Not 2D or 3D
                return -1;
            }
        }
    }
}