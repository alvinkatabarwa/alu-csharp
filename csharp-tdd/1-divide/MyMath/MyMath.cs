namespace MyMath
{
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of the matrix by a  number.
        /// </summary>
        /// <param name="matrix">2D integer array representing the matrix.</param>
        /// <param name="num">The number to divide each element by.</param>
        /// <returns>A new matrix with divided elements, or null if an error occurs.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            try
            {
                if (num == 0)
                {
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }

                int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
                
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OH No there was an issue: {ex.Message}");
                return null;
            }
        }
    }
}
