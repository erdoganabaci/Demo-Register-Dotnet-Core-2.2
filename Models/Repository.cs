using System.Collections.Generic;

namespace courseApp2.Models
{
    public static class Repository //bu static sınıf uygulama içinde sadece 1 tane olucak ve new ile yeni obje üretilmicek veri tabanı rolünü üstlenicek sanal veritabanı oluşturduk bir nevi ramde geçici saklancak
    {
        public static List<Student> _student = new List<Student>();

        public static List<Student> Students
        {   //student getir
            get
            {
                return _student;
            }
        }

        public static void AddStudent(Student student)
        {   //repository.AddStudent(student) student listeye ekle
            _student.Add(student);
        }


    }
}