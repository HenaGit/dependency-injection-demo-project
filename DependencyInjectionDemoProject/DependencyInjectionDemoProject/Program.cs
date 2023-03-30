﻿using System;

namespace DependencyInjectionDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class UserInterface
    {
        public void GetData()
        {
            Console.Write("Enter your username:");
            var userName = Console.ReadLine();

            Console.Write("Enter your password");
            var password = Console.ReadLine();
            IBusiness business = new Business();
            business.SignUp(userName, password);
        }
    }
    public class Business: IBusiness
    {
        public void SignUp(string userName, string password)
        {
            // validation
            var dataAccess = new DataAccess();
            dataAccess.Store(userName, password);
        }
    }
    public class BusinessV2 : IBusiness
    {
        public void SignUp(string userName, string password)
        {
            // validation
            var dataAccess = new DataAccess();
            dataAccess.Store(userName, password);
        }
    }
    public class DataAccess:IDataAccess
    {
        public void Store(string userName, string password)
        {
            // write the data to the db
        }
    }
    public interface IBusiness
    {
        void SignUp(string userName, string password);
    }
    public interface IDataAccess
    {
        void Store(string userName, string password);
    }
}
