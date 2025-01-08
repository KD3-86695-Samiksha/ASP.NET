using AttributesLib;

namespace EntityLib
{
	[@Table(TableName ="Employee")]
	[Serializable]
	public class Employee
    {
		private int empno;
		private string name;
		private string address;
		private double salary;
		private double annualSal;
		private string  designaton;

        [@Column(ColumnName = "desig", ColumnType = "varchar(40)")]
        public string  Designation
		{
			get { return designaton; }
			set { designaton = value; }
		}

        [@UnMapped]
        public double AnnualSal
		{
			get { return annualSal; }
			set { annualSal = value; }
		}

        [@Column(ColumnName = "sal", ColumnType = "float(10)")]
        public double Salary
		{
			get { return salary; }
			set { salary = value; }
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

        [@Column(ColumnName = "eno", ColumnType = "int primary key auto_increment")]
        public int EmpNo
		{
			get { return empno; }
			set { empno = value; }
		}

        public Employee()
        {
            
        }

        public Employee(int empno, string name, string address, double salary, double annualSal, string designaton)
        {
            this.empno = empno;
            this.name = name;
            this.address = address;
            this.salary = salary;
            this.annualSal = annualSal;
            this.designaton = designaton;
        }
    }
}
