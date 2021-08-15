using System;

namespace ODataWebService.Models
{
    public record Student
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }
}