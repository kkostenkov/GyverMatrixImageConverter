using System;
using System.Drawing;

public class ColorCutter
{

    public static int[][] EncodeImage(string imagePath, int width, int height, out string error)
    {
        error = "Unhandled Error";
        if (string.IsNullOrEmpty(imagePath))
        {
            error = "File not selected";
            return null;
        }
        Bitmap bitmap = new Bitmap(imagePath);
        if (bitmap == null)
        {
            error = "File could not be read";
            return null;
        }

        var fileWidth = bitmap.Width;
        var fileHeight = bitmap.Height;

        if (fileWidth < width || fileHeight < height)
        {
            error = "Image is too small";
            return null;
        }

        int[][] result = new int[height][];
        
        for (int y = 0; y < height; y++)
        {
            result[y] = new int[width];
            for (int x = 0; x < width; x++)
            {
                Color pixelColor = bitmap.GetPixel(x, y);
                result[y][x] = ShrinkColor(pixelColor.ToArgb());
            }
        }
        error = string.Empty;
        return result;
    }

    // преобразовать цвет из 16 битного в 24 битный
    public static int ExpandColor(int color)
    {
        //return (gamma5[color >> 11] << 16) |
        //       (gamma6[(color >> 5) & 0x3F] << 8) |
        //       gamma5[color & 0x1F];
        var colorB = Convert.ToString(color, 2);
        var rOffset = color >> 11; // ignore G & B digits
        var rOffsetB = Convert.ToString(rOffset, 2);
        var fullR = gamma5[rOffset];
        var fullRB = Convert.ToString(fullR, 2);
        var r =  fullR << 16;
        var rb = Convert.ToString(r, 2);

        var gOffset = color >> 5; // ignore B digits
        var gOffsetB = Convert.ToString(gOffset, 2);
        var gMaskB = Convert.ToString(0x3F, 2); 
        var g2Offset = gOffset & 0x3F;// take 6 digits
        var g2OffsetB = Convert.ToString(g2Offset, 2);
        var gGamma = gamma6[g2Offset];
        var gGammaB = Convert.ToString(gGamma, 2);
        var g = gGamma << 8;
        var gb = Convert.ToString(g, 2);

        var rg = r | g;
        var rgB = Convert.ToString(rg, 2);

        var bMaskB = Convert.ToString(0x1F, 2); // take 5 digits
        var bOffset = color & 0x1F;
        var bOffsetB = Convert.ToString(bOffset, 2);
        var b = gamma5[bOffset];
        var bB = Convert.ToString(b, 2);        

        return r |
               g |
               b;

    }

    // преобразовать цвет из 24 битного в 16 битный
    public static int ShrinkColor(int color)
    {
        var c = Color.FromArgb(color);
        var rIndex = GetShrinkedColorIndex(c.R, gamma5);
        var gIndex = GetShrinkedColorIndex(c.G, gamma6);
        var bIndex = GetShrinkedColorIndex(c.B, gamma5);
        var ffBin = Convert.ToString(0xff, 2);
        var r = rIndex << 11;
        var g = gIndex << 5;
        var b = bIndex;
        var result = r | g | b;
        return result;
    }

    private static int GetShrinkedColorIndex(int valToShrink, int[] shrinkArray)
    {
        int result = 0;
        foreach (int val in shrinkArray)
        {
            if (val < valToShrink)
                result++;
            else
                break;
        }
        return result;
    }

    // gamma correction для expandColor shrinkClolor
    private static readonly int[] gamma5 = new int[]
    {
        0x00, 0x01, 0x02, 0x03, 0x05, 0x07, 0x09, 0x0b,
        0x0e, 0x11, 0x14, 0x18, 0x1d, 0x22, 0x28, 0x2e,
        0x36, 0x3d, 0x46, 0x4f, 0x59, 0x64, 0x6f, 0x7c,
        0x89, 0x97, 0xa6, 0xb6, 0xc7, 0xd9, 0xeb, 0xff
    };

    private static readonly int[] gamma6 = new int[]
    {
        0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x08,
        0x09, 0x0a, 0x0b, 0x0d, 0x0e, 0x10, 0x12, 0x13,
        0x15, 0x17, 0x19, 0x1b, 0x1d, 0x20, 0x22, 0x25,
        0x27, 0x2a, 0x2d, 0x30, 0x33, 0x37, 0x3a, 0x3e,
        0x41, 0x45, 0x49, 0x4d, 0x52, 0x56, 0x5b, 0x5f,
        0x64, 0x69, 0x6e, 0x74, 0x79, 0x7f, 0x85, 0x8b,
        0x91, 0x97, 0x9d, 0xa4, 0xab, 0xb2, 0xb9, 0xc0,
        0xc7, 0xcf, 0xd6, 0xde, 0xe6, 0xee, 0xf7, 0xff
    };
    
}
