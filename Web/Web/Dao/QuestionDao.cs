using System.Collections;
using System.Collections.Generic;
using Web.Domain;

namespace Web.Dao
{
    public class QuestionDao
    {
        public IEnumerable<Question> getAll 
        { 
            get
            {
                return new List<Question>()
                {
                    new Question("Якому простору імен належить веб-сторінка в ієрархії класів .NET Framework?", new List<Answear>()
                    {
                        new Answear("System.Web.Control",false),
                        new Answear("System.Web.RootBuilder",true),
                        new Answear("System.Web.UserControl ",false),
                        new Answear("System.Web/UiPage",false),
                    }),
                    new Question("На якій  пишуть код для ASP.NET ", new List<Answear>()
                    {
                        new Answear("JS",false),
                        new Answear("Pascal",false),
                        new Answear("java",false),
                        new Answear("С#",true),
                    }),
                    new Question("За замовчуванням ASP.NET зберігає ідентифікатор сеансів у", new List<Answear>()
                    {
                        new Answear("Не зберігає",false),
                        new Answear("Cookies",false),
                        new Answear("БД",false),
                        new Answear("Кеш",true),
                    }),
                    new Question("ASP.NET - це", new List<Answear>()
                    {
                        new Answear("платформа для створення веб-додатків і веб-сервісів, що працюють під управлінням IIS",true),
                        new Answear("мова програмуваня",false),
                        new Answear("веб-застосунок",false),
                        new Answear("база даних",false),
                    }),
                     new Question("При Windows аутентифікації ASP.NET автоматично приєднується ...", new List<Answear>()
                    {
                        new Answear("FileAuthorizationModule",false),
                        new Answear("WindowsPrincipal об'єкт",true),
                        new Answear("UrlAuthorizationModule ",false),
                        new Answear("база даних",false),
                    }),
                     new Question("Файл Web.config використовується для ", new List<Answear>()
                    {
                        new Answear("Налаштування веб-браузера",false),
                        new Answear("Налаштування веб-сервера",false),
                        new Answear("Налаштування часу виклику серверного модуля коду",false),
                        new Answear("Зберігання інформації та визначення змінних для програми",true),
                    }),
                     new Question("Як називається початковий проект?", new List<Answear>()
                    {
                        new Answear("XSS",false),
                        new Answear("XSP",true),
                        new Answear("XST",false),
                        new Answear("XSL",false),
                    }),
                     new Question("Який основний елемент веб-програми?", new List<Answear>()
                    {
                        new Answear("XML файл",false),
                        new Answear("windows Form",false),
                        new Answear("немає основного елементу",false),
                        new Answear("Web-форма",true),
                    }),
					
					new Question("Microsoft повністю перебудувала ASP.NET, ґрунтуючись на", new List<Answear>()
                    {
                        new Answear("C# Runtime",false),
                        new Answear("ASP.NET Language Runtime",false),
                        new Answear("Common ASP.NET",false),
                        new Answear("Common Language Runtime",true),
                    }),
					new Question("Який з об'єктів інкапсулює стан клієнта та браузера?", new List<Answear>()
                    {
                        new Answear("Об'єкт запиту",true),
                        new Answear("Об'єкт серверу",false),
                        new Answear("Об'єкт відповіді",false),
                        new Answear("Об'єкт сесії",false),
                    })
					
					
                };
            }
        } 
    }
}
