//Chuong trinh Quan Li Sinh Vien by Nguyen Minh Thuan UIT Students KHCL2020.1
//Phien ban hien tai: 1.03
//Chuong trinh duoc thuc hien sau khi hoc C# va C# OOP trong 2h
//Vi the code dai va lung tung cung xin thong cam
//Chuong trinh nay duoc dung de quan li sinh vien va thuc hanh code OOP cho quen tay
//Co the coi huong dan su dung o file : HOWTOUSE.TXT
//Co the coi phien ban chuong trinh o file : README.TXT
//Thanhs for reading
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace QLSV
{
    public class SV //class khai bao SV
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
        private double MSSV;// De MSSV double vi luoi sua 
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
        public string getName
        { get { return name; } set { name = value; } }
        public string getNAGA
        {
            get
            {
                if (Choice == "Name") return name;
                else if (Choice == "Age") return age;
                else if (Choice == "Address") return address;
                else if (Choice == "Gender") return gender;
                else return "Lua chon khong hop le";
            }
            set
            {
                if (Choice == "Name") name = value;
                else if (Choice == "Age") age = value;
                else if (Choice == "Address") address = value;
                else if (Choice == "Gender") gender = value;
                else Console.WriteLine("Lua chon khong hop le");
            }
        }
        public double getMSSV
        { get { return MSSV; } set { MSSV = value; } }
        public string getChoice
        { get { return Choice; } set { Choice = value; } }
        public double getScore// Nhan diem vao va ra tuy vao lua chon
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
        private void check(ref double Score)//Kiem tra diem sinh vien nhap vao co hop le khong
        {
            while (Score > 10 || Score < 0)
            {
                Console.WriteLine("\nDiem nhap vao khong hop le.");
                Console.Write("Nhap Lai: ");
                Score = double.Parse(Console.ReadLine());
            }
        }
        public void InputInfo()//Nhap vao cac thong tin co ban cua SV
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
        public void InputScore()//Nhap diem cua sinh vien
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
    public class Sort_Score : IComparer<SV>// class sap xep diem SV theo cac mon
    {
        private string choiceSort;
        public void inputChoice(string choice)
        {
            choiceSort = choice;
        }

        public int Compare(SV x, SV y)
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
    public class SearchNameSV // class tim kiem SV tra ve vi tri cua SV can tim trong List
    {
        string namesearch;
        public SearchNameSV(string name)
        {
            namesearch = name;
        }
        // Hàm gán cho delegage
        public bool search(SV p)
        {
            return p.getName == namesearch;
        }
    }
    public class changeSV//Class thay doi thong tin SV 
    {
        public void ChangeScoreSV(ref SV Info_change,string choice)
        {
            if (choice != "Name" && choice != "Age" && choice != "Address" && choice != "Gender" && choice != "All")
            {
                Info_change.getChoice = choice;
                Console.Write("\rNhap diem mon {0}: ", choice);
                double score_change = double.Parse(Console.ReadLine());
                Info_change.getScore = score_change;
            }
            else if (choice == "Name" || choice == "Age" || choice =="Address" || choice == "Gender")
            {
                Info_change.getChoice = choice;
                Console.Write("\rNhap {0}: ", choice);
                string NAGA = Console.ReadLine();
                Info_change.getNAGA = NAGA;
            }
            else
            {
                Info_change.InputInfo();
                Info_change.InputScore();
            }
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
            while (n > 10 || n < 0)//Xoa dong nay neu muon nhap hon 10 Sinh vien
            {
                Console.WriteLine("So sinh vien toi da random hoac tu nhap la 10 hoac ban da nhap so sinh vien khong hop le.");
                Console.Write("Nhap Lai : ");
                n = int.Parse(Console.ReadLine());
            }// Va ca dong nay nua nha :))
            List<SV> ArrSV = new List<SV>(n);
            Console.WriteLine("2 Che do : Random va tu nhap thong tin. ");
            Console.WriteLine("Ban muon random SV hay tu nhap . Neu chon random thi ghi Random neu tu nhap thi ghi gi cung duoc ");
            Console.Write("Lua chon cua ban : ");//Che do Random chi tu dong nhap duoc toi da 10 nguoi , neu nhap qua se bi crash
            string c_random = Console.ReadLine();
            if (c_random != "Random")//Tu nhap vao
            {
                for (int i = 0; i < n; i++)
                    ArrSV.Add(new SV());
                inputInfo(ArrSV, ref j);
            }
            else//Random SV
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
                    case 1://Sap xep theo diem
                        Console.Write("Ban muon sap xep mon nao ");
                        string subject = Console.ReadLine();
                        Sort_Score sub = new Sort_Score();
                        sub.inputChoice(subject);
                        ArrSV.Sort(sub);
                        Console.WriteLine("Sau khi sap xep theo Diem {0} :", subject);
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 2://Sap xep theo MSSV
                        Sort_Score sub_2 = new Sort_Score();
                        sub_2.inputChoice("MSSV");
                        ArrSV.Sort(sub_2);
                        Console.WriteLine("Sau khi sap xep theo MSSV :");
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 3://Them SV
                        Console.Write("Nhap so Sinh vien muon them : ");
                        int addSV = int.Parse(Console.ReadLine());
                        List<SV> ArrAdd = new List<SV>(addSV);
                        for (int i = 0; i < addSV; i++)
                            ArrAdd.Add(new SV());
                        inputInfo(ArrAdd, ref j);
                        ArrSV.AddRange(ArrAdd);
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 4://Xoa sinh vien
                        Console.Write("Nhap ten Sinh vien muon xoa : ");
                        string name_remove = Console.ReadLine();
                        SV reSV = ArrSV.Find(new SearchNameSV(name_remove).search);//Tim kiem vi tri SV can xoa trong list ban dau
                        ArrSV.Remove(reSV);
                        printInfo(ArrSV);
                        Endprogam(ref choice);
                        break;
                    case 5://Sua thong tin SV( p/s : Thong tin Age neu sua o lan dau nhap vao thi duoc nhung lan 2 se bi crash ct)
                    StartChange:
                        string y_choice = "y";
                        string _choice = "1";
                        do
                        {
                            Console.Write("Nhap ten sinh vien muon sua : ");
                            string name_change = Console.ReadLine();
                            ThisSVchange:
                            int index = ArrSV.FindIndex(new SearchNameSV(name_change).search);
                            SV chSV = ArrSV.Find(new SearchNameSV(name_change).search);
                            if (_choice != "0") { Console.WriteLine("\rThong tin sinh vien can doi : ");
                                chSV.OutputInfo(); }
                            ArrSV.Remove(chSV);
                            Console.WriteLine("Ban muon doi thong tin nao cua sinh vien hay toan bo : ");
                            Console.Write("Neu toan bo nhap All khong thi nhap thong tin can sua: ");
                            string infochange = Console.ReadLine();
                            changeSV changeInfo = new changeSV();
                            changeInfo.ChangeScoreSV(ref chSV, infochange);
                            ArrSV.Insert(index, chSV);
                            printInfo(ArrSV);
                            Continue(ref y_choice, "sua");       
                            if (y_choice == "y" )
                            {
                                Console.WriteLine("Ban muon tiep tuc sua sinh vien nay hay sua sinh vien khac ");
                                Console.Write("Nhap 0 de tiep tuc sua sinh vien hay nhap gi cx duoc de sua sv khac");
                                _choice = Console.ReadLine();
                                if (_choice == "0") goto ThisSVchange;
                                else goto StartChange;
                            }
                        } while (y_choice == "y");
                        Endprogam(ref choice);
                        break;
                    case 6://Tim kiem sinh vien
                        Console.Write("Nhap ten Sinh vien muon tim kiem : ");
                        string name_search = Console.ReadLine();
                        SV searchSV = ArrSV.Find(new SearchNameSV(name_search).search);//Tim kiem vi tri SV can kiem trong list ban dau
                        Console.WriteLine("Thong tin sinh vien sau khi tim kiem la: ");
                        searchSV.OutputInfo();
                        Endprogam(ref choice);
                        break;
                    case 7://Xoa toan bo thong tin SV
                        ArrSV.Clear();
                        printInfo(ArrSV);
                        break;
                    case 8://Xoa man hinh
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
                    case 9://Ket thuc chuong trinh
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
        public static void inputInfo(List<SV> ArrSV, ref double j)//Ham nhap vao thong tin cua cac sinh vien
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
        public static void printInfo(List<SV> ArrSV)//Ham in thong tin cua cac sinh vien trong List
        {
            foreach (SV items in ArrSV)
                items.OutputInfo();
        }
        public static void Pause()//Ham dung chuong trinh de lam mau
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void Continue(ref string choice,string mess)//Ham lua chon 
        {
            Console.WriteLine("Ban co muon " + mess + " tiep khong ");
            Console.Write("Neu co ghi y khong thi phim gi cung duoc ");
            choice = Console.ReadLine();
        }
        static void Endprogam(ref bool choose)//Ham lua chon ket thuc chuong trinh
        {
            Console.WriteLine("Ban co muon ket thuc chuong trinh ");
            Console.WriteLine("YES TO CONTINUE OR ANYTHING TO END ");
            Console.Write("Lua chon cua ban : ");
            string choice = Console.ReadLine();
            if (choice == "YES") choose = true;
            else choose = false;
        }
        static void StartProgam()//Ham tao gioi thieu va khung chuong trinh 
        {
            Console.WriteLine("-----------------------------------------Bang Quan Li Sinh Vien--------------------------------------------");
            Console.WriteLine("MSSV\t||Name\t\t||Age\t||Gender||Address\t||Math_S||Lit_S\t||Eng_S\t||Phy_S\t||Che_S\t||Avg_S\t");
        }
        static void functionProgam()//Ham in ra cac chuc nang cua chuong trinh
        {
            Console.WriteLine("Cac chuc nang cua chuong trinh :");
            Console.WriteLine("1/Sap xep theo diem ");
            Console.WriteLine("2/Sap xep theo MSSV ");
            Console.WriteLine("3/Them SV ");
            Console.WriteLine("4/Xoa SV ");
            Console.WriteLine("5/Sua thong tin SV ");
            Console.WriteLine("6/Tim SV");
            Console.WriteLine("7/Xoa het toan bo thong tin SV");
            Console.WriteLine("8/Xoa man hinh ");
            Console.WriteLine("9/Ket thuc chuong trinh ");
            Console.Write("Nhap lua chon cua ban ");
        }
    }
}
