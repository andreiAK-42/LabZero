using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LabZero
{
    public class User
    {
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public User(string lastName, string city, int age)
        {
            LastName = lastName;
            City = city;
            Age = age;
        }
    }

    public class BaseData
    {
        public User[] Users { get; set; }

        public BaseData() { }

        public BaseData(List<User> users)
        {
            Users = users.ToArray();
        }

        public BaseData? GetFromFile(string filePath)
        {
            string jsonFromFile = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<BaseData>(jsonFromFile);
        }

        public static bool SaveData(BaseData baseData, string filePath)
        {
            try
            {
                var json = JsonConvert.SerializeObject(baseData, Formatting.Indented);

                File.WriteAllText(filePath, json);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
