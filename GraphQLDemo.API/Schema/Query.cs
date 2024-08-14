using Bogus;

namespace GraphQLDemo.API.Schema;

public class Query
{
    private readonly Faker<InstructorType> _instructorFaker;
    private readonly Faker<StudentType> _studentFaker;
    private readonly Faker<CourseType> _courseFaker;
    public Query()
    {
        _instructorFaker = new Faker<InstructorType>()
            .RuleFor(i => i.Id, f => Guid.NewGuid())
            .RuleFor(i => i.FirstName, f => f.Name.FirstName())
            .RuleFor(i => i.LastName, f => f.Name.LastName())
            .RuleFor(i => i.Salary, f => f.Random.Double(0, 100000));

        _studentFaker = new Faker<StudentType>()
            .RuleFor(s => s.Id, f => Guid.NewGuid())
            .RuleFor(s => s.FirstName, f => f.Name.FirstName())
            .RuleFor(s => s.LastName, f => f.Name.LastName())
            .RuleFor(s => s.GPA, f => f.Random.Double(1, 4));

        _courseFaker = new Faker<CourseType>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.Name, f => f.Name.JobTitle())
            .RuleFor(c => c.Subject, f => f.PickRandom<Subject>())
            .RuleFor(c => c.Instructor, f => _instructorFaker.Generate())
            .RuleFor(c => c.Students, f => _studentFaker.Generate(2));
    }

    public IEnumerable<CourseType> GetCourses()
    {
        return _courseFaker.Generate(5);
    }

    public async Task<CourseType> GetCourseByIdAsync(Guid id)
    {
        await Task.Delay(1000);
        
        CourseType course = _courseFaker.Generate();
        course.Id = id;

        return course;
    }
    
    [GraphQLDeprecated("This Query is Depreceated.")]

    public string Instructions => "Smash the Code.";
}