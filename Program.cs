using System;
using System.Globalization;
using System.Reflection.Metadata;
namespace baitapfor2{
    class Program{
        static void Main(string[] Args){
            int num = 0;
            Console.WriteLine("Danh sach so nguyen to :");

            for(int i = 2; i <= 100; i ++){
                for(int j = 1; j <= i; j ++){
                    if(i % j == 0){
                        num++;
                    }
                }
                if(num == 2){
                Console.WriteLine(i);
            }
            num = 0;

        }
    }
}
}