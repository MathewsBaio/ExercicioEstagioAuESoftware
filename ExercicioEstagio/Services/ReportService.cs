using ExercicioEstagio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioEstagio.Repositories;
using System.Windows.Forms;

namespace ExercicioEstagio.Services
{
    internal class ReportService
    {
        private ContactRepo repo = new ContactRepo();
        public async Task<string> GetContactsReport()
        {
            StringBuilder report = new StringBuilder();
            List<string> months = new List<string> { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            List<Contact> contacts = await repo.GetAllContactsAsync();
            Dictionary<GenderEnum, int> contactsDic = GetTotalContacts(contacts);
            int totalContactsMale = contactsDic[GenderEnum.Masculino];
            int totalContactsFemale = contactsDic[GenderEnum.Feminino];
            int totalContacts = totalContactsMale + totalContactsFemale;
            List<string> cities = GetCitiesList(contacts);

            
            const int cityWidth = 20; 
            const int monthWidth = 10; 
            const int numberWidth = 2; 

            
            report.AppendLine(new string('=', 60));
            report.AppendLine("Relatório de Contatos por Cidade e Mês".PadLeft(30 + 30 / 2)); 
            report.AppendLine(new string('=', 60));
            report.AppendLine();
            report.AppendLine(new string('-', 60));
            report.AppendLine($"{"Total de contatos:",-10} {totalContacts.ToString().PadLeft(numberWidth)} | {"Homens:",-5} {totalContactsMale.ToString().PadLeft(numberWidth)} | {"Mulheres:",-5} {totalContactsFemale.ToString().PadLeft(numberWidth)}");
            report.AppendLine(new string('-', 60));
            report.AppendLine();

            
            foreach (var city in cities)
            {
                int totalContactsCity = 0;
                report.AppendLine(new string('=', 60));
                report.AppendLine($"{"Cidade:",-5} {city.PadRight(cityWidth)}");
                report.AppendLine(new string('-', 60));

                for (int i = 0; i < months.Count; i++)
                {
                    Dictionary<GenderEnum, int> contactsCityMonthDic = GetTotalContactsByCityByMonth(contacts, city, i + 1);
                    int totalMaleMonth = contactsCityMonthDic[GenderEnum.Masculino];
                    int totalFemaleMonth = contactsCityMonthDic[GenderEnum.Feminino];
                    int totalContactsMonth = totalMaleMonth + totalFemaleMonth;

                    if (totalContactsMonth > 0)
                    {
                        report.AppendLine($"{months[i].PadRight(monthWidth)} | {"Total:",-8} {totalContactsMonth.ToString().PadLeft(numberWidth)} | {"Homens:",-8} {totalMaleMonth.ToString().PadLeft(numberWidth)} | {"Mulheres:",-8} {totalFemaleMonth.ToString().PadLeft(numberWidth)}");
                        totalContactsCity += totalContactsMonth;
                    }
                }

                report.AppendLine(new string('-', 60));
                report.AppendLine($"{"Total na Cidade:",-10} {totalContactsCity.ToString().PadLeft(numberWidth)}");
                report.AppendLine(new string('-', 60));
                report.AppendLine();
            }

            return report.ToString();
        }

        private List<string> GetCitiesList(List<Contact> contacts)
        {
            
            List<string> cities = contacts
                            .Select(c => c.City.ToUpperInvariant())
                            .Distinct()
                            .OrderBy(c => c)
                            .ToList();
            
            return cities;
        }

        // O método abaixo irá retornar o total de homens e mulheres de uma cidade em um mês específico, utilizando
        // LINQ para filtragem dos dados e a estrutura de dicionário para retornar dados esperados.
        private Dictionary<GenderEnum, int> GetTotalContactsByCityByMonth(List<Contact> contacts, string city, int month)
        {
            
            var cityContacts = contacts
                .Where(contact => contact.City.Equals(city, StringComparison.OrdinalIgnoreCase) &&
                contact.RegisterDate.Month == month);

            return new Dictionary<GenderEnum, int>
            {
                [GenderEnum.Masculino] = cityContacts.Count(contact => contact.Gender == GenderEnum.Masculino),
                [GenderEnum.Feminino] = cityContacts.Count(contact => contact.Gender == GenderEnum.Feminino)
            };

        }

        private Dictionary<GenderEnum, int> GetTotalContacts(List<Contact> contacts)
        {
            return new Dictionary<GenderEnum, int>
            {
                [GenderEnum.Masculino] = contacts.Count(contact => contact.Gender == GenderEnum.Masculino),
                [GenderEnum.Feminino] = contacts.Count(contact => contact.Gender == GenderEnum.Feminino)
            };
        }

    }
}
