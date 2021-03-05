using System;
using System.Collections;

namespace HashtableCz
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;

            var products = new Hashtable(3);

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. Nhap vao 10 san pham");
                    Console.WriteLine("2. Hien thi du lieu trong mang");
                    Console.WriteLine("3. Kiem tra gio hang co ton tai san pham ten 'Demo' hay ma la '1'");
                    Console.WriteLine("4. Xoa san pham co ma 2");
                    Console.WriteLine("5. In ra hash table");
                    Console.WriteLine("0. Ket thuc");
                    Console.Write("Nhap vao lua chon cua ban: ");

                    choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("=== Nhap thong tin san pham ===");
                            for (int i = 0; i < 10; i++)
                            {
                                bool isInputValid = true;
                                int id = 0;
                                do
                                {
                                    Console.Write("ID: ");
                                    try
                                    {
                                        id = Convert.ToInt16(Console.ReadLine());

                                    }
                                    catch (Exception)
                                    {
                                        isInputValid = false;
                                    }

                                } while (!isInputValid);

                                Console.Write("Ten: ");
                                string name = Console.ReadLine();

                                products.Add(id, name);
                            }

                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("=== Ten san pham co ID = 1 ===");
                            if (products.ContainsKey(1))
                            {
                                Console.WriteLine("Ten san pham: " + products[1]);
                            }
                            
                            Console.Write("An bat ky phim nao de thoat:... ");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("=== Ten san pham co ID = 1 ===");
                            if (products.ContainsKey(1))
                            {
                                Console.WriteLine("Ten san pham: " + products[1]);
                            }

                            Console.Write("An bat ky phim nao de thoat:... ");
                            Console.ReadLine();
                            break;
                        case 4:

                            break;
                        case 5:

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
    }
}
