namespace StudentManagement.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>() { 
            new Student { Id = 113, Name = "Harish", Address = "Hubli, KA", Email = "harish@gmail.com" },
            new Student { Id = 114, Name = "Geeta", Address = "Hubli, KA", Email = "geeta@gmail.com" }, 
            new Student { Id = 115 } 
        };
    }
}
