using _2.gun_odev_3.Business.Concretes;
using _2.gun_odev_3.DataAccess.Concretes;

while (true)
{
	Console.WriteLine("1. Course Listele");
	Console.WriteLine("2. Category Listele");
	Console.WriteLine("3. Instructor Listele");
	Console.WriteLine("4. Çıkış");
	Console.Write("Seçiminizi yapın: ");
	string secim = Console.ReadLine();

	switch (secim)
	{
		case "1":
			ListCourses();
			break;
		case "2":
			ListCategories();
			break;
		case "3":
			ListInstructors();
			break;
		case "4":
			Console.WriteLine("Çıkış yapılıyor...");
			return;
		default:
			Console.WriteLine("Geçersiz seçim!");
			break;
	}
}


static void ListCourses()
{
	CourseManager courseManager = new CourseManager(new EfCourseDal());
	var courses = courseManager.GetAll();
	if (courses != null && courses.Count > 0)
	{
		Console.WriteLine("Courses:");
		foreach (var course in courses)
		{
			Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}, Description: {course.CourseDescription}, Category ID: {course.CategoryId}, Instructor ID: {course.InstructorId}");
		}
	}
	else
	{
		Console.WriteLine("Hiç kurs bulunamadı.");
	}
}

static void ListCategories()
{
	CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
	var categories = categoryManager.GetAll();
	if (categories != null && categories.Count > 0)
	{
		Console.WriteLine("Categories:");
		foreach (var category in categories)
		{
			Console.WriteLine($"Category ID: {category.CategoryId}, Name: {category.CategoryName}");
		}
	}
	else
	{
		Console.WriteLine("Hiç kategori bulunamadı.");
	}
}

static void ListInstructors()
{
	InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
	var instructors = instructorManager.GetAll();
	if (instructors != null && instructors.Count > 0)
	{
		Console.WriteLine("Instructors:");
		foreach (var instructor in instructors)
		{
			Console.WriteLine($"Instructor ID: {instructor.InstructorId}, Name: {instructor.FirstName} {instructor.LastName}");
		}
	}
	else
	{
		Console.WriteLine("Hiç eğitmen bulunamadı.");
	}
}