using System.Net.Mime;
using System.Runtime.CompilerServices;
using static OgrenciYoklama.Program;

namespace OgrenciYoklama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1903, "Süleyman SEBA", true));
            students.Add(new Student(1,"Mert GÜNOK",true));
            students.Add(new Student(26, "İlhan MANSIZ", false));
            students.Add(new Student(4,"Tayyip Talha SANUÇ",true));
            students.Add(new Student(7, "Feyyaz UÇAR", false));
            students.Add(new Student(8,"Salih UÇAN",true));
            students.Add(new Student(2, "Recep ÇETİN", false));
            students.Add(new Student(11, "Metin TEKİN", false));
            students.Add(new Student(3,"Gökhan KESKİN",false));
            students.Add(new Student(9, "Ali GÜLTİKEN", false));
            students.Add(new Student(22,"Cenk TOSUN",true));
            students.Add(new Student(12,"Onur BULUT",true));
            students.Add(new Student(19,"Semih KILÇSOY",true));
            students.Add(new Student(17,"Berkay VARDAR",true));
            students.Add(new Student(10,"Sergen YALÇIN",false));
            int choice;
            bool isTrue = true;
            while (isTrue)
            {
                Console.Clear();
                choice = Welcome();

                switch (choice)
                {
                    case 1:
                        WriteList(students);
                        Console.ReadLine();
                        break;
                    case 2:
                        StudentListByAvailable(students,true);
                        Console.ReadLine();
                        break;
                    case 3:
                        StudentListByAvailable(students,false);
                        Console.ReadLine();
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("Öğrenci Numarası Giriniz : ");
                            string inputNumber = Console.ReadLine();
                            int number;
                            if (int.TryParse(inputNumber, out number))
                            {
                                GetStudentByID(students, number);
                                Console.ReadLine();
                                break;
                            }
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız... Devam etmek için enter tuşuna basınız...");
                        Console.ReadLine();
                        break;
                }
            }
            
        }

        public static void WriteList(List<Student> students)
        {
            Console.WriteLine("\n=============SINIF ÖĞRENCİ LİSTESİ================");
            Console.WriteLine("Öğrenci No\tÖğrenci Ad Soyad\tSınıfta Mı");
            Console.WriteLine("--------------------------------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine("{0,5}\t\t{1,-20}\t{2,-5}",student.StudentNo,student.FullName,student.isAvailable);
            }
        }

        public static void GetStudentByID(List<Student> students, int id)
        {
            while (true)
            {
                Student student = students.Where(s => s.StudentNo == id).FirstOrDefault();
                if (student != null)
                {
                    Console.WriteLine("\nÖğrenci No\tÖğrenci Ad Soyad\tSınıfta Mı");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("{0,5}\t\t{1,-20}\t{2,-5}", student.StudentNo, student.FullName, student.isAvailable);
                    break;
                }
                else
                {
                    Console.WriteLine("Bu numarada bir öğrenci bulunmamaktadır.");
                    break;
                }
                
            }
        }

        public static void StudentListByAvailable(List<Student> students, bool avail)
        {
            if (avail)
            {
                Console.WriteLine("\n===========MEVCUT ÖĞRENCİ LİSTESİ==============");
            }
            else
            {
                Console.WriteLine("\n========MEVCUT OLMAYAN ÖĞRENCİ LİSTESİ===========");
            }
            
            Console.WriteLine("Öğrenci No\tÖğrenci Ad Soyad\tSınıfta Mı");
            Console.WriteLine("-------------------------------------------------");
            List<Student> isAvailsList = students.Where(s => s.isAvailable == avail).ToList();
            foreach (Student student in isAvailsList)
            {
                Console.WriteLine("{0,5}\t\t{1,-20}\t{2,-5}", student.StudentNo, student.FullName, student.isAvailable);
            }
        }

        public static int Welcome()
        {
            Console.WriteLine("Sisteme Hoşgeldiniz...\n\nLütfen Yapmak İstediğiniz İşlemi Seçiniz\n-------------------------------------");
            Console.WriteLine("Öğrenci Listesi İçin\t\t=> 1");
            Console.WriteLine("Yoklama Almak İçin\t\t=> 2");
            Console.WriteLine("Gelmeyen Öğrenci Listesi İçin\t=> 3");
            Console.WriteLine("Öğrenci Seçmek İçin\t\t=> 4");
            Console.WriteLine("Çıkış İçin\t\t\t=> 5\n-------------------------------------");
            Console.Write("Tercihiniz\t\t\t: ");
            int output;
            string input = Console.ReadLine();
            Console.WriteLine();
            if (!int.TryParse(input, out output))
            {
                Console.Clear();
                Welcome();
            }

            return output;

        }
        public class Student
        {
            public int StudentNo { get; set; }
            public string FullName { get; set; }
            public bool isAvailable { get; set; }

            public Student()
            {

            }

            public Student(int studentNo, string fullName, bool available)
            {
                StudentNo = studentNo;
                FullName = fullName;
                isAvailable = available;
            }

        }
    }
}