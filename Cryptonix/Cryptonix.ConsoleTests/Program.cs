// See https://aka.ms/new-console-template for more information
using Cryptonix.Security.Random;

Console.WriteLine("Testing!");

SpiralizerTest();

void SpiralizerTest()
{
    var color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Spiralizer Tests:");
    Console.ForegroundColor = color;
    #region Test 0001
    /******************************************************************************************************************/

    Console.WriteLine("Test #0001:");

    byte[] buffer_0001 = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int w, h;
    byte[,] bytesM_0001 = Spiralizer.ArrayToMartix(out w, out h, buffer_0001);
    byte[] bytes_0001 = Spiralizer.MartixToArray(w, h, bytesM_0001);

    for (int i = 0; i < buffer_0001.Length; i++)
    {
        if (bytes_0001[i] == buffer_0001[i])
        {
            Console.WriteLine($"\tTest #0001.{i + 1}: Right.");
        }
        else
        {
            Console.WriteLine($"\tTest #0001.{i + 1}: Wrong!");
        }
    }
    /******************************************************************************************************************/
    #endregion

    #region Test 0002
    /******************************************************************************************************************/

    Console.WriteLine("Test #0002: ");

    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            Console.Write((i + 1) * (j + 1) == bytesM_0001.Length ? bytesM_0001[j, i] : $"{bytesM_0001[j, i]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    /******************************************************************************************************************/
    #endregion

    #region Test 0003
    /******************************************************************************************************************/

    Console.WriteLine("Test #0003:");
    byte[] bytes_Spiralized_0003 = Spiralizer.Spiralize(w, h, bytesM_0001);


    Console.Write($"\tTest #0003.Initial: ");
    for (int i = 0; i < buffer_0001.Length; i++)
    {
        Console.Write(i == buffer_0001.Length - 1 ? buffer_0001[i] : $"{buffer_0001[i]}, ");
    }
    Console.WriteLine();


    Console.Write($"\tTest #0003.Spiralized: ");
    for (int i = 0; i < bytes_Spiralized_0003.Length; i++)
    {
        Console.Write(i == bytes_Spiralized_0003.Length - 1 ? bytes_Spiralized_0003[i] : $"{bytes_Spiralized_0003[i]}, ");
    }
    Console.WriteLine();
    /******************************************************************************************************************/
    #endregion

    #region Test 0004
    /******************************************************************************************************************/

    Console.WriteLine("Test #0004: ");
    byte[,] bytesM_0004 = Spiralizer.ArrayToMartix(out w, out h, bytes_Spiralized_0003);

    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            Console.Write((i + 1) * (j + 1) == bytesM_0004.Length ? bytesM_0004[j, i] : $"{bytesM_0004[j, i]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    /******************************************************************************************************************/
    #endregion

    #region Test 0005
    /******************************************************************************************************************/

    Console.WriteLine("Test #0005:");
    byte[] bytes_DoubleSpiralized_0005 = Spiralizer.Spiralize(w, h, bytes_Spiralized_0003);


    Console.Write($"\tTest #0005.Spiralized: ");
    for (int i = 0; i < bytes_Spiralized_0003.Length; i++)
    {
        Console.Write(i == bytes_Spiralized_0003.Length - 1 ? bytes_Spiralized_0003[i] : $"{bytes_Spiralized_0003[i]}, ");
    }
    Console.WriteLine();

    Console.Write($"\tTest #0005.Double Spiralized: ");
    for (int i = 0; i < bytes_DoubleSpiralized_0005.Length; i++)
    {
        Console.Write(i == bytes_DoubleSpiralized_0005.Length - 1 ? bytes_DoubleSpiralized_0005[i] : $"{bytes_DoubleSpiralized_0005[i]}, ");
    }
    Console.WriteLine();
    /******************************************************************************************************************/
    #endregion
}