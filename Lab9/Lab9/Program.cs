using Lab9.Classes;
using Lab9.Interfaces;
using System;
using System.Collections.Generic;


namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем фабрики для каждой компании
            var factories = new List<BuildingCompanyFactory>
        {
            new BrickWallsCompanyFactory(),
            new FoamBlocksCompanyFactory(),
            new MonolithicWallsCompanyFactory()
        };

            // Используем фабрики для создания компаний
            var companies = new List<IBuildingCompany>
        {
            factories[0].CreateCompany("BrickMaster", CompanyType.Organization),
            factories[1].CreateCompany("FoamBuild", CompanyType.IndividualEntrepreneur),
            factories[2].CreateCompany("MonoConstruct", CompanyType.PrivatePerson)
        };

            // Вызываем все методы для каждого элемента коллекции
            foreach (var company in companies)
            {
                company.GetInfo();
                company.BuildWalls();

                if (company is IMaterialSupplier supplier)
                {
                    supplier.SupplyMaterials();
                }

                if (company is IProjectDeveloper developer)
                {
                    developer.DevelopProject();
                }

                if (company is ICustomerConsultant consultant)
                {
                    consultant.ConsultCustomer();
                }

                Console.WriteLine(); // Отделяем вывод для каждой компании
            }
        }
    }
}
