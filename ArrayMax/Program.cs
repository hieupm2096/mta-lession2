using System;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("So nhan vien: ");
            int numberOfEmployees = Convert.ToInt16(Console.ReadLine());
            var employees = new NhanVien[numberOfEmployees];

            NhanVien maxSalaryEmployee = null;
            var count = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                var temp = new NhanVien();
                temp.Input();
                employees[i] = temp;

                if (employees[i].Salary > 2000)
                {
                    count++;
                }

                if (maxSalaryEmployee == null)
                {
                    maxSalaryEmployee = employees[i];
                } else
                {
                    maxSalaryEmployee = maxSalaryEmployee.Salary < employees[i].Salary ? employees[i] : maxSalaryEmployee;
                }
            }

            Console.WriteLine("=============================");
            foreach (var item in employees)
            {
                item.OutputDoanhSo();
            }

            Console.WriteLine("=============================");
            maxSalaryEmployee.OutputThongTin();

            Console.WriteLine("=============================");
            Console.WriteLine("Tong so nhan vien co muc luong > 2000: " + count);
        }
    }

    class NhanVien
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Sales { get; set; }
        public double Salary {
            get
            {
                return Sales * 1000 + (Bonus != null ? (double) Bonus * Sales * 1000 : 0);
            }
        }
        public double? Bonus
        {
            get
            {
                if (Sales > 0 && Sales < 4)
                {
                    return -0.01;
                }
                else if (Sales == 4)
                {
                    return -0.005;

                }
                else if (Sales == 5)
                {
                    return 0.005;
                }
                else if (Sales == 6)
                {
                    return 0.02;
                }
                else if (Sales == 7)
                {
                    return 0.035;
                }
                else if (Sales <= 10)
                {
                    return 0.05;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Input()
        {
            Console.Write("Nhap ten nhan vien: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi nhan vien: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap doanh so cua nhan vien: ");
            Sales = Convert.ToDouble(Console.ReadLine());
        }

        public void OutputThongTin()
        {
            Console.WriteLine("Ten: " + Name);
            Console.WriteLine("Tuoi: " + Age);
            Console.WriteLine("Doanh so: " + Sales);
            Console.WriteLine("Muc luong: " + Salary);
        }

        public void OutputDoanhSo()
        {
            if (Sales > 0 && Sales < 4)
            {
                Console.WriteLine("Rat kem (-1%)");
            }
            else if (Sales == 4)
            {
                Console.WriteLine("Kem (-0.5%)");
                
            }
            else if (Sales == 5)
            {
                Console.WriteLine("Co co gang (0.5%)");
            }
            else if (Sales == 6)
            {
                Console.WriteLine("Tot (2%)");
            }
            else if (Sales == 7)
            {
                Console.WriteLine("Rat tot (3.5%)");
            }
            else if (Sales <= 10)
            {
                Console.WriteLine("Tuyet voi (5%)");
            }
            else
            {
                Console.WriteLine("Nhap sai");
            }
        }
    }
}
