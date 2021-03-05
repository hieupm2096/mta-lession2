using System;

namespace ArrayMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, max = 0, min = 0, evenSum = 0, evenCount = 0;
            int[] arr = null;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. Nhap thong tin ve mang");
                    Console.WriteLine("2. Sap xep mang (theo thu tu giam dan)");
                    Console.WriteLine("3. Hien thong tin ve mang ban dau");
                    Console.WriteLine("4. Phan tu lon nhat, nho nhat");
                    Console.WriteLine("5. Tinh tong va trung binh cong cua cac phan tu co chi so chan trong mang");
                    Console.WriteLine("6. In ra so luong cua cac phan tu trong mang co gia tri lon nhat");
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
                                                    min = arr[i];
                                                } else
                                                {
                                                    max = arr[i] > max ? arr[i] : max;
                                                    min = arr[i] < min ? arr[i] : min;
                                                }

                                                if (i % 2 == 0)
                                                {
                                                    evenCount++;
                                                    evenSum += arr[i];
                                                }
                                                
                                            } catch (Exception)
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
                            Console.WriteLine("=== Sap xep mang ===");
                            Console.Write("Mang da sap xep: ");
                            var sortedArr = BubbleSort( (int[]) arr.Clone() );
                            foreach (var item in sortedArr)
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
                            Console.WriteLine("=== Thong tin ve mang ban dau ===");
                            Console.Write("Mang ban dau: ");
                            foreach (var item in arr)
                            {
                                Console.Write(item + " ");
                            }
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
                            Console.WriteLine("=== Phan tu lon nhat, phan tu nho nhat ===");
                            Console.WriteLine("Lon nhat: " + max);
                            Console.WriteLine("Nho nhat: " + min);
                            Console.WriteLine();
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
                            Console.WriteLine("=== Tinh tong va trung binh cong cua cac phan tu co chi so chan trong mang ===");
                            Console.WriteLine("Tong: " + evenSum);
                            Console.WriteLine("Trung binh cong: " + Convert.ToDouble(evenSum) / Convert.ToDouble(evenCount));
                            Console.WriteLine();
                            Console.Write("An bat ky phim nao de thoat:...");
                            Console.ReadLine();
                            break;
                        case 6:
                            if (arr == null)
                            {
                                choice = -1;
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("=== In ra so luong cua cac phan tu trong mang co gia tri lon nhat ===");

                            int countMax = 0;

                            foreach (var item in arr)
                            {
                                if (item == max)
                                {
                                    countMax++;
                                }
                            }

                            Console.WriteLine("So luong: " + countMax);
                            Console.Write("An bat ky phim nao de thoat:...");
                            Console.ReadLine();
                            break;
                        default:
                            break;
                    }


                } catch (Exception)
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
