namespace ConsoleApp.LINQ
{
    public class RowsToConlumnsAndColumnsToRows
    {
        public static void TransformData()
        {
            List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name = "John", Age = 25 },
                new Person { Id = 2, Name = "Jane", Age = 30 },
                new Person { Id = 3, Name = "Bob", Age = 22 }
            };

            Console.WriteLine("\nDanh sach ban dau");
            foreach(var item in people)
            {
                Console.WriteLine($"{string.Join(" | ", item.Id, item.Name, item.Age)}");
            }

            var rowsToColumns = new Dictionary<string, List<object>>();

            foreach (var person in people)
            {
                foreach(var property in person.GetType().GetProperties())
                {
                    var propertyName = property.Name;
                    var propertyValue = property.GetValue(person);

                    if (!rowsToColumns.ContainsKey(propertyName))
                    {
                        rowsToColumns[propertyName] = new List<object>();
                    }

                    rowsToColumns[propertyName].Add(propertyValue!);
                }
            }

            // In kết quả
            Console.WriteLine("\nBien hang thanh cot:");
            foreach (var kvp in rowsToColumns)
            {
                Console.WriteLine($"{string.Join(" | ", kvp.Value)}");
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
