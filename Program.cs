using System;
using System.Collections.Generic;
using System.Threading;

namespace AntminerParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string ASICip="192.168.1.XX";
            string user = "root";
            string password = "root";
            int updateTime = 2; //minutes
            
            while (true)
            {   
           
                string html = AuthorizationWEB.DownloadString($"http://{ASICip}/cgi-bin/minerStatus.cgi", user, password);

                
                //Parsing a table and writing to a list
                List<string> table = Parsing.Table(html,"//table[@class='cbi-section-table']",
                    @"<legend>AntMiner</legend>([\w \W ]+)<div class=""cbi-section-node"" style=""margin-top:8px;"">");
                
                
                Console.Clear();
                
                //output the table to the terminal
                ConsoleTable.write(table);  
                
                Thread.Sleep(60000*updateTime);
            }
            

           
        }
    }
}   
    
