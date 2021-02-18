namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a store location.
    /// </summary>
    public class Location
    {
        public string Address { get; set; }
        public string StateName { get; set; }
        //TODO: add some property for the location inventory
        public string CityName { get; set; }
        public int Zip { get; set; }
    }
}