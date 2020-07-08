using System;

namespace Delegates
{
    class Updater
    {
        public Updater()
        {

        }

        public T Apply<T>(T entity, Action<T> patch) where T : IEntity
        {
            patch(entity);
            entity.UpdatedAt = DateTimeOffset.UtcNow;

            return entity;
        }
    }
}
