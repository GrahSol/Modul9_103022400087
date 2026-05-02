using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400087
{
    public class BankTransferConfig
    {


        public string filePath;
        public Config config;

       

        public BankTransferConfig()
        {

            try
            {
                ReadConfig();
            }
            catch
            {
                SetDefault();
                WriteConfigFile();

            }
        }
        

        public void SetDefault()
        {
            List<string> methods = new List<string>();
            methods.Add("RTO (real-time)");
            methods.Add("SKN");
            methods.Add("RTGS");
            methods.Add("BI FAST");

            Transfer transfer = new Transfer(25000000,
                6500,
                15000);
            Confirmation confirm = new Confirmation("yes",
                "ya");
            config = new Config(
                "en",
                transfer,
                methods,
                confirm

            );

        }
        public void ReadConfig()
        {
            string jsonString = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<Config>(jsonString);

        }
        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { 
                WriteIndented = true 
            };
            string jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);

        }



    }
}
