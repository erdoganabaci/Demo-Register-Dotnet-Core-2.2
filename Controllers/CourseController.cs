using System.Linq;
using courseApp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace courseApp2.Controllers
{
    public class CourseController : Controller
    {
        //action method uygulama 2 aşamadan oluşuyor controller = course ve action = methodlar ındex , list gibi
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        [HttpPost] //overload yaparak servera gelen parametereleri alıyoruz clientten requestten  public IActionResult Apply(string Name, string Email, string Phone, bool Confirm)
        public IActionResult Apply(Student student)
        {
            //validation kuralları düzgün formatta girmiş mi kontrol edilir.
            if (ModelState.IsValid)
            {
                //student olarak gelmesine Model Binding deniliyor
                Repository.AddStudent(student);
                //zaten apply [httpget] de view gösteriliyor tekrar html view göstermeye gerek yok ondan farklı viewe yani thans view gönderiyoruz ve viewdan gelen studentten haberi olsun
                return View("Thanks", student);
            }
            else
            {
                //validation geçmezse tekrar get gibi çalış sayfayı göster ve bilgileri tekrar kullanıcıya gönder
                return View(student);
            }

        }
        public IActionResult List()
        {
            //GELEN her studentin confirm alanı ture ise o zaman listelicez
            var students = Repository.Students.Where(i => i.Confirm == true);
            //sorgu ile gelecek öğrencileri student listesine attık
            return View(students);
        }
        public IActionResult Details()
        {
            //name:"Core Mvc Kursu"
            //description: "Kurs Güzel"
            //isPublished: true
            var course = new Course();
            course.Name = "Core 2 Mvc Kursu";
            course.description = "Kurs Güzeldir";
            course.isPublished = true;
            //view içine model atarken içine model objesini yazarız eğer belirli html sayfasına gitmesini istersen =  return View("MyView",course); default detail gider action function ismin neyse.
            return View(course);
        }

    }
}