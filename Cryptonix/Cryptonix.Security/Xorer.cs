﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptonix.Security
{
    public static class Xorer
    {

        public static byte[] Xor(byte[] byteArray, byte[] key)
        {
            byte[] result = new byte[byteArray.Length];

            for (long currentByte = 0, currentKeyIndex = 0; currentByte < byteArray.Length; currentByte++)
            {
                result[currentByte] = (byte)(byteArray[currentByte] ^ key[currentKeyIndex++]);
                if (currentKeyIndex >= key.Length)
                    currentKeyIndex = 0;
            }

            return result;
        }

        public static byte[] xor1Matrix = new byte[]
        {
            234, 3, 5, 202, 54, 2, 144, 55, 12, 7, 14, 212, 151, 22, 9, 17,
            22, 249, 55, 14, 65, 58, 185, 72, 142, 79, 138, 47, 142, 54, 85,
            32, 119, 156, 75, 124, 176, 110, 94, 181, 153, 235, 132, 124, 179, 92,
            89, 134, 65, 161, 74, 126, 108, 29, 25, 241, 123, 175, 33, 112, 93,
            201, 132, 226, 96, 135, 214, 252, 213, 112, 31, 41, 107, 122, 87, 185,
            73, 99, 159, 248, 87, 194, 3, 185, 35, 61, 21, 116, 100, 228, 208,
            247, 225, 2, 21, 61, 241, 173, 88, 58, 153, 185, 144, 217, 50, 97,
            195, 223, 150, 40, 103, 169, 24, 98, 147, 203, 21, 147, 61, 190, 27,
            251, 176, 241, 184, 68, 245, 238, 128, 31, 19, 176, 145, 178, 246, 232,
            86, 120, 90, 56, 121, 229, 249, 136, 62, 45, 133, 206, 186, 84, 145,
            157, 10, 182, 21, 143, 248, 246, 94, 58, 217, 221, 44, 197, 226, 27,
            28, 118, 179, 63, 194, 94, 74, 156, 35, 25, 205, 252, 237, 54, 139,
            237, 87, 65, 189, 58, 235, 193, 84, 41, 110, 90, 35, 189, 123, 93,
            136, 161, 179, 82, 237, 30, 86, 145, 58, 145, 53, 103, 142, 155, 217,
            192, 50, 165, 126, 203, 77, 73, 127, 227, 132, 221, 100, 199, 7, 69,
            98, 189, 144, 159, 65, 20, 13, 77, 82, 170, 82, 143, 69, 70, 3,
            5, 171, 22, 51, 235, 252, 252, 235, 209, 55, 253, 95, 131, 49, 230,
            25, 62, 97, 217, 70, 44, 145, 67, 131, 54, 125, 81, 136, 190, 46,
            13, 63, 146, 102, 43, 113, 238, 156, 19, 118, 64, 212, 103, 58, 126,
            62, 139, 14, 141, 139, 244, 65, 170, 176, 127, 60, 159, 230, 154, 93,
            129, 42, 181, 134, 225, 63, 240, 78, 101, 220, 109, 59, 25, 38, 140,
            197, 242, 165, 62, 22, 17, 175, 153, 49, 9, 165, 190, 121, 68, 127,
            84, 31, 174, 43, 58, 150, 163, 136, 30, 28, 208, 49, 56, 69, 77,
            91, 139, 43, 104, 252, 155, 130, 208, 178, 33, 121, 37, 193, 201, 99,
            105, 20, 113, 107, 171, 155, 7, 83, 156, 117, 217, 216, 191, 188, 157,
            112, 118, 62, 206, 200, 231, 121, 159, 193, 213, 42, 38, 229, 125, 2,
            125, 52, 0, 230, 122, 137, 182, 75, 53, 69, 134, 69, 91, 162, 73,
            21, 83, 244, 124, 27, 88, 206, 202, 22, 94, 94, 179, 145, 85, 230,
            129, 101, 16, 16, 16, 3, 32, 49, 94, 28, 41, 172, 3, 160, 189,
            245, 132, 65, 200, 222, 90, 86, 138, 7, 53, 51, 229, 237, 131, 218,
            224, 3, 247, 196, 252, 120, 16, 51, 90, 12, 84, 99, 99, 69, 175,
            217, 128, 103, 247, 167, 212, 63, 195, 10, 29, 33, 98, 71, 11, 88,
            182, 236, 5, 118, 237, 136, 246, 111, 214, 63, 134, 234, 7, 127, 1,
            49, 77, 217, 49, 66, 175, 4, 240, 38, 248, 250, 89, 144, 127, 34,
            191, 5, 97, 40, 68, 153, 148, 97, 84, 112, 237, 147, 250, 181, 164,
            23, 29, 225, 46, 59, 77, 237, 34, 23, 140, 218, 124, 177, 239, 0,
            237, 54, 43, 22, 35, 254, 197, 27, 170, 6, 160, 34, 36, 72, 87,
            112, 83, 226, 123, 149, 112, 53, 135, 75, 198, 217, 247, 104, 124, 248,
            67, 174, 139, 52, 188, 214, 55, 66, 235, 242, 4, 219, 171, 151, 67,
            68, 152, 171, 50, 59, 169, 87, 176, 143, 222, 228, 172, 198, 123, 228,
            24, 149, 95, 93, 197, 36, 79, 116, 122, 179, 31, 136, 240, 247, 169,
            85, 86, 85, 154, 191, 134, 159, 134, 181, 85, 29, 168, 146, 165, 85,
            178, 134, 6, 149, 3, 167, 4, 239, 33, 98, 98, 67, 105, 34, 45,
            40, 25, 154, 230, 15, 119, 165, 40, 38, 96, 96, 27, 101, 161, 159,
            158, 214, 31, 6, 25, 248, 177, 250, 63, 50, 197, 220, 176, 110, 29,
            210, 247, 195, 155, 167, 55, 213, 74, 51, 30, 126, 22, 32, 167, 85,
            86, 31, 189, 200, 161, 112, 185, 221, 74, 96, 113, 119, 176, 194, 153,
            46, 30, 202, 222, 210, 189, 200, 37, 188, 82, 123, 2, 93, 142, 90,
            254, 219, 161, 222, 121, 42, 222, 9, 103, 84, 110, 142, 194, 247, 92,
            150, 210, 53, 41, 72, 35, 71, 190, 93, 8, 253, 86, 248, 49, 203,
            61, 218, 248, 25, 139, 88, 214, 167, 0, 85, 100, 203, 178, 247, 188,
            144, 35, 6, 240, 229, 3, 162, 59, 0, 14, 209, 84, 161, 22, 206,
            213, 59, 106, 60, 204, 237, 135, 82, 59, 135, 188, 114, 130, 97, 19,
            104, 230, 136, 221, 84, 215, 157, 214, 185, 207, 156, 27, 108, 234, 159,
            56, 71, 4, 68, 84, 196, 104, 98, 69, 122, 51, 63, 110, 228, 6,
            70, 6, 78, 159, 250, 56, 122, 47, 85, 0, 249, 102, 57, 152, 64,
            236, 95, 70, 162, 143, 89, 154, 77, 93, 10, 225, 162, 113, 232, 82,
            22, 204, 136, 102, 33, 158, 73, 79, 114, 246, 175, 31, 240, 97, 200,
            252, 18, 149, 155, 147, 89, 160, 201, 209, 240, 30, 100, 237, 9, 53,
            227, 247, 126, 75, 195, 110, 0, 176, 3, 0, 218, 139, 209, 244, 77,
            189, 143, 37, 18, 150, 243, 124, 9, 162, 42, 153, 181, 233, 122, 126,
            101, 141, 162, 113, 209, 83, 1, 118, 176, 81, 137, 190, 95, 51, 195,
            160, 65, 94, 131, 35, 238, 183, 148, 248, 180, 127, 229, 98, 21, 46,
            178, 235, 128, 233, 161, 186, 137, 91, 45, 54, 139, 51, 180, 207, 201,
            117, 3, 60, 70, 247, 168, 205, 113, 176, 149, 56, 144, 128, 1, 222,
            118, 114, 70, 109, 128, 193, 117, 47, 26, 245, 128, 182, 224, 41, 84,
            85, 238, 153, 177, 252, 250, 133, 209, 4, 17, 225, 20, 0, 56, 194,
            119, 48, 98, 197, 193, 110, 96, 89, 29, 74, 229, 110, 112, 188, 176,
            79, 1, 233, 143, 54, 150, 225, 38, 70, 51, 22, 150, 230, 188, 171,
            13, 50, 66, 250, 226, 61, 22, 209, 29, 38, 214, 54, 197, 108, 152,
            27, 95, 176, 43, 239, 213, 41, 247, 124, 118, 87, 134, 147, 240, 220,
            48, 6, 74, 116, 67, 243, 130, 153, 102, 1, 225, 115, 101, 74, 83,
            158, 91, 167, 89, 18, 236, 205, 9, 94, 59, 180, 66, 196, 112, 204,
            181, 216, 106, 131, 170, 138, 42, 177, 226, 149, 171, 14, 152, 204, 146,
            112, 201, 41, 58, 204, 232, 34, 177, 73, 67, 157, 144, 203, 145, 113,
            89, 105, 111, 169, 187, 77, 231, 42, 68, 170, 200, 185, 128, 232, 107,
            149, 209, 101, 182, 121, 163, 231, 142, 200, 49, 175, 147, 149, 34, 214,
            33, 51, 232, 188, 188, 86, 245, 180, 36, 234, 253, 143, 83, 93, 34,
            249, 52, 8, 4, 242, 133, 207, 152, 54, 222, 239, 91, 249, 156, 153,
            34, 20, 28, 174, 106, 224, 153, 230, 124, 62, 118, 154, 21, 28, 92,
            230, 230, 67, 79, 210, 79, 85, 230, 212, 27, 31, 244, 154, 116, 92,
            30, 155, 79, 172, 122, 90, 82, 73, 41, 26, 191, 103, 85, 181, 67,
            40, 86, 182, 49, 210, 200, 56, 158, 68, 244, 169, 246, 62, 252, 31,
            178, 127, 139, 122, 19, 120, 181, 89, 109, 131, 250, 60, 246, 32, 222,
            172, 26, 238, 247, 194, 42, 100, 67, 229, 94, 213, 213, 94, 131, 230,
            18, 190, 141, 172, 99, 20, 200, 130, 210, 15, 124, 155, 67, 226, 118,
        };

        public static byte[] Xor1Encrypt(byte[] byteArray, byte[] key)
        {
            return Xor(Xor(byteArray, xor1Matrix), key);
        }

        public static byte[] Xor1Dencrypt(byte[] byteArray, byte[] key)
        {
            return Xor(Xor(byteArray, key), xor1Matrix);
        }

        public static byte[] xor2Matrix = new byte[]
        {
            2, 38, 134, 84, 72, 179, 118, 46, 117, 16, 246, 80, 106, 114, 87, 71, 5,
            225, 180, 57, 206, 228, 205, 187, 27, 39, 27, 247, 85, 128, 47, 34, 247, 1,
            182, 16, 59, 181, 31, 46, 103, 222, 121, 89, 9, 203, 225, 42, 143, 132, 74,
            171, 95, 169, 81, 50, 247, 170, 189, 125, 234, 180, 127, 17, 231, 87, 12, 60,
            218, 4, 191, 40, 209, 184, 180, 178, 196, 189, 62, 227, 31, 77, 155, 218, 27,
            21, 83, 193, 174, 191, 187, 29, 4, 111, 87, 14, 51, 253, 86, 196, 104, 248,
            117, 199, 199, 35, 166, 107, 37, 244, 228, 23, 92, 83, 59, 102, 83, 243, 95,
            111, 28, 234, 114, 76, 136, 76, 251, 67, 222, 114, 123, 179, 92, 27, 254, 183,
            199, 179, 6, 37, 181, 163, 88, 107, 233, 192, 48, 170, 64, 68, 8, 246, 240,
            94, 59, 109, 1, 17, 145, 206, 124, 10, 169, 83, 13, 153, 7, 108, 2, 15,
            49, 166, 142, 74, 137, 94, 102, 206, 252, 119, 167, 54, 130, 52, 162, 136, 82,
            169, 104, 134, 57, 111, 130, 190, 146, 6, 218, 160, 235, 131, 83, 94, 11, 133,
            65, 180, 64, 224, 36, 219, 76, 148, 218, 9, 120, 67, 135, 246, 121, 132, 130,
            190, 5, 133, 171, 164, 112, 22, 213, 31, 105, 71, 112, 73, 237, 163, 64, 99,
            242, 224, 128, 76, 40, 8, 111, 171, 130, 217, 217, 247, 247, 201, 88, 94, 101,
            151, 247, 94, 171, 5, 69, 161, 176, 46, 218, 152, 193, 2, 74, 181, 131, 30,
            18, 59, 69, 71, 8, 71, 251, 110, 188, 157, 119, 164, 48, 240, 27, 76, 48,
        };

        public static byte[] Xor2Encrypt(byte[] byteArray, byte[] key)
        {
            byte[] result = new byte[byteArray.LongLength];

            for (long currentByte = 0, currentKeyIndex = 0; currentByte < byteArray.LongLength; currentByte++)
            {
                result[currentByte] = (byte)(byteArray[currentByte] ^ xor2Matrix[key[currentKeyIndex]] ^ key[currentKeyIndex]);
                if (++currentKeyIndex >= key.Length)
                    currentKeyIndex = 0;
            }

            return Xor1Encrypt(Xor(Xor1Encrypt(byteArray, xor1Matrix), xor1Matrix), key);
        }

        public static byte[] Xor2Dencrypt(byte[] byteArray, byte[] key)
        {
            byte[] result = new byte[byteArray.LongLength];

            for (long currentByte = 0, currentKeyIndex = 0; currentByte < byteArray.LongLength; currentByte++)
            {
                result[currentByte] = (byte)(byteArray[currentByte] ^ xor2Matrix[key[currentKeyIndex]] ^ key[currentKeyIndex]);
                if (++currentKeyIndex >= key.Length)
                    currentKeyIndex = 0;
            }

            result = Xor1Dencrypt(Xor(Xor1Dencrypt(byteArray, key), xor1Matrix), xor1Matrix);

            return result;
        }

        public static byte[] Xor3Encrypt(byte[] byteArray, byte[] key)
        {
            byte[] result = new byte[byteArray.LongLength];

            for (long currentByte = 0, currentKeyIndex = 0; currentByte < byteArray.LongLength; currentByte++)
            {
                result[currentByte] = (byte)(byteArray[currentByte] ^ (key[currentKeyIndex] << 4) ^ (key[currentKeyIndex] >> 4));

                if (++currentKeyIndex >= key.Length)
                    currentKeyIndex = 0;
            }

            return Xor(result, key);
        }

        public static byte[] Xor3Dencrypt(byte[] byteArray, byte[] key)
        {
            byte[] result = Xor(byteArray, key);

            for (long currentByte = 0, currentKeyIndex = 0; currentByte < byteArray.LongLength; currentByte++)
            {
                result[currentByte] = (byte)(result[currentByte] ^ (key[currentKeyIndex] << 4) ^ (key[currentKeyIndex] >> 4));

                if (++currentKeyIndex >= key.Length)
                    currentKeyIndex = 0;
            }

            return result;
        }

        public static byte[] Xor4Encrypt(byte[] byteArray, byte[] key)
        {
            byte[] invertedKey = InvertKey(key);

            return
                Xor3Encrypt(
                    Xor(
                        Xor2Encrypt(
                            Xor1Encrypt(byteArray, key),
                            invertedKey),
                        invertedKey),
                    key
                    );
        }

        private static byte[] InvertKey(byte[] key)
        {
            byte[] invertedKey = new byte[key.Length];
            long currentKeyByte = 0;
            foreach (byte b in key)
            {
                invertedKey[currentKeyByte] = key[currentKeyByte];
                currentKeyByte++;
            }

            return invertedKey;
        }

        public static byte[] Xor4Dencrypt(byte[] byteArray, byte[] key)
        {
            byte[] invertedKey = InvertKey(key);
            return Xor1Encrypt(Xor2Encrypt(Xor(Xor3Encrypt(byteArray, key), invertedKey), invertedKey), key);
        }


        public static byte[] XorMixerEncrypt(byte[] byteArray, byte[] key)
        {
            byte[] result = (byte[])byteArray.Clone();

            foreach (byte b in key)
            {
                byte f1 = (byte)(b >> 4);
                byte f2 = (byte)(b & 0b00001111);

                switch (f1)
                {
                    case 0:
                        {
                            result = Xor1Encrypt(result, key);
                        }
                        break;
                    case 1:
                        {
                            result = Xor2Encrypt(result, key);
                        }
                        break;
                    case 2:
                        {
                            result = Xor3Encrypt(result, key);
                        }
                        break;
                    case 3:
                        {
                            result = Xor4Encrypt(result, key);
                        }
                        break;
                }
                switch (f2)
                {
                    case 0:
                        {
                            result = Xor1Encrypt(result, key);
                        }
                        break;
                    case 1:
                        {
                            result = Xor2Encrypt(result, key);
                        }
                        break;
                    case 2:
                        {
                            result = Xor3Encrypt(result, key);
                        }
                        break;
                    case 3:
                        {
                            result = Xor4Encrypt(result, key);
                        }
                        break;
                }
            }

            return result;
        }

        public static byte[] XorMixerDencrypt(byte[] byteArray, byte[] key)
        {
            return new byte[] { };
        }
    }
}
