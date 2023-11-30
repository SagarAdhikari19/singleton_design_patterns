// simple singleton pattern caode :
//No Thread-Safe Singleton Design Pattern Implementation in C#


using System;
using System.Diagnostics.Metrics;
namespace SingletonDemo
{

    class Program
    {


        public static void Main(string[] args)
        {
                 Practice res =Practice.get_the_instance();
                 res.To_print("hello world");


                
        }
    }


}