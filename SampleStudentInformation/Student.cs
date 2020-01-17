using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Formatting = Newtonsoft.Json.Formatting;

namespace CourseWork
{
    public class Student
    {
        private string _filePath = "student.json";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string CourseEnrolled { get; set; }
        public string Status { get; set; }

        public void Add(Student info)
        {
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);

        }
        public Student Edit(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public void Edit(Student info)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //adding the updated student object to the list
            list.Add(info);
            //converting list of student to string
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToTextFile(_filePath, data, false);
        }
        public void Delete(int id)
        {

            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //converting list of student to string
            int count = list.Count;
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToTextFile(_filePath, data, false, count);

        }
        public Student Detail(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public List<Student> List()
        {
            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(d);
                return lst;
            }
            return null;
        }


    }
}
