namespace Generics
{
    //public class NewList<TEntity, TOne, TTwo> //where TEntity : class
    public class NewList<TEntity> //where TEntity : class
    {
        private ListEntity first;

        public NewList()
        {

        }

        public void Add(TEntity data)
        {
            var element = new ListEntity()
            {
                Next = first,
                Data = data
            };
            //var element = new ListEntity();
            //element.Next = first;
            //element.Data = data;

            first = element;
        }

        public TEntity First()
        {
            if (null == first)
            {
                return default;
            }

            return first.Data;
        }

        private class ListEntity
        {
            public ListEntity Next { get; set; }
            public TEntity Data { get; set; }
        }
    }
}
