using System;
using System.Runtime.Serialization;

namespace Caiti.Models
{
    [Serializable]
    internal class CourseConflictException : Exception
    {
        public Course incomingCourse { get; }
        public Course existingCourse { get; }

        public CourseConflictException(Course incomingCourse, Course existingCourse)
        {
            this.incomingCourse = incomingCourse;
            this.existingCourse = existingCourse;
        }

        public CourseConflictException(string message) : base(message)
        {
        }

        public CourseConflictException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CourseConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}