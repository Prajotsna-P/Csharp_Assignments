using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Employee
{
    private int EmpNO;
    private string EmpName;
    private double Salary;
    private double HRA;
    private double TA;
    private double DA;
    private double PF;
    private double TDA;
    private double NetSalary;
    private double GrossSalary;

    public int _EmpNO { get; set; }
    public string _EmpName { get; set; }

    public double _Salary { get; set; }

    public double _HRA { get; set; }

    public double _TA { get; set; }

    public double _DA { get; set; }

    public double _PF { get; set; }

    public double _TDS { get; set; }

    public double _NetSalary { get; set; }

    public double _GrossSalary { get; set; }
    public double Accepting(int _EmpNO, string _EmpName, double _Salary)
    {
        //Console.WriteLine("Employee No =" + this._EmpNO);
        //Console.WriteLine("Employee Name =" + this._EmpName);
        if (_Salary < 5000)
        {
            this._HRA = 10/100 * _Salary;
            this._TA = 5/100 * _Salary;
            this._DA = 15/100 * _Salary;

            this._GrossSalary = _Salary + this._HRA + this._TA + this._DA;
            Console.WriteLine("Gross Salary =" + this._GrossSalary);
        }

        else if (_Salary >= 5000 && _Salary < 10000)
        {
            this._HRA = 15/100 * _Salary;
            this._TA = 10/100 * _Salary;
            this._DA = 20/100 * _Salary;

            this._GrossSalary = _Salary + this._HRA + this._TA + this._DA;
            Console.WriteLine("Gross Salary =" + this._GrossSalary);
        }

        else if (_Salary >= 10000 && _Salary <15000)
        {
            this._HRA = 20/100 * _Salary;
            this._TA = 15/100 * _Salary;
            this._DA = 25/100 * _Salary;

            _GrossSalary = _Salary + this._HRA + this._TA + this._DA;
            Console.WriteLine("Gross Salary =" + this._GrossSalary);
        }
        else if (_Salary >= 15000 && _Salary < 20000)
        {
            this._HRA = 25/100 * _Salary;
            this._TA = 20/100 * _Salary;
            this._DA = 23/100 * _Salary;

            this._GrossSalary = _Salary + this._HRA + this._TA + this._DA;
            Console.WriteLine("Gross Salary =" + this._GrossSalary);
        }
        else if ( _Salary>=20000)
        {
            this._HRA = 30/100 * _Salary;
            this._TA = 25/100  * _Salary;
            this._DA = 35/100 * _Salary;

            this._GrossSalary = _Salary + this._HRA + this._TA + this._DA;
            Console.WriteLine("Gross Salary =" + this._GrossSalary);
        }
      
        return this._GrossSalary;
    }
    public void CalculateSalary()
    {
        this._PF = 0.10 * this._GrossSalary;
        this._TDS = 0.18 * this._GrossSalary;

        this._NetSalary = _GrossSalary - (_PF + _TDS);
        Console.WriteLine("NetSalary = " + _NetSalary);
    }
}

namespace EmployeeManagementSysstem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Employee();
            //p.insert();
            Console.WriteLine("Enter the EmployeeID");
            int EmpNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the EmployeeName");
            string EmpName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Salary");
            double Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("And this Employee's");
            p.Accepting(EmpNO, EmpName, Salary);
            p.CalculateSalary();

        }
    }
}