using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Daniel_Khaliulin_Task2
{
    public static class ConfigReader
    {
        private static String _path;

        public static char[]  Separator 
        { 
               get 
              {
                 // Checking is value of setting "separator" exist.
                  if (!ConfigurationManager.AppSettings["Separator"].ToString().Equals("")) 
                {
                    char[] separator = ConfigurationManager.AppSettings["Separator"].ToString().ToCharArray();
                    return separator;
                }
                 // Using default value.
                else 
                {
                    char[] separator = new char [] {';'};
                    return separator;
                }
            }
        }

        public static String InputFilePath
        {
            get
            {

                // Checking is value of setting "InputFilePath" exist.
                if (!ConfigurationManager.AppSettings["InputFilePath"].ToString().Equals(""))
                {   
                    return @ConfigurationManager.AppSettings["InputFilePath"].ToString();
                }
                // Using default value.
                else
                {
                    _path = @Environment.CurrentDirectory + @"\input.txt";
                    return _path;
                }
            }
        }

        public static String OutputFilePath
        {
            get
            {
                // Checking is value of setting "OutputFilePath" exist.
                if (!ConfigurationManager.AppSettings["OutputFilePath"].ToString().Equals(""))
                {
                    return @ConfigurationManager.AppSettings["OutputFilePath"].ToString();
                }
                // Using default value.
                else
                {
                    _path = @Environment.CurrentDirectory + @"\output.txt";
                    return _path;
                }
            }
        }


        
    }

}
