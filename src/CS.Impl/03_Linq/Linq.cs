using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS.Impl._03_Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {

            IEnumerable<String> result = from word in strings
                                         where word.StartsWith(startCharacter) && word.EndsWith(endCharacter)
                                         select word;
            return result;
        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
            IEnumerable<int> result = from number in numbers
                                      where number > limit
                                      select number;
            return result;
        }

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
            IEnumerable<int> result = (from number in numbers
                                 orderby number descending
                                 select number).Take(limit);
            return result;
        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            var result = files.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                .GroupBy(group => group,
                (extension, extensionCount) => new { Extension = extension, Count = extension.Count() });
            return result.ToDictionary(d => d.Extension, d => d.Count);
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            return from purchase in purchases
                   join client in clients on purchase.ClientId equals client.Id
                   join item in items on purchase.ItemId equals item.Id
                   select new Tuple<string, string, int, double>(client.Name, item.Label, purchase.Quantity, item.Price);
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
