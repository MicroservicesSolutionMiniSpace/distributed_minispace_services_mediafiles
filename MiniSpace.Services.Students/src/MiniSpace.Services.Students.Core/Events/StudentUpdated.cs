using MiniSpace.Services.Students.Core.Entities;
using System.Diagnostics.CodeAnalysis;

namespace MiniSpace.Services.Students.Core.Events
{
    [ExcludeFromCodeCoverage]
    public class StudentUpdated : IDomainEvent
    {
        public Student Student { get; }

        public StudentUpdated(Student student)
        {
            Student = student;
        }
    }    
}
