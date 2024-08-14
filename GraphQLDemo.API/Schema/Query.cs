using Bogus;

namespace GraphQLDemo.API.Schema;

public class Query
{
    public IEnumerable<CourseType> GetCourses()
    {
        Faker<InstructorType> instructorFaker = new Faker<InstructorType>()
            .RuleFor(i => i.Id, f => Guid.NewGuid())
            .RuleFor(i => i.FirstName, f => f.Name.FirstName())
            .RuleFor(i => i.LastName, f => f.Name.LastName())
            .RuleFor(i => i.Salary, f => f.Random.Double(0, 100000));

        Faker<StudentType> studentFaker = new Faker<StudentType>()
            .RuleFor(s => s.Id, f => Guid.NewGuid())
            .RuleFor(s => s.FirstName, f => f.Name.FirstName())
            .RuleFor(s => s.LastName, f => f.Name.LastName())
            .RuleFor(s => s.GPA, f => f.Random.Double(1, 4));

        Faker<CourseType> courseFaker = new Faker<CourseType>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.Name, f => f.Name.JobTitle())
            .RuleFor(c => c.Subject, f => f.PickRandom<Subject>())
            .RuleFor(c => c.Instructor, f => instructorFaker.Generate())
            .RuleFor(c => c.Students, f => studentFaker.Generate(2));

        List<CourseType> courses = courseFaker.Generate(5);
        return courses;
    }
}