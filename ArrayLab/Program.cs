using System;

namespace ArrayMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, max = 0, sum = 0;
            int[] arr = null;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. Nhap thong tin ve mang");
                    Console.WriteLine("2. Hien thi du lieu trong mang");
                    Console.WriteLine("3. Tinh gia tri trung binh");
                    Console.WriteLine("4. Gia tri lon nhat trong mang");
                    Console.WriteLine("5. Dem so luong cac phan tu co gia tri la 5");
                    Console.WriteLine("0. Ket thuc");
                    Console.Write("Nhap vao lua chon cua ban: ");

                    choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("=== Nhap thong tin ve mang ===");
                            bool isInputValid = true;
                            do
                            {
                                Console.Write("So phan tu: ");
                                try
                                {
                                    int arrLength = Convert.ToInt16(Console.ReadLine());
                                    arr = new int[arrLength];

                                    for (int i = 0; i < arr.Length; i++)
                                    {
                                        bool isInputValid1 = true;
                                        Console.Write($"Nhap so thu {i + 1}: ");
                                        do
                                        {
                                            try
                                            {
                                                arr[i] = Convert.ToInt16(Console.ReadLine());
                                                if (i == 0)
                                                {
                                                    max = arr[i];
                                                }
                                                else
                                                {
                                                    max = arr[i] > max ? arr[i] : max;
                                                }

                                                sum += arr[i];

                                            }
                                            catch (Exception)
                                            {
                                                isInputValid1 = false;
                                            }
                                        } while (!isInputValid1);
                                    }
                                }
                                catch (Exception)
                                {
                                    isInputValid = false;
                                }

                            } while (!isInputValid);

                            break;

                        case 2:
                            if (arr == null)
                            {
                                choice = -1;
                                break;
                            }

                            Console.Clear();
                            Console.WriteLine("=== Hien thi du lieu trong mang ===");
                            Console.Write("Mang: ");
                            foreach (var item in arr)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            Console.Write("An bat ky phim nao de thoat:...");
                            Console.ReadLine();
                            break;
                        case 3:
                            if (arr == null)
                            {
                                choice = -1;
                                break;
                            }

                            Console.Clear();
                            Console.WriteLine("=== Gia tri trung binh ===");
                            Console.WriteLine("Gia tri trung binh: " + sum / arr.Length);
                            Console.WriteLine();
                            Console.Write("An bat ky phim nao de thoat:...");
                            Console.ReadLine();
                            break;
                        case 4:
                            if (arr == null)
                            {
                                choice = -1;
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("=== Gia tri lon nhat ===");
                            Console.WriteLine("Max: " + max);
                            Console.Write("An bat ky phim nao de thoat:...");
                            Console.ReadLine();
                            break;
                        case 5:
                            if (arr == null)
                            {
                                choice = -1;
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("=== In ra so luong cua cac phan tu trong mang co gia tri bang 5 ===");

                            int count5 = 0;

                            foreach (var item in arr)
                            {
                                if (item == 5)
                                {
                                    count5++;
                                }
                            }

                            Console.WriteLine("So luong: " + count5);
                            Console.Write("An bat ky phim nao de thoat:...");
                            Console.ReadLine();
                            break;
                        default:
                            break;
                    }


                }
                catch (Exception)
                {
                    choice = -1;
                }
            } while (choice != 0);
        }

        static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
