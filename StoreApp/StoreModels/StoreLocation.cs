using System;

namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customers location.
    /// </summary>
    public class StoreLocation
    {
        public string Name {get; set;}
        public string Address {get; set;}
        public string State {get; set;}
        public string City {get; set;}
        public int Zip {get; set;}
        public int? Id { get; set; }
        //TODO: add some property for the location inventory
    }
}