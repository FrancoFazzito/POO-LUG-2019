using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace advance_func
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "hola", "como", "estas", "todo", "bien", "prueba" };
            words.Where(FilterWord("como")).ToList().ForEach(print);
            
            
            List<Item> items = new List<Item>()
            {
                new Item(){ Id = 1, Name = "Adam" },
                new Item(){ Id = 2, Name = "Billy" },
                new Item(){ Id = 3, Name = "jhino" },
                new Item(){ Id = 4, Name = "franco" },
                new Item(){ Id = 5, Name = "ian" },
                new Item(){ Id = 6, Name = "pato" },
                new Item(){ Id = 7, Name = "kati" },
                new Item(){ Id = 8, Name = "flor" },
                new Item(){ Id = 9, Name = "thomas" }
            };

            //lambda parameters
            IEnumerable<Item> enumerableFilter = Filter(items, p => p.Id % 2 == 0);
            foreach (var item in enumerableFilter)
            {
                Console.WriteLine(item.ToString());
            }
            
            Thread.Sleep(2000);
        }

        static Func<string, bool> FilterWord(string word)
        {
            Func<string, bool> predicate = (find) => find.Equals(word);
            return predicate;
        }

        static IEnumerable<Item> Filter(IEnumerable<Item> items, Func<Item,bool> condition)
        {
            return items.Where(condition);
        }

        static void print(object s)
        {
            Console.WriteLine(s.ToString());
        }
    }

    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("name: {0} id: {1}", Name, Id);
        }
    }
}
