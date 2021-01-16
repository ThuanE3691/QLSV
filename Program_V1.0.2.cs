using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace QLSV
{
    class SV
    {
        private string name;
        private string age;
        private string gender;
        private string address;
        private double s_math;
        private double s_lit;
        private double s_che;
        private double s_phy;
        private double s_eng;
        private double s_avg;
        private double MSSV;
        private string Choice;
        private string[] nameR = new string[11] { "Thuan", "Luc", "Quan", "Lan", "Linh", "Vang", "Lao", "Truc", "Vang", "Lon", "HALO" };
        private double[] numR = new double[11];
        private void NumR()
        {
            Random score = new Random();
            for (int i = 0; i < 11; i++)
                numR[i] = Math.Round(score.NextDouble() * (10 - 1) * 1, 2);
        }
        public static int items = 0;
        public double getMSSV
        { get { return MSSV; } set { MSSV = value; } }
        public string getChoice
        { get { return Choice; } set { Choice = value; } }
        public double getScore
        {
            get
            {
                if (Choice == "Math") return s_math;
                else if (Choice == "Lit") return s_lit;
                else if (Choice == "Che") return s_che;
                else if (Choice == "Phy") return s_phy;
                else if (Choice == "Eng") return s_eng;
                else if (Choice == "Avg") return s_avg;
                else if (Choice == "MSSV") return MSSV;
                else return 0;
            }
            set
            {
                if (Choice == "Math") s_math = value;
                else if (Choice == "Lit") s_lit = value;
                else if (Choice == "Che") s_che = value;
                else if (Choice == "Phy") s_phy = value;
                else if (Choice == "Eng") s_eng = value;
                else if (Choice == "Avg") s_avg = value;
                else if (Choice == "MSSV") MSSV = value;
                else Console.WriteLine("Lua chon sap xep khong hop le");
            }
        }
        private void check(ref double Score)
        {
            while (Score > 10 || Score < 0)
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
            Console.WriteLine("{0}\t||{1}\t\t||{2}\t||{3}\t||{4}\t||{5}\t||{6}\t||{7}\t||{8}\t||{9}\t||{10}\t", MSSV, name, age, gender, address, s_math, s_lit, s_eng, s_phy, s_che, s_avg);
        }
        public void RandomSV()
        {
            name = nameR[items];
            items++;
            age = "18";
            gender = "Nam";
            address = "75 Ngo Gia Tu";
            NumR();
            Random n_R = new Random();
            double score = Math.Abs(Math.Round(n_R.NextDouble() * (10 - 1) * 1 + numR[items] - 3, 2));
            s_math = score;
            score = Math.Abs(Math.Round(n_R.NextDouble() * (10 - 1) * 1 + numR[items] - 3, 2));
            s_che = score;
            score = Math.Abs(Math.Round(n_R.NextDouble() * (10 - 1) * 1 + numR[items] - 3, 2));
            s_phy = score;
            score = Math.Abs(Math.Round(n_R.NextDouble() * (10 - 1) * 1 + numR[items] - 3, 2));
            s_eng = score;
            score = Math.Abs(Math.Round(n_R.NextDouble() * (10 - 1) * 1 + numR[items] - 3, 2));
            s_lit = score;
        }

    }
    public class Sort_Score : IComparer
    {
        private string choiceSort;
        public void inputChoice(string choice)
        {
            choiceSort = choice;
        }

        public int Compare(object x, object y)
        {
            SV a = x as SV;
            SV b = y as SV;
            a.getChoice = choiceSort;
            b.getChoice = choiceSort;
            if (a == null || b == null)
            {
                throw new InvalidOperationException();
            }
            if (a.getScore > b.getScore)
                return 1;
            else if (a.getScore < b.getScore)
                return -1;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double j = 1;
            Console.WriteLine("--------------------------------------Chuong Trinh Quan Li Sinh Vien--------------------------------------------");
            bool choice = true;
            Console.Write("Nhap so sinh vien cua lop : ");
            int n = int.Parse(Console.ReadLine());
            while (n > 10 || n < 0)
            {
                Console.WriteLine("So sinh vien toi da random hoac tu nhap la 10 hoac ban da nhap so sinh vien khong hop le.");
                Console.Write("Nhap Lai : ");
                n = int.Parse(Console.ReadLine());
            }
            ArrayList ArrSV = new ArrayList(n);
            Console.WriteLine("2 Che do : Random va tu nhap thong tin. ");
            Console.WriteLine("Ban muon random SV hay tu nhap . Neu chon random thi ghi Random neu tu nhap thi ghi gi cung duoc ");
            Console.Write("Lua chon cua ban : ");
            string c_random = Console.ReadLine();
            if (c_random != "Random")
            {
                for (int i = 0; i < n; i++)
                    ArrSV.Add(new SV());
                inputInfo(ArrSV, ref j);
            }
            else
            {
                for (int i = 0; i < n; i++)
                    ArrSV.Add(new SV());
                foreach (SV items in ArrSV)
                {
                    items.RandomSV();
                    items.getMSSV = j;
                    j++;
                }
            }
            do
            {
            Menu:
                StartProgam();
                printInfo(ArrSV);
                functionProgam();
                int rule = int.Parse(Console.ReadLine());
                switch (rule)
                {
                    case 1:
                        Console.Write("Ban muon sap xep mon nao ");
                        string subject = Console.ReadLine();
                        Sort_Score sub = new Sort_Score();
                        sub.inputChoice(subject);
                        ArrSV.Sort(sub);
                        Console.WriteLine("Sau khi sap xep theo Diem {0} :", subject);
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 2:
                        Sort_Score sub_2 = new Sort_Score();
                        sub_2.inputChoice("MSSV");
                        ArrSV.Sort(sub_2);
                        Console.WriteLine("Sau khi sap xep theo MSSV :");
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 3:
                        Console.Write("Nhap so Sinh vien muon them : ");
                        int addSV = int.Parse(Console.ReadLine());
                        ArrayList ArrAdd = new ArrayList(addSV);
                        for (int i = 0; i < addSV; i++)
                            ArrAdd.Add(new SV());
                        inputInfo(ArrSV, ref j);
                        ArrSV.AddRange(ArrAdd);
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 4:
                        Console.Write("Nhap so Sinh vien muon xoa : ");
                        string removeSV = Console.ReadLine();
                        ArrSV.Remove(removeSV);
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 6:
                        Console.WriteLine("Chuong trinh dang thuc hien xoa man hinh. ");
                        Console.Clear();
                        Console.WriteLine("Man Hinh Da Xoa Xong.");
                        Console.WriteLine("Dang Cap Nhap Lai Du Lieu");
                        Console.WriteLine("Data Update......");
                        Pause();
                        Console.WriteLine("Cap Nhap Data Hoan thanh");
                        Pause();
                        Console.Clear();
                        Console.WriteLine("--------------------------------------Chuong Trinh Quan Li Sinh Vien--------------------------------------------");
                        goto Menu;
                    case 7:
                        Console.WriteLine("Ban da chon ket thuc chuong trinh. Cam on vi da su dung chuong trinh");
                        Console.WriteLine("See you again in next time. Bye");
                        choice = false;
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le ");
                        Endprogam(ref choice);
                        break;
                }
            } while (choice == true);
            Console.Read();
        }
        public static void inputInfo(ArrayList ArrSV,ref double j)
        {
            foreach (SV items in ArrSV)
            {
                Console.WriteLine("Sinh vien thu {0}", j);
                items.getMSSV = j;
                items.InputInfo();
                items.InputScore();
                j++;
            }
        }
        public static void printInfo(ArrayList ArrSV)
        {
            foreach (SV items in ArrSV)
                items.OutputInfo();
        }
        public static void Pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Endprogam(ref bool choose)
        {
            Console.WriteLine("Ban co muon ket thuc chuong trinh ");
            Console.WriteLine("YES TO CONTINUE OR ANYTHING TO END ");
            Console.Write("Lua chon cua ban : ");
            string choice = Console.ReadLine();
            if (choice == "YES") choose = true;
            else choose = false;
        }
        static void StartProgam()
        {
            Console.WriteLine("-----------------------------------------Bang Quan Li Sinh Vien--------------------------------------------");
            Console.WriteLine("MSSV\t||Name\t\t||Age\t||Gender||Address\t||Math_S||Lit_S\t||Eng_S\t||Phy_S\t||Che_S\t||Avg_S\t");
        }
        static void functionProgam()
        {
            Console.WriteLine("Cac chuc nang cua chuong trinh :");
            Console.WriteLine("1/Sap xep theo diem ");
            Console.WriteLine("2/Sap xep theo MSSV ");
            Console.WriteLine("3/Them SV ");
            Console.WriteLine("4/Xoa SV ");
            Console.WriteLine("5/Sua thong tin SV ");
            Console.WriteLine("6/Xoa man hinh ");
            Console.WriteLine("7/Ket thuc chuong trinh ");
            Console.Write("Nhap lua chon cua ban ");
        }
    }
}
