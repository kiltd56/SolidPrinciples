﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class Staff : Employee, IEntitlement
    {
        public decimal CalculateBonuses()
        {
           return Salary= Salary * 0.05m;
        }
        public decimal CalculateHealthInsurance() => 3000;

        public decimal CalculatePension() => .025m * Salary;

        public decimal CalculateRentalSubsidy() => 150;

        public decimal CalculateTransportationReimbursement()=>
            throw new NotSupportedException("Staff TransportationReimbursement");

        protected override decimal CalculateNetSalary()
        {
            return Salary + CalculateBonuses() + CalculateHealthInsurance() + CalculatePension() + CalculateRentalSubsidy();
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Staff)} ---" +
                   $"\n  No.: {EmployeeNo}" +
                   $"\n  Name: {Name}" +
                   $"\n  Basic Salary: {Salary.ToString("C2")}" +
                   $"\n  Bonuses: {CalculateBonuses().ToString("C2")}" +
                   $"\n  Pension: {CalculatePension().ToString("C2")}" +
                   $"\n  Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                   $"\n  Rental Subsidy: {CalculateRentalSubsidy().ToString("C2")}" +
                   $"\n  ----------------------------------------------" +
                   $"\n  NetSalary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}
