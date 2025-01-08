using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributesLib;

namespace EntityLib
{
	[Serializable]
	[@Table(TableName ="Student")]
    public class Student
    {
		private int rollno;
        private string name;
        private string address;
        private string course;

        public Student()
        { 
        }
        public Student(int rollno, string name, string address, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.course = course;
        }

        [@Column(ColumnName = "course", ColumnType = "varchar(40)")]
        public string Course
		{
			get { return course; }
			set { course = value; }
		}

        [@Column(ColumnName = "address", ColumnType = "varchar(100)")]
        public string Address
		{
			get { return address; }
			set { address = value; }
		}

        [@Column(ColumnName = "name", ColumnType = "varchar(40)")]
        public string Name
		{
			get { return name; }
			set { name = value; }
		}
        [@Column(ColumnName = "roll_no", ColumnType = "int")]
        public int Rollno
		{
			get { return rollno; }
			set { rollno = value; }
		}

	}
}
