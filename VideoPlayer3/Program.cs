using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;


#nullable enable
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello World!");
Xabe.FFmpeg.FFmpeg.SetExecutablesPath("C:\\Users\\gummi\\Desktop\\ffmpeg\\bin");
string fileNameNo = "C:\\video\\Images\\image";
Func<string, string> func1 = (Func<string, string>)(number => fileNameNo + number + ".png");
List<Bitmap> bitmapList = new List<Bitmap>();
Directory.GetFiles("C:\\video\\Images", "*.png");
bitmapList.Add(new Bitmap(Image.FromFile("C:\\Users\\gummi\\Pictures\\Picture1.png")));
string grayRamp = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/|()1{}[]?-_+~<>i!lI;:,\"^`'. ";
double rampLength = (double)grayRamp.Length;
Func<int, char> func2 = (Func<int, char>)(grayScale => grayRamp[Convert.ToInt32(Math.Ceiling((rampLength - 1.0) * (double)grayScale / (double)byte.MaxValue))]);
List<int> intList1 = new List<int>();
string str = "";
List<int> intList2 = new List<int>();
int num1 = 1;
int num2 = 1;
int num3 = bitmapList[0].Width / num1;
int num4 = bitmapList[0].Height / num2;
for (int index1 = 0; index1 < num4; ++index1)
{
    for (int index2 = 0; index2 < num3; ++index2)
    {
        int[] numArray = new int[num1 * num2];
        for (int index3 = 0; index3 < num1; ++index3)
        {
            for (int index4 = 0; index4 < num2; ++index4)
            {
                Color pixel = bitmapList[0].GetPixel(num1 * index2 + index3, num2 * index1 + index4);
                byte r = pixel.R;
                pixel = bitmapList[0].GetPixel(num1 * index2 + index3, num2 * index1 + index4);
                byte g = pixel.G;
                pixel = bitmapList[0].GetPixel(num1 * index2 + index3, num2 * index1 + index4);
                byte b = pixel.B;
                int int32 = Convert.ToInt32(0.21 * (double)r + 0.72 * (double)g + 0.07 * (double)b);
                numArray[index3 * index4] = int32;
            }
        }
        int num5 = 0;
        for (int index5 = 0; index5 < numArray.Length; ++index5)
            num5 += numArray[index5];
        str += func2(num5 / numArray.Length).ToString();
    }
    str += "\n";
}
Console.WriteLine(str);
Console.WriteLine("DOne");
