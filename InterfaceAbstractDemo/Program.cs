﻿using System;
using System.Reflection.Emit;
using System.Threading.Channels;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1986,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108"});
            Console.ReadLine();
        }
    }
}
