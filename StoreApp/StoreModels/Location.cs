using System;

namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customers location.
    /// </summary>
    public class Location
    {
        public string Address {get; set;}
        public string StateName {get; set;}
        public string CityName {get; set;}
        public string Zip {get; set;}
        //TODO: add some property for the location inventory
    }
}