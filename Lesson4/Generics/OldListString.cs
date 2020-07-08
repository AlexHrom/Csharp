namespace Generics
{
    public class OldListString
    {
        private ListEntity first;

        public OldListString()
        {

        }

        public void Add(string data)
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

        public string First()
        {
            return first?.Data ?? "42";
        }

        private class ListEntity
        {
            public ListEntity Next { get; set; }
            public string Data { get; set; }
        }
    }
}
