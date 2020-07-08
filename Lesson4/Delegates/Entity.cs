using System;

namespace Delegates
{
    public class Entity : IEntity
    {
        public string Name { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
