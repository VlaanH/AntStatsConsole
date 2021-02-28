using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AntminerParser
{
    public class ConsoleTable
    { 
        
       public static void write(List<string> list)
       {
           
           
            
            string str=default;
            for (int i = 0; i < list.Count; i++)
            {
               

               
                
                
              
                if ( Regex.Match(Convert.ToString((double)i/10), @"([,]+)").Groups[1].Value=="")
                { var space = 4;
                    try
                    {
                        if (i==0)
                        {
                           
                            str += $"|{CenterValue.addlength(list[0],list[0].Length+space)}|{CenterValue.addlength(list[1],list[1].Length+space)}|" +
                                   $"{CenterValue.addlength(list[2],list[2].Length+space)}|{CenterValue.addlength("Watts","Watts".Length+space+4)}|" +
                                   $"{CenterValue.addlength(list[4],list[4].Length+space)}|{CenterValue.addlength("GH/S(RT)","GH/S(RT)".Length+space)}|" +
                                   $"{CenterValue.addlength(list[6],list[6].Length+space)}|{CenterValue.addlength(list[7],list[7].Length+space)}|" +
                                   $"{CenterValue.addlength("Temp(Chip2)","Temp(Chip2)".Length+space)}|{CenterValue.addlength(list[9],list[9].Length+space)}"+"\n\r";
   
                        }
                        else
                        {
                            
                            
                           
                                str += $"|{CenterValue.addlength(list[i+1],list[0].Length+space)}|{ CenterValue.addlength(list[i+2],list[1].Length+space)}|" +
                                       $"{ CenterValue.addlength(list[i+3],list[2].Length+space)}|{ CenterValue.addlength(list[i+4],"Watts".Length+space+4)}|" +
                                       $"{ CenterValue.addlength(list[i+5],list[4].Length+space)}|{ CenterValue.addlength(list[i+6],"GH/S(RT)".Length+space)}|" +
                                       $"{ CenterValue.addlength(list[i+7],list[6].Length+space)}|{ CenterValue.addlength(list[i+8],list[7].Length+space)}|" +
                                       $"{ CenterValue.addlength(list[i+9],"Temp(Chip2)".Length+space)}|{ CenterValue.addlength(list[i+10],list[9].Length+space)}"+"\n\r";
 
                        }
                            
                            
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            str += $"|{CenterValue.addlength(list[i+1],list[0].Length+space)}|{ CenterValue.addlength(list[i+2],list[1].Length+space)}|" +
                                   $"{ CenterValue.addlength(list[i+3],list[2].Length+space)}|{ CenterValue.addlength(list[i+4],"Watts".Length+space+4)}|" +
                                   $"{ CenterValue.addlength(list[i+5],list[4].Length+space)}|{ CenterValue.addlength(list[i+6],"GH/S(RT)".Length+space)}|" +"\n\r";

                        }
                        catch (Exception exception)
                        {
                          
                        }
                        
                    }
                }
                    
                      
                    
                    
            }
                
            Console.WriteLine(str);
            
        }
    }
}