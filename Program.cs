using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Chọn chương trình để chạy:");
        Console.WriteLine("1. Tính tổng bình phương từ 1 đến n.");
        Console.WriteLine("2. Nhập số nguyên không dấu từ 2 đến 10.");
        Console.WriteLine("3. Nhập một giá trị số thực.");
        Console.WriteLine("4. Nhập giá trị và hiển thị mảng hai chiều.");
        Console.WriteLine("5. Đếm số từ trong xâu ký tự.");
        Console.WriteLine("6. Tính căn bậc hai của một số thực 8 byte.");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                RunSumSquares();
                break;
            case "2":
                RunByteInput();
                break;
            case "3":
                RunFloatInput();
                break;
            case "4":
                RunMatrixOperations();
                break;
            case "5":
                RunWordCount();
                break;
            case "6":
                RunSquareRoot();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }

    static void RunSumSquares()
    {
        ushort n = ReadUnsignedShort();
        ulong sum = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sum += (ulong)i * i;
        }
        Console.WriteLine("Tổng bình phương từ 1 đến " + n + " là: " + sum);
    }

    static ushort ReadUnsignedShort()
    {
        ushort input;
        Console.WriteLine("Nhập một số nguyên không dấu (0-65535):");
        while (!ushort.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Vui lòng nhập lại số nguyên không dấu:");
        }
        return input;
    }

    static void RunByteInput()
    {
        byte n = ReadByteInRange(2, 10);
        Console.WriteLine("Giá trị nhập là: " + n);
    }

    static byte ReadByteInRange(byte min, byte max)
    {
        byte input;
        Console.WriteLine($"Nhập một số nguyên không dấu từ {min} đến {max}:");
        while (!byte.TryParse(Console.ReadLine(), out input) || input < min || input > max)
        {
            Console.WriteLine($"Dữ liệu nhập không hợp lệ, vui lòng nhập lại số nguyên không dấu từ {min} đến {max}:");
        }
        return input;
    }

    static void RunFloatInput()
    {
        float x = ReadFloat();
        Console.WriteLine("Giá trị nhập là: " + x);
    }

    static float ReadFloat()
    {
        float input;
        Console.WriteLine("Nhập một giá trị số thực:");
        while (!float.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Dữ liệu nhập không hợp lệ, vui lòng nhập lại giá trị số thực:");
        }
        return input;
    }

    static void RunMatrixOperations()
    {
        // Đây là phiên bản rút gọn của bài 16 để vừa với khung chữ. Bạn cần bổ sung các hàm còn lại.
        Console.WriteLine("Chưa được thực hiện hoàn chỉnh.");
    }

    static void RunWordCount()
    {
        Console.WriteLine("Nhập một xâu kí tự:");
        string st = Console.ReadLine();
        if (st == "#")
        {
            Console.Beep();
        }
        else
        {
            int wordCount = CountWords(st);
            Console.WriteLine("Số từ trong xâu là: " + wordCount);
        }
    }

    static int CountWords(string input)
    {
        int count = 0;
        int length = input.Length;
        if (!string.IsNullOrWhiteSpace(input))
        {
            count = 1;
            for (int i = 1; i < length; i++)
            {
                if (char.IsWhiteSpace(input[i - 1]) && char.IsLetterOrDigit(input[i]))
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void RunSquareRoot()
    {
        double x = ReadDouble();
        Console.WriteLine("Căn bậc 2 của {0} là {1}", x, Math.Sqrt(x));
    }

    static double ReadDouble()
    {
        double input;
        Console.WriteLine("Nhập vào số thực 8 byte:");
        while (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
        return input;
    }
}
