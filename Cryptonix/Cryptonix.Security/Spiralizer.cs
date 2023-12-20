namespace Cryptonix.Security
{
    /**
     * Класс для псевдослучайного перемешивания массива.
     * Массив перемешивается по спирали.
     **/
    public static class Spiralizer
    {
        private static byte[] Spiralize(int width, int height, byte[,] matrix)
        {
            if (matrix.Length == 0)
                return new byte[0];

            int resultSize = matrix.Length;

            byte[] result = new byte[resultSize];

            bool isItTheEnd = false;
            int startTopIndex_i = 0;
            int endTopIndex_i = width - 1;
            int startTopIndex_j = 0;
            int endTopIndex_j = height - 1;
            int currentIndex = 0;
            while (!isItTheEnd)
            {
                for (int j = startTopIndex_j; j <= endTopIndex_j && currentIndex != resultSize; j++)
                {
                    result[currentIndex] = matrix[startTopIndex_i, j];
                    currentIndex++;
                }

                startTopIndex_i++;

                for (int i = startTopIndex_i; i <= endTopIndex_i && currentIndex != resultSize; i++)
                {
                    result[currentIndex] = matrix[i, endTopIndex_j];
                    currentIndex++;
                }

                endTopIndex_j--;

                for (int j = endTopIndex_j; j >= startTopIndex_j && currentIndex != resultSize; j--)
                {
                    result[currentIndex] = matrix[endTopIndex_i, j];
                    currentIndex++;
                }

                endTopIndex_i--;

                for (int i = endTopIndex_i; i >= startTopIndex_i && currentIndex != resultSize; i--)
                {
                    result[currentIndex] = matrix[i, startTopIndex_j];
                    currentIndex++;
                }

                startTopIndex_j++;


                if (currentIndex == resultSize)
                {
                    isItTheEnd = true;
                }
            }

            return result;
        }

        private static byte[,] ArrayToMartix(out int width, out int height, byte[] bytes)
        {
            /* Example:
             * bytes = 
             *  1, 2, 3, 4, 5, 6, 7
             */

            if (bytes.Length == 0)
            {
                width = 0;
                height = 0;
                return new byte[0, 0];
            }


            int currentWidth = bytes.Length / 2;
            int currentHeight = bytes.Length / currentWidth;

            while (currentWidth > currentHeight)
            {
                currentWidth = currentWidth - 1;
                    
                currentHeight = bytes.Length / currentWidth;
            }

            if(currentWidth * currentHeight != bytes.Length)
            {
                currentWidth = 1;
                currentHeight = bytes.Length;
            }

            byte[,] result = new byte[currentWidth, currentHeight];

            for (int i = 0, iW = 0, iH = 0; i < bytes.Length; i++)
            {
                result[iW, iH] = bytes[i];

                iW++;

                if (iW >= currentWidth)
                {
                    iW = 0;
                    iH++;
                }

                if (iH >= currentHeight)
                    iH = 0;
            }
            width = currentWidth;
            height = currentHeight;
            return result;
        }

        private static byte[] MartixToArray(int width, int height, byte[,] bytes)
        {
            if (bytes.Length == 0)
            {
                return new byte[0];
            }

            byte[] result = new byte[width * height];

            int r = 0;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    result[r] = bytes[i, j];
                    r++;
                }
            }

            return result;
        }

        public static byte[] Spiralize(byte[] byteArray)
        {
            int width, height;

            var matrix = ArrayToMartix(out width, out height, byteArray);

            if (width * height == 0)
                return new byte[0];

            return Spiralize(width, height, matrix);
        }

        private static byte[,] SpiralizedArrayToNormalMartix(out int width, out int height, byte[] bytes)
        {
            /* Example:
             * bytes = 
             *  1, 2, 3, 4, 5, 6, 7, 8, 9
             */

            if (bytes.Length == 0)
            {
                width = 0;
                height = 0;
                return new byte[0, 0];
            }


            int currentWidth = bytes.Length / 2;
            int currentHeight = bytes.Length / currentWidth;

            while (currentWidth > currentHeight)
            {
                currentWidth = currentWidth - 1;
                currentHeight = bytes.Length / currentWidth;
            }

            if (currentWidth * currentHeight != bytes.Length)
            {
                currentWidth = 1;
                currentHeight = bytes.Length;
            }

            byte[,] result = new byte[currentWidth, currentHeight];

            // Despiralization of Array in Matrix

            int resultSize = bytes.Length;
            bool isItTheEnd = false;
            int startTopIndex_i = 0;
            int endTopIndex_i = currentWidth - 1;
            int startTopIndex_j = 0;
            int endTopIndex_j = currentHeight - 1;
            int currentIndex = 0;
            while (!isItTheEnd)
            {
                for (int j = startTopIndex_j; j <= endTopIndex_j && currentIndex != resultSize; j++)
                {
                    result[startTopIndex_i, j] = bytes[currentIndex];
                    currentIndex++;
                }

                startTopIndex_i++;

                for (int i = startTopIndex_i; i <= endTopIndex_i && currentIndex != resultSize; i++)
                {
                    result[i, endTopIndex_j] = bytes[currentIndex];
                    currentIndex++;
                }

                endTopIndex_j--;

                for (int j = endTopIndex_j; j >= startTopIndex_j && currentIndex != resultSize; j--)
                {
                    result[endTopIndex_i, j] = bytes[currentIndex];
                    currentIndex++;
                }

                endTopIndex_i--;

                for (int i = endTopIndex_i; i >= startTopIndex_i && currentIndex != resultSize; i--)
                {
                    result[i, startTopIndex_j] = bytes[currentIndex];
                    currentIndex++;
                }

                startTopIndex_j++;


                if (currentIndex == resultSize)
                {
                    isItTheEnd = true;
                }
            }

            width = currentWidth;
            height = currentHeight;
            return result;
        }

        private static byte[] Despiralize(out int width, out int height, byte[] spiralizedArray)
        {
            if (spiralizedArray.Length == 0)
            {
                width = 0;
                height = 0;
                return new byte[0];
            }

            var despiralizedMatrix = Spiralizer.SpiralizedArrayToNormalMartix(out width, out height, spiralizedArray);

            return Despiralize(width, height, despiralizedMatrix);
        }

        public static byte[] Despiralize(byte[] spiralizedArray)
        {
            int width, height;

            var despiralizedMatrix = Spiralizer.SpiralizedArrayToNormalMartix(out width, out height, spiralizedArray);

            if (width == 0 && height == 0)
            {
                return new byte[0];
            }

            return Despiralize(width, height, despiralizedMatrix);
        }

        private static byte[] Despiralize(int width, int height, byte[,] despiralizedMatrix)
        {
            if (width * height == 0)
                return new byte[0];

            byte[] result = new byte[width * height];

            int currentIndex = 0;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    result[currentIndex] = despiralizedMatrix[i, j];
                    currentIndex++;
                }
            }

            return result;
        }
    }
}