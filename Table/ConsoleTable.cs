using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AntminerParser
{
    public class ConsoleTable
    { 
        
       public static void write(List<string> list)
       {
           
           var space = 4;
           
            
            string str=default;
            for (int i = 0; i < list.Count/10; i++)
            {
                int j = i * 10;
               
              
                
                   
                    try
                    {
                        if (j==0)
                        {
                           
                            str += $"|{CenterValue.addlength(list[0],list[0].Length+space)}|{CenterValue.addlength(list[1],list[1].Length+space)}|" +
                                   $"{CenterValue.addlength(list[2],list[2].Length+space)}|{CenterValue.addlength("Watts","Watts".Length+space+4)}|" +
                                   $"{CenterValue.addlength(list[4],list[4].Length+space)}|{CenterValue.addlength("GH/S(RT)","GH/S(RT)".Length+space)}|" +
                                   $"{CenterValue.addlength(list[6],list[6].Length+space)}|{CenterValue.addlength(list[7],list[7].Length+space)}|" +
                                   $"{CenterValue.addlength("Temp(Chip2)","Temp(Chip2)".Length+space)}|{CenterValue.addlength(list[9],list[9].Length+space)}"+"\n\r";
   
                        }
                        else
                        {
                            
                            
                           
                                str += $"|{CenterValue.addlength(list[j+1],list[0].Length+space)}|{ CenterValue.addlength(list[j+2],list[1].Length+space)}|" +
                                       $"{ CenterValue.addlength(list[j+3],list[2].Length+space)}|{ CenterValue.addlength(list[j+4],"Watts".Length+space+4)}|" +
                                       $"{ CenterValue.addlength(list[j+5],list[4].Length+space)}|{ CenterValue.addlength(list[j+6],"GH/S(RT)".Length+space)}|" +
                                       $"{ CenterValue.addlength(list[j+7],list[6].Length+space)}|{ CenterValue.addlength(list[j+8],list[7].Length+space)}|" +
                                       $"{ CenterValue.addlength(list[j+9],"Temp(Chip2)".Length+space)}|{ CenterValue.addlength(list[j+10],list[9].Length+space)}"+"\n\r";
 
                        }
                            
                            
                    }
                    catch (Exception e)
                    {
                       
                        
                    }
                   
                    
                      
                    
                    
            }
              
            try
            {
                str += $"|{CenterValue.addlength(list[list.Count-6],list[0].Length+space)}|{ CenterValue.addlength(list[list.Count-5],list[1].Length+space)}|" +
                       $"{ CenterValue.addlength(list[list.Count-4],list[2].Length+space)}|{ CenterValue.addlength(list[list.Count-3],"Watts".Length+space+4)}|" +
                       $"{ CenterValue.addlength(list[list.Count-2],list[4].Length+space)}|{ CenterValue.addlength(list[list.Count-1],"GH/S(RT)".Length+space)}|" +"\n\r";

            }
            catch (Exception exception)
            {
                          
            }
            
            
            Console.WriteLine(str);
            
        }
    }
}