using homework12.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework12.models
{
    class student:ICheck
    {
        private string _fullname;
        private string _groupno;
        public byte Age;
        public student(string groupno,string fullname,byte age)
        {
            Groupno = groupno;
            Fullname = fullname;
            Age = age;

        }
        public string Groupno
        {
            get => _groupno;

            set
            {
                while (!Groupcheck(value))
                {
                    Console.WriteLine("duzgun daxil edin");
                    value = Console.ReadLine();
                }
                _groupno =value;
            }
        }
        public string Fullname {
            get => _fullname;
            set
            {
                while (!FullNamecheck(value))
                {
                    Console.WriteLine("adin yazilisi misal:Murad Abdullayev");
                    value = Console.ReadLine();
                }
                _fullname = value;
            } 
        }

        public bool Groupcheck(string groupno)
        {
            bool checker = false;
            if (groupno.Length==4)
            {
               
                if (char.IsUpper(groupno[0]))
                {
                    for (int i = 1; i < groupno.Length; i++)
                    {
                        if (char.IsDigit(groupno[i]))
                        {
                            checker = true;
                            return checker;
                            
                        }
                        else
                        {
                            Console.WriteLine("reqem olmalidir!");
                            return checker;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("birinci herif boyuk olmalidir");
                }
            }
            else
            {
                Console.WriteLine("1 boyuk herif ve 3 natural ededden ibaret olmalidir");
            }
            return checker;
        }

        public bool FullNamecheck(string fullname)
        {
           
            bool chech = false;
            foreach (char item in fullname)
            {
                if (char.IsWhiteSpace(item))
                {
                  
                    chech = true;
                    return chech;

                }
              
            }
           

            return chech;
        }
        
    }
}
