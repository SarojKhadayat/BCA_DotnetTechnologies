using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;
using System.Text;
using ConsoleBCA.Struct;
using ConsoleBCA.TypeOfClass;
using ConsoleBCA.Indexer;
using ConsoleBCA.InterfaceExample;
using System.Reflection;
using ConsoleBCA.Enum;
using ConsoleBCA.Event;
using ConsoleBCA.LambdaExpression;

namespace ConsoleBCA
{
    class Program
    {
        public delegate T PrintResultDel<T>(T result);

        static void Main(string[] args)
        {
            #region Function overloading
            //Calculate calculate = new Calculate();
            //var sum1 = calculate.Sum(1, 3);
            //var sum2 = calculate.Sum("Hello", "World");
            //var sum3 = calculate.Sum(1, 2, 3);
            //Console.WriteLine($"Sum of 2 numbers: {sum1}");
            //Console.WriteLine($"Sum of 2 strings: {sum2}");
            //Console.WriteLine($"Sum of 3 numbers: {sum3}");
            #endregion

            #region Function overriding
            //Triangle triangle = new Triangle(4, 5);
            //var areaOfTriangle = triangle.GetArea();
            //Console.WriteLine("Area: {0}", areaOfTriangle);


            //Rectangle rect = new Rectangle(2, 4);
            //var areaOfRectangle = rect.GetArea();
            //Console.WriteLine("Area: {0}", areaOfRectangle);

            #endregion

            #region Inheritance
            // Student student1 = new Student("Ramesh", "Pokheral", 1, "Compute");
            //// student2 = new Student("Balen", "Shah", 2 , "Civil");
            //Student student1 = new Student
            //{
            //    FirstName = "Steve",
            //    LastName = "Messer",
            //    Department = new Department
            //    {
            //        Id = 1,
            //        Name = "Computer"
            //    }
            //};
            //Student student1 = new Student();
            //student1.FirstName = "Ram";
            //student1.LastName = "Test";


            //Console.WriteLine($"Student: {student1.GetStudentFullName()} Deparment: {student1.Department.GetDeparmentDetails()}");
            //Console.WriteLine($"Student: {student2.GetStudentFullName()} Deparment: {student2.Department.GetDeparmentDetails()}");
            #endregion

            #region Access Modifiers
            //Product pr = new Product(1, "A", "Test");
            //pr.IsTaxApplicable();

            //ProductBase pb = new ProductBase(2,"B", "Yest");
            #endregion

            #region Value and reference type
            //int newi = 10;
            //ChangeValue(ref newi);
            //Console.WriteLine("Value of i: {0}", newi);

            //List<string> names = new List<string> { "Steve", "Amy", "Eric" };
            //List<string> newNames = names;
            //ChangeList(names);
            //foreach (var name in newNames) {
            //    Console.WriteLine("Name: {0}", name);
            //}

            //string str = "hello";
            //str.Concat("Nepal");

            //StringBuilder strBuilder = new StringBuilder("Test");
            //strBuilder.Append("New");

            //ChangeString(str);
            //Console.WriteLine("Update string: {0}", str);
            #endregion

            #region Struct
            CoordinatePoint cp = new CoordinatePoint(10, 100);
            Console.WriteLine("Latitude: {0} - Longitude: {1} ", cp.Latitude, cp.Longitude);
            var cp2 = cp;
            cp.Latitude = 900000;
            Console.WriteLine("Latitude: {0} - Longitude: {1} ", cp2.Latitude, cp2.Longitude);
            #endregion

            #region PartialClass
            // PartialExample example = new PartialExample();
            // Customer cust = new Customer(1,"test","rest");
            // Utility.ReturnNothing();
            // Utility.Id = 100;

            // string str = "hello";
            //var appended= str.AppendTest();
            // Console.WriteLine(appended);

            #endregion

            #region indexer
            //DataStore ds = new DataStore();
            //ds[0] = "Data1";
            //ds[1] = "Data2";

            //for (int i = 0; i < 10; i++) {
            //    Console.WriteLine(ds[i]);
            //}
            #endregion

            #region interface
            //Console.WriteLine("Enter integer value");
            //var ptype = Convert.ToInt32(Console.ReadLine());
            //IProduct product = new HomeAppliances();
            //if (ptype == 1)
            //{
            //    product = new HomeAppliances();
            //}
            //if (ptype == 2)
            //{
            //    product = new KitchenUtensils();
            //}
            //GetProduct(product);
            //Console.WriteLine(product.GetDetails(0));

            #endregion

            #region generics
            //Sum<KitchenUtensils>(new(), new KitchenUtensils());
            //Sum<HomeAppliances>(new HomeAppliances(), new HomeAppliances());
            //GenericDataStore<List<int>, int> ds = new();
            //ds.Data = new List<int> { 1, 3, 4, 5 };
            //ds.Data2 = 1;
            //GenericDataStore<List<string>, string> dss = new();
            //dss.Data = new List<string> { "Hello", "World" };
            //dss.Data2 = "Test";
            #endregion

            #region Enum
            //Console.WriteLine("Enter integer value: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //DataTypeEnum enumValue = (DataTypeEnum)input;
            //var output = GetResult(enumValue);
            //Console.WriteLine("Enum value is: {0}", output);
            #endregion

            #region Delegates
            // Console.WriteLine("Enter 1 for PDF, 2 for Excel.");
            // int input = Convert.ToInt32(Console.ReadLine());
            // PrintResultDel<string> del1= new PrintResultDel<string>(PrintPdf);
            // if (input == 1)
            // {
            //     del1 = new PrintResultDel(PrintPdf);
            //     PrintResult(del1, "PDF");
            // }
            // else
            // {
            //     del1 = PrintExcel;
            //     PrintResult(del1, "excel");

            // }
            // PrintResultDel<string> del2 = PrintExcel;
            // PrintResultDel<string> del = del1 + del2;
            // PrintResultDel<string> del3 = PrintWord;
            // del += del3;
            // del = del - del2;
            // del -= del3;
            //var returnedValue= del("Test");
            // Console.WriteLine("Returned Value: {0}", returnedValue);
            #endregion

            #region Events
            //ProcessBusinessLogic pbl = new ProcessBusinessLogic();
            //pbl.ProcessCompleted += SendEmail;
            //pbl.ProcessCompleted += SendTextMessage;
            //pbl.ProcessCompleted += SendMobileNotification;
            //var msg = "Process started fron publisher.";
            //pbl.StartProcess(msg);
            #endregion

            #region events practice work for students
            //Console.WriteLine("Enter event:");
            //int eventId = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter message: ");
            //string msg = Console.ReadLine();

            //HelperLogic helperLogic = new HelperLogic();
            //helperLogic.OnEventComplete += WriteMessageAndId;
            //helperLogic.OnEventComplete += WriteMessageAndIdToDatabase;
            //helperLogic.Help(eventId, msg);

            #endregion

            #region Lambda expression
            List<Student> students = new List<Student> {
                new Student(1, "Amy", 22, "KTM"),
                new Student(2, "Steve", 14, "Lalitpur"),
                new Student(3, "Jack", 19,"Baneswor"),
                new Student(4,"Jeff", 30, "Jawlakhel")
            };
            Func<Student, int, string, bool> studentFilter1 =
                (student, age, name) => student.Age > age || student.Name == name;

            Func<Student, int, string, bool> studentFilter2 =
                (student, age, name) => student.Age > age || student.Name == name || student.Name.StartsWith(name);

            var fStudents=  FilterStudentsUsingLambda(students, studentFilter1);

            var fStudents2 = FilterStudentsUsingLambda(students, studentFilter2);

            foreach (var student in fStudents) {
                Console.WriteLine($"{student.Id}: {student.Name}: {student.Address}: {student.Age}");
            }
            #endregion
            Console.ReadKey();
        }

