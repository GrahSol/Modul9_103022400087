using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400087
{
    class Program
    {
        private static bool mehtod;

        static void Main(string[] args)
        {
            double transfer;
            double fee;
            BankTransferConfig bankConfig = new BankTransferConfig();
            if (bankConfig.config.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
                transfer = int.Parse(Console.ReadLine());
                if (transfer <= bankConfig.config.transfer.threshold)
                {
                    fee = bankConfig.config.transfer.low_fee;
                    Console.WriteLine($"Transfer fee = {fee}");

                }
                else
                {
                    fee = bankConfig.config.transfer.high_fee;
                    Console.WriteLine($"Transfer fee = {fee}");

                }
                Console.WriteLine($"Total Amount = {transfer} {fee}");
                Console.WriteLine($"Select transfer method:");
                



            }
            else
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di transfer");
                transfer = int.Parse(Console.ReadLine());
                if (transfer <= bankConfig.config.transfer.threshold)
                {
                    fee = bankConfig.config.transfer.low_fee;
                    Console.WriteLine($"Transfer fee = {fee}");

                }
                else
                {
                    fee = bankConfig.config.transfer.high_fee;
                    Console.WriteLine($"Transfer fee = {fee}");

                }
                Console.WriteLine($"Total Amount = {transfer} {fee}");
                Console.WriteLine($"Select transfer method:");
                bankConfig.config.methods.ForEach(mehod => Console.WriteLine(mehtod));

            }

        }
        


    }
}