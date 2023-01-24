using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Data //this object keeps Student Information
    {
        //these are our props
        public string Name { get; set; }  
        public string Surname { get; set; }
        public int ID { get; set; } 
        public string department { get; set; }
        public double gno { get; set; }
        public int age { get; set; }
        public Data(string name, string surname, int ıD, string department, double gno, int age) //constructor
        {
            Name = name;
            Surname = surname;
            ID = ıD;
            this.department = department;
            this.gno = gno;
            this.age = age;
        }
    }
  
}
