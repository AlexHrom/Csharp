namespace Generics
{
    public class OldList
    {
        private ListEntity first;

        public OldList()
        {

        }

        public void Add(int data)
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

        public int? First()
        {
            return first?.Data;
        }

        private class ListEntity
        {
            public ListEntity Next { get; set; }
            public int Data { get; set; }
        }
    }
}
