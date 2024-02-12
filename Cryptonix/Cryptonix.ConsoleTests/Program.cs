// See https://aka.ms/new-console-template for more information
using Cryptonix.Security;

Console.WriteLine("Testing!");
/*
Random random = new Random();
for(int i = 0; i < 17; i++)
{
    for (int j = 0; j < 17; j++)
    {
        Console.Write(random.Next(255) + ", ");
    }
    Console.WriteLine();
}
*/
/*
byte[] bytes = new byte[] {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 0,
    1, 2, 3, 4, 5, 6, 7, 8, 9, 0,
    1, 2, 3, 4, 5, 6, 7, 8, 9, 0,
    1, 2, 3, 4, 5, 6, 7, 8, 9, 0,
    1, 2, 3, 4, 5, 6, 7, 8, 9, 0,
    1, 2, 3, 4, 5, 6, 7, 8, 9, 0,
    1, 2, 3, 4, 5, 6, 7, 8, 9, 0,
};


byte[] result1 = Xorer.Xor4Encrypt(bytes, new byte[] { 4, 255, 2, 123, 144, 56, 77, 21, 59, 10 });
byte[] result1_2 = Xorer.Xor4Dencrypt(result1, new byte[] { 4, 255, 2, 123, 144, 56, 77, 21, 59, 10 });
long i = 0;
foreach(byte r in result1_2)
{
    if(r != bytes[i++]) {  Console.WriteLine("Error"); }
}
//SpiralizerTest();
*/
int[] arr = new int[] {0, 1, 2 , 3};
int i = 1;
var arr2 = arr[^(i+1)];
Console.Write(arr2);/*
foreach (var i in arr2)
{
    Console.Write(i);
}*/

void SpiralizerTest()
{
    var color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Spiralizer Tests:");
    Console.ForegroundColor = color;
    #region Test 0001
    /******************************************************************************************************************/
    /*
    Console.WriteLine("Test #0001:");

    byte[] buffer_0001 = new byte[] { 1, 2, 3, 4, 5, 6, 7/*, 8, 9*/ /*};*/
    /*int w, h;
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
    }*/
    /******************************************************************************************************************/
    #endregion

    #region Test 0002
    /******************************************************************************************************************/
    /*
    Console.WriteLine("Test #0002: ");

    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            Console.Write((i + 1) * (j + 1) == bytesM_0001.Length ? bytesM_0001[j, i] : $"{bytesM_0001[j, i]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();*/
    /******************************************************************************************************************/
    #endregion

    #region Test 0003
    /******************************************************************************************************************/
    /*
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
    Console.WriteLine();*/
    /******************************************************************************************************************/
    #endregion

    #region Test 0004
    /******************************************************************************************************************/
    /*
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
    Console.WriteLine();*/
    /******************************************************************************************************************/
    #endregion

    #region Test 0005
    /******************************************************************************************************************/
    /*
    Console.WriteLine("Test #0005:");
    byte[] bytes_DoubleSpiralized_0005 = Spiralizer.Spiralize(bytes_Spiralized_0003);


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
    Console.WriteLine();*/
    /******************************************************************************************************************/
    #endregion

    #region Test 0006
    /******************************************************************************************************************/
    /*
    Console.WriteLine("Test #0006:");
    var despiralizedMatrix = Spiralizer.SpiralizedArrayToNormalMartix(out w, out h, bytes_Spiralized_0003);

    Console.WriteLine($"\tTest #0006.Despiralized Matrix: ");

    for (int j = 0; j < h; j++)
    {
        for (int i = 0; i < w; i++)
        {
            Console.Write($"{despiralizedMatrix[i, j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();*/

    /******************************************************************************************************************/
    #endregion

    #region Test 0007
    /******************************************************************************************************************/
    /*
    Console.WriteLine("Test #0007:");

    Console.WriteLine($"\tTest #0007.Despiralized Array: ");

    var despiralizedArray1 = Spiralizer.Despiralize(out w, out h, bytes_Spiralized_0003);
    var despiralizedArray2 = Spiralizer.Despiralize(w, h, despiralizedMatrix);

    for (int i = 0; i < despiralizedArray1.Length; i++)
    {
        Console.Write($"{despiralizedArray1[i]}, ");
    }
    Console.WriteLine();
    for (int i = 0; i < despiralizedArray2.Length; i++)
    {
        Console.Write($"{despiralizedArray2[i]}, ");
    }
    Console.WriteLine();
    */
    /******************************************************************************************************************/
    #endregion

    #region Test 0008
    /******************************************************************************************************************/

    Console.WriteLine("Test #0008:");

    Console.WriteLine($"\tTest #0008.Full: Started!");

    byte[] buffer = new byte[] { 1, 2, 3, 4, 5, 6, 7/*, 8, 9*/ };
    //byte[,] bytesM_ = Spiralizer.ArrayToMartix(out w, out h, buffer);
    //byte[] bytes = Spiralizer.MartixToArray(w, h, bytesM);
    byte[] bytes_Spiralized = Spiralizer.Spiralize(buffer);

    //var _despiralizedMatrix = Spiralizer.SpiralizedArrayToNormalMartix(out w, out h, bytes_Spiralized);
    var _despiralizedArray = Spiralizer.Despiralize(bytes_Spiralized);
    for(int i = 0; i < buffer.Length; i++)
    {
        if (buffer[i] != _despiralizedArray[i])
            Console.WriteLine("Error!");
    }
    Console.WriteLine($"\tTest #0008.Full: Finished!");
    Console.WriteLine();
    /******************************************************************************************************************/
    #endregion
    
}

