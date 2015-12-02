namespace AlphanumericOz.Core.Models
{
    public class Road 
    {
        public string _name;

        public string Id { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }
}
