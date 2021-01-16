using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace testCOOP
{
    class SV
    {
        protected string name;
        protected string age;
        protected string gender;
        protected string address;
        protected double s_math;
        protected double s_lit;
        protected double s_che;
        protected double s_phy;
        protected double s_eng;
        protected double s_avg;
        protected string MSSV;
        public double s_Avg
        {
            get { return s_avg; }
            set { s_avg = value; }
        }
        private void check(ref double Score)
            {
            while (Score > 10 || Score< 0)
            {
                Console.WriteLine("\nDiem nhap vao khong hop le.");
                Console.Write("Nhap Lai: ");
                Score = double.Parse(Console.ReadLine());
            }
            }
        public void InputInfo()
        {
            Console.Write("Nhap Ho Ten: ");
            name = Console.ReadLine();
            Console.Write("\rNhap Tuoi: ");
            age = Console.ReadLine();
            Console.Write("\rNhap Gioi Tinh: ");
            gender = Console.ReadLine();
            while (gender != "Nam" && gender != "Nu")
            {
                Console.WriteLine("\rGioi tinh nhap khong hop le.");
                Console.Write("Nhap lai : ");
                gender = Console.ReadLine();
            }
            Console.Write("\rNhap Dia Chi: ");
            address = Console.ReadLine();
            Console.Write("\rNhap MSSV: ");
            MSSV = Console.ReadLine();
        }
        public void InputScore()
        {
            Console.Write("\rNhap Diem Toan : ");
            s_math = double.Parse(Console.ReadLine());
            check(ref s_math);
            Console.Write("\rNhap Diem Van : ");
            s_lit = double.Parse(Console.ReadLine());
            check(ref s_lit);
            Console.Write("\rNhap Diem Anh : ");
            s_eng = double.Parse(Console.ReadLine());
            check(ref s_eng);
            Console.Write("\rNhap Diem Ly: ");
            s_phy = double.Parse(Console.ReadLine());
            check(ref s_phy);
            Console.Write("\rNhap Diem Hoa: ");
            s_che = double.Parse(Console.ReadLine());
            check(ref s_che);
        }
        public void OutputInfo()
        {
            s_avg = (s_math + s_lit + s_phy + s_eng + s_che) / 5;
            Console.WriteLine("{0}\t||{1}\t\t||{2}\t||{3}\t||{4}\t||{5}\t||{6}\t||{7}\t||{8}\t||{9}\t||{10}\t",MSSV, name, age, gender, address, s_math, s_lit, s_eng, s_phy, s_che,s_avg);
        }

    }
    public class SortAvg : IComparer
    {
        public int Compare(object x, object y)
        {
            SV a = x as SV;
            SV b = y as SV;
            if (a == null || b == null)
            {
                throw new InvalidOperationException();
            }
            if (a.s_Avg > b.s_Avg)
                return 1;
            else if (a.s_Avg < b.s_Avg)
                return -1;
            else return 0;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien cua lop : ");
            int n = int.Parse(Console.ReadLine());
            ArrayList ArrSV = new ArrayList(n);
            for (int i = 0; i < n; i++)
                ArrSV.Add(new SV());
            int j = 1;
            foreach (SV items in ArrSV)
            {
                Console.WriteLine("Sinh vien thu {0}", j);
                items.InputInfo();
                items.InputScore();
                j++;
            }
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("MSSV\t||Name\t\t||Age\t||Gender||Address\t||Math_S||Lit_S\t||Eng_S\t||Phy_S\t||Che_S\t||Avg_S\t");
            foreach (SV items in ArrSV)
            {
                items.OutputInfo();
            }
            ArrSV.Sort(new SortAvg());
            Console.WriteLine("After Sort :");
            foreach (SV items in ArrSV)
            {
                items.OutputInfo();
            }
            Console.ReadKey(true);
        }
    }
}