        public static List<Student> FilterStudentsUsingLambda(List<Student> students, Func<Student, int, string, bool> filter)
        {
            List<Student> filteredStudents = new();
            foreach (var student in students)
            {
                if (filter(student, 19, "Amy"))
                {
                    filteredStudents.Add(student);
                }
            }
            return filteredStudents;
        }
        public static void WriteMessageAndId(object o, HelperMessageEventArgs e)
        {
            Console.WriteLine($"Id:{e.Id}-message:{e.Message}");
        }

        public static void WriteMessageAndIdToDatabase(object o, HelperMessageEventArgs e)
        {
            Console.WriteLine($"write Id:{e.Id}-message:{e.Message} to database");
        }
        public static void SendEmail(object o, ProcessCompletedEventArgs e)
        {
            Console.WriteLine(e.EventMessage);
            Console.WriteLine("Done email sending.");
        }
        public static void SendTextMessage(object o, ProcessCompletedEventArgs e)
        {
            Console.WriteLine(e.EventMessage);
            Console.WriteLine("Done sending message.");
        }
        public static void SendMobileNotification(object o, ProcessCompletedEventArgs e)
        {

            Console.WriteLine(e.EventMessage);
            Console.WriteLine("Done sending mobile notification.");
        }
        public static void PrintResult(PrintResultDel<string> printDel, string value)
        {
            string returnedValue = printDel(value);
            Console.WriteLine(returnedValue);
        }
        public static string PrintPdf(string pdf)
        {
            Console.WriteLine("From PDf: {0}", pdf);
            return "PDF";
        }
        public static string PrintWord(string Word)
        {
            Console.WriteLine("From WOrd:{0}", Word);
            return "Word";
        }
        public static string PrintExcel(string excel)
        {
            Console.WriteLine("From excel: {0}", excel);
            return "Excel";
        }
        public static string GetProduct(IProduct product)
        {
            Console.WriteLine(product.ShowPrice(1));
            return product.GetDetails(1);
        }
        public static void ChangeValue(ref int i)
        {
            i = 200;
        }
        public static void ChangeList(List<string> allNames)
        {
            allNames.Add("Rajesh");
            allNames.Add("Bhuwan");
        }
        public static void ChangeString(string strv)
        {
            strv = "World";
        }
        public static void Sum<T>(T value1, T value2) where T : IProduct
        {
            if (typeof(T) == typeof(int))
            {
                Console.WriteLine(Convert.ToInt32(value1) + Convert.ToInt32(value2));
            }
            else if (typeof(T) == typeof(string))
            {
                Console.WriteLine(value1.ToString() + value2.ToString());
            }

        }
        public List<T> GetData<T>(List<T> testData, int d) where T : IProduct
        {
            var resutl = new List<T>();
            foreach (var p in testData)
            {
                if (p.ShowDiscount() > d)
                {
                    resutl.Add(p);
                }
            }
            return resutl;
        }

        public static dynamic ReturnData(dynamic vardata = null)
        {
            if (vardata == 1)
            {
                return "Test";
            }
            else if (vardata == "Int")
            {
                return 1;
            }
            dynamic value = "Test";
            return new Customer(1, "Test", "Dynamic");
        }
        public static object ReturnObject(int a)
        {
            if (a == 1)
            {
                return new Customer(1, "Test", "Dynamic");
            }
            else if (a == 2)
            {
                return 2;
            }
            else if (a == 3)
            {
                return a.ToString();
            }
            return a;
        }
        public static dynamic GetResult(DataTypeEnum dte)
        {
            dynamic obj;
            switch (dte)
            {
                case DataTypeEnum.numeric:
                    obj = 1;
                    break;
                case DataTypeEnum.alphanumeric:
                    obj = "Apl12445";
                    break;
                case DataTypeEnum.obj:
                    obj = new ConsoleBCA.Inheritance.Student("Hello", "world", 1, "computer");
                    break;
                default:
                    obj = null;
                    break;
            }
            return obj;
        }
    }
}
