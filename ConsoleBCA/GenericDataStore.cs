using ConsoleBCA.InterfaceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA
{
    public class GenericDataStore<T1, T2> where T1: struct where T2 : class
    {
        public T1 Data { get; set; }
        public T2 Data2 { get; set; }
        ~GenericDataStore(){
            Console.WriteLine("Calling Destructor");
        }
       

    }
    public interface IDataStore<T1,T2,T3> where T1 : struct where T2 : class where T3: IProduct
    {
        void Test1(T1 t1, T2 t2);
        void Test2(T2 t2, T3 t3);

    }
}
