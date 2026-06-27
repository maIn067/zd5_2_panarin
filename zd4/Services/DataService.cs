using System.Collections.Generic;
using zd4.Models;

namespace zd4.Services
{
    public static class DataService
    {
        public static List<ListItem> GetListItems()
        {
            return new List<ListItem>
            {
                new ListItem { Title = "Select One",   Description = "первый вариант выбора" },
                new ListItem { Title = "Select Two",   Description = "второй вариант выбора" },
                new ListItem { Title = "Select Three", Description = "третий вариант выбора" },
                new ListItem { Title = "Select Four",  Description = "четвёртый вариант выбора" }
            };
        }
    }
}
