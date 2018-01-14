﻿//Low Beam Headlight Bulb Size: 9006 or 9006 HID Upgrade Kit
//High Beam Headlamp Light Bulb Size: 9005 or 9005 HID Upgrade Kit
//Parking Light Bulb Size: 3157NALL
//Front Turn Signal Light Bulb Size: 3157NALL
//Rear Turn Signal Light Bulb Size: 3157LL
//Tail Light Bulb Size: 3157LL
//Stop Light Bulb Size: 3157LL
//High Mount Stop Light Bulb Size: 2825
//Fog/Driving Light Bulb Size: 9145
//License Plate Light Bulb Size: 168
//Back Up Light Bulb Size: 3156
//Map Light Bulb Size: 578
//Dome Light Bulb Size: 578
//Step/Courtesy Light Bulb Size: 168
//Trunk/Cargo Area Light Bulb Size: 578


namespace WebApplication1.Models
{
    public class LigthBulb
    {
        public int LigthBulbId { get; set; }
        public string Name { get; set; }

        public string Position { get; set; }
        public string BulbType { get; set; } //LED
        public int Voltage { get; set; } //"12";
        public int Wattage { get; set; } //	3 watts

        public string OEMPartNumber { get; set; }

        public string AmazonLink { get; set; }
    }
}