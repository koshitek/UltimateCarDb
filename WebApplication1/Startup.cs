﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using WebApplication1.DatabaseContext;
using WebApplication1.Models;


[assembly: OwinStartup(typeof(WebApplication1.Startup))]

namespace WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            SeedLigthBulbPosition();
            SeedLigthBulbGeneric();
            SeedProductionYears();
            SeedManufacturers();
            SeedModels();
            SeedTrims();
            SeedVehicles();
            SampleQueryTest();
        }
        void SampleQueryTest()
        {
            //https://coding.abel.nu/2012/06/dont-use-linqs-join-navigate/
            using (var db = new VehicleDBContext())
            {
                var allLightbulbs = from l in db.Vehicles
                                    where (
                                        l.ProductionYear.Name == "2003"
                                        && l.Manufacturer.Name == "FORD"
                                        && l.Model.Name == "Explorer"
                                        && l.Trim.Name == "Eddie Bauer")
                                    select new
                                    {
                                        l.LigthBulbCarSpecific
                                    };
                foreach (var item in allLightbulbs)
                {
                    var fdasfda = item.LigthBulbCarSpecific.Count();
                }
            }
        }
        void SeedProductionYears()
        {
            using (var db = new VehicleDBContext())
            {
                if (db.ProductionYears.Count() > 0)
                    return;
                db.ProductionYears.Add(new ProductionYear { Name = "1990" });
                db.ProductionYears.Add(new ProductionYear { Name = "1991" });
                db.ProductionYears.Add(new ProductionYear { Name = "1992" });
                db.ProductionYears.Add(new ProductionYear { Name = "1993" });
                db.ProductionYears.Add(new ProductionYear { Name = "1994" });
                db.ProductionYears.Add(new ProductionYear { Name = "1995" });
                db.ProductionYears.Add(new ProductionYear { Name = "1996" });
                db.ProductionYears.Add(new ProductionYear { Name = "1997" });
                db.ProductionYears.Add(new ProductionYear { Name = "1998" });
                db.ProductionYears.Add(new ProductionYear { Name = "1999" });
                db.ProductionYears.Add(new ProductionYear { Name = "2000" });
                db.ProductionYears.Add(new ProductionYear { Name = "2001" });
                db.ProductionYears.Add(new ProductionYear { Name = "2002" });
                db.ProductionYears.Add(new ProductionYear { Name = "2003" });
                db.ProductionYears.Add(new ProductionYear { Name = "2004" });
                db.ProductionYears.Add(new ProductionYear { Name = "2005" });
                db.ProductionYears.Add(new ProductionYear { Name = "2006" });
                db.ProductionYears.Add(new ProductionYear { Name = "2007" });
                db.ProductionYears.Add(new ProductionYear { Name = "2008" });
                db.ProductionYears.Add(new ProductionYear { Name = "2009" });
                db.ProductionYears.Add(new ProductionYear { Name = "2010" });
                db.ProductionYears.Add(new ProductionYear { Name = "2011" });
                db.ProductionYears.Add(new ProductionYear { Name = "2012" });
                db.ProductionYears.Add(new ProductionYear { Name = "2013" });
                db.ProductionYears.Add(new ProductionYear { Name = "2014" });
                db.ProductionYears.Add(new ProductionYear { Name = "2015" });
                db.ProductionYears.Add(new ProductionYear { Name = "2016" });
                db.ProductionYears.Add(new ProductionYear { Name = "2017" });
                db.ProductionYears.Add(new ProductionYear { Name = "2018" });
                db.SaveChanges();
            }
        }
        void SeedManufacturers()
        {
            using (var db = new VehicleDBContext())
            {
                if (db.Manufacturers.Count() > 0)
                    return;

                //db.Manufacturers.Add(new Manufacturer { Name = "ABARTH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AC" });
                db.Manufacturers.Add(new Manufacturer { Name = "ACURA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ALFA ROMEO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ALLARD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ALLSTATE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ALPINE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ALVIS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AM GENERAL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AMERICAN AUSTIN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AMERICAN BANTAM" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AMERICAN MOTORS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AMPHICAR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "APOLLO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ARMSTRONG-SIDDELEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ARNOLT-BRISTOL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ARNOLT-MG" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ASTON MARTIN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ASUNA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AUBURN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AUDI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AUSTIN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AUSTIN-HEALEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "AVANTI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BENTLEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BERKELEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BIZZARRINI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BMW" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BOND" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BORGWARD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BRICKLIN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BRISTOL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BUGATTI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "BUICK" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CADILLAC" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CASE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CHANDLER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CHECKER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CHEVROLET" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CHRYSLER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CISITALIA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CITROEN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CODA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "COLE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CORD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CROSLEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "CUNNINGHAM" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DAEWOO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DAF" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DAIHATSU" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DAIMLER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DELAHAYE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DELLOW" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DELOREAN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DENZEL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DESOTO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DETOMASO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DEUTSCH-BONNET" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DIANA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DKW" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DODGE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DU PONT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DUAL-GHIA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DUESENBERG" });
                //db.Manufacturers.Add(new Manufacturer { Name = "DURANT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "EAGLE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "EDSEL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ELCAR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ELVA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ERSKINE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ESSEX" });
                //db.Manufacturers.Add(new Manufacturer { Name = "EXCALIBUR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FACEL VEGA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FAIRTHORPE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FALCON KNIGHT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FARGO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FERRARI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FIAT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FISKER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FLINT" });
                db.Manufacturers.Add(new Manufacturer { Name = "FORD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FRANKLIN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FRAZER NASH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "FREIGHTLINER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GARDNER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GENESIS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GEO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GLAS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GMC" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GOLIATH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GORDON-KEEBLE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GRAHAM" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GRAHAM-PAIGE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "GRIFFITH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HEALEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HENRY J" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HILLMAN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HINO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HONDA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HOTCHKISS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HRG" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HUDSON" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HUMBER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HUMMER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HUPMOBILE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "HYUNDAI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "INFINITI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "INTERNATIONAL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ISO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ISUZU" });
                //db.Manufacturers.Add(new Manufacturer { Name = "IVECO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "JAGUAR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "JEEP" });
                //db.Manufacturers.Add(new Manufacturer { Name = "JENSEN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "JEWETT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "JORDAN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "JOWETT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "KAISER-FRAZER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "KENWORTH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "KIA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "KISSEL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "KURTIS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LADA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LAFORZA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LAMBORGHINI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LANCHESTER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LANCIA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LAND ROVER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LASALLE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LEA-FRANCIS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LEXINGTON" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LEXUS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LINCOLN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "LOTUS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MACK" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MAICO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MARCOS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MARMON" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MASERATI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MATRA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MAXWELL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MAYBACH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MAZDA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MCLAREN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MERCEDES-BENZ" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MERCURY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MERKUR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MESSERSCHMITT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MG" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MINI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MITSUBISHI FUSO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MITSUBISHI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MOBILITY VENTURES" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MONTEVERDI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MOON" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MORETTI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MORGAN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MORRIS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "MOSKVICH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "NARDI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "NASH" });
                db.Manufacturers.Add(new Manufacturer { Name = "NISSAN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "NSU" });
                //db.Manufacturers.Add(new Manufacturer { Name = "OAKLAND" });
                //db.Manufacturers.Add(new Manufacturer { Name = "OLDSMOBILE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "OMEGA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "OPEL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "OSCA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PACKARD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PAIGE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PANHARD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PANOZ" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PANTHER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PASSPORT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PEERLESS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PETERBILT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PEUGEOT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PIERCE-ARROW" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PLYMOUTH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PONTIAC" });
                //db.Manufacturers.Add(new Manufacturer { Name = "PORSCHE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "QVALE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "RAM" });
                //db.Manufacturers.Add(new Manufacturer { Name = "RELIANT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "RENAULT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "REO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "RICKENBACKER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "RILEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ROAMER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ROCKNE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ROLLS-ROYCE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ROVER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SAAB" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SABRA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SALEEN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SALMSON" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SATURN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SCION" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SHELBY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SIATA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SIMCA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SINGER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SKODA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SMART" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SRT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "STANDARD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "STAR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "STEARNS KNIGHT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "STERLING" });
                //db.Manufacturers.Add(new Manufacturer { Name = "STEVENS-DURYEA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "STUDEBAKER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "STUTZ" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SUBARU" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SUNBEAM" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SUZUKI" });
                //db.Manufacturers.Add(new Manufacturer { Name = "SWALLOW" });
                //db.Manufacturers.Add(new Manufacturer { Name = "TATRA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "TESLA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "THINK" });
                //db.Manufacturers.Add(new Manufacturer { Name = "TOYOTA" });
                //db.Manufacturers.Add(new Manufacturer { Name = "TRIUMPH" });
                //db.Manufacturers.Add(new Manufacturer { Name = "TURNER" });
                //db.Manufacturers.Add(new Manufacturer { Name = "TVR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "UD" });
                //db.Manufacturers.Add(new Manufacturer { Name = "VAUXHALL" });
                //db.Manufacturers.Add(new Manufacturer { Name = "VESPA" });
                db.Manufacturers.Add(new Manufacturer { Name = "VOLKSWAGEN" });
                //db.Manufacturers.Add(new Manufacturer { Name = "VOLVO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "VPG" });
                //db.Manufacturers.Add(new Manufacturer { Name = "WARTBURG" });
                //db.Manufacturers.Add(new Manufacturer { Name = "WESTCOTT" });
                //db.Manufacturers.Add(new Manufacturer { Name = "WHIPPET" });
                //db.Manufacturers.Add(new Manufacturer { Name = "WILLYS" });
                //db.Manufacturers.Add(new Manufacturer { Name = "WINDSOR" });
                //db.Manufacturers.Add(new Manufacturer { Name = "WOLSELEY" });
                //db.Manufacturers.Add(new Manufacturer { Name = "WORKHORSE" });
                //db.Manufacturers.Add(new Manufacturer { Name = "YELLOW CAB" });
                //db.Manufacturers.Add(new Manufacturer { Name = "YUGO" });
                //db.Manufacturers.Add(new Manufacturer { Name = "ZUNDAPP" });
                db.SaveChanges();
            }
        }
        private void SeedModels()
        {
            using (var db = new VehicleDBContext())
            {
                if (db.Models.Count() > 0)
                    return;
                db.Models.Add(new Model { Name = "Explorer" });
                db.Models.Add(new Model { Name = "Taurus" });
                db.Models.Add(new Model { Name = "Focus" });
                db.Models.Add(new Model { Name = "TL" });
                db.Models.Add(new Model { Name = "GTI" });
                db.SaveChanges();
            }
        }
        private void SeedTrims()
        {
            using (var db = new VehicleDBContext())
            {
                if (db.Trims.Count() > 0)
                    return;
                db.Trims.Add(new Trim { Name = "Eddie Bauer" });
                db.Trims.Add(new Trim { Name = "XLT" });
                db.Trims.Add(new Trim { Name = "SportTrac" });
                db.Trims.Add(new Trim { Name = "Limited" });
                db.Trims.Add(new Trim { Name = "1.8T" });
                db.Trims.Add(new Trim { Name = "3.2 V6" });
                db.SaveChanges();
            }
        }
        private void SeedLigthBulbPosition()
        {
            using (var db = new VehicleDBContext())
            {
                if (db.LigthBulbPosition.Count() > 0)
                    return;
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Low Beam Headlight" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "High Beam Headlamp Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Parking Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Front Turn Signal Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Rear Turn Signal Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Tail Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Stop Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "High Mount Stop Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Fog / Driving Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "License Plate Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Back Up Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Map Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Dome Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Step / Courtesy Light" });
                db.LigthBulbPosition.Add(new LigthBulbPosition { Name = "Trunk / Cargo Area Light" });
                db.SaveChanges();
            }
        }
        private void SeedLigthBulbGeneric()
        {
            using (var db = new VehicleDBContext())
            {
                if (db.LightbulbGeneric.Count() > 0)
                    return;
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "168", FilamentType = "LED", AmazonLink = ""});
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "578", FilamentType = "LED", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "2825", FilamentType = "LED", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "3156", FilamentType = "LED", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "3157LL", FilamentType = "LED", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "3157NALL", FilamentType = "LED", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "9006", FilamentType = "HALOGEN", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "9006", FilamentType = "LED", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "9006", FilamentType = "HID", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "9005", FilamentType = "HALOGEN", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "9005", FilamentType = "LED", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "9005", FilamentType = "HID", AmazonLink = "" });
                db.LightbulbGeneric.Add(new LightbulbGeneric { Size = "9145", FilamentType = "LED", AmazonLink = "" });
                db.SaveChanges();
            }
        }
        void SeedVehicles()
        {
            using (var db = new VehicleDBContext())
            {
                if (db.Vehicles.Count() > 0)
                    return;

                db.Vehicles.Add(new Vehicle
                {
                    Manufacturer = db.Manufacturers.First(x => x.Name == "Ford"),
                    ProductionYear = db.ProductionYears.First(x => x.Name == "2003"),
                    Model = db.Models.First(x => x.Name == "Explorer"),
                    Trim = db.Trims.First(x => x.Name == "Eddie Bauer"),
                    LigthBulbCarSpecific = new List<LigthBulbCarSpecific> {
                        new LigthBulbCarSpecific {
                            ligthBulbPositionId =db.LigthBulbPosition.First(x => x.Name.Contains("Low Beam Headlight")),
                            oemPartNumber = "123=2234=33",
                            LightbulbGenerics = new List<LightbulbGeneric> {
                                db.LightbulbGeneric.First(x => x.Size == "9006" && x.FilamentType == "LED"),
                                db.LightbulbGeneric.First(x => x.Size == "9006" && x.FilamentType == "HID"),
                                db.LightbulbGeneric.First(x => x.Size == "9006" && x.FilamentType == "HALOGEN"),
                            }
                        },
                        new LigthBulbCarSpecific {
                            ligthBulbPositionId =db.LigthBulbPosition.First(x => x.Name.Contains("High Beam Headlamp Light")),
                            oemPartNumber = "123=2234=33",
                            LightbulbGenerics = new List<LightbulbGeneric> {
                                db.LightbulbGeneric.First(x => x.Size == "9005" && x.FilamentType == "LED"),
                                db.LightbulbGeneric.First(x => x.Size == "9005" && x.FilamentType == "HID"),
                                db.LightbulbGeneric.First(x => x.Size == "9005" && x.FilamentType == "HALOGEN"),
                            }
                        },
                        new LigthBulbCarSpecific {
                            ligthBulbPositionId =db.LigthBulbPosition.First(x => x.Name.Contains("License Plate Light")),
                            oemPartNumber = "123=2234=33",
                            LightbulbGenerics = new List<LightbulbGeneric> {
                                db.LightbulbGeneric.First(x => x.Size == "168" && x.FilamentType == "LED"),
                            }
                        }
                    }
                });
                db.Vehicles.Add(new Vehicle
                {
                    Manufacturer = db.Manufacturers.First(x => x.Name == "Acura"),
                    ProductionYear = db.ProductionYears.First(x => x.Name == "1999"),
                    Model = db.Models.First(x => x.Name == "TL"),
                    Trim = db.Trims.First(x => x.Name == "3.2 V6"),
                });
                db.Vehicles.Add(new Vehicle
                {
                    Manufacturer = db.Manufacturers.First(x => x.Name == "Volkswagen"),
                    ProductionYear = db.ProductionYears.First(x => x.Name == "2003"),
                    Model = db.Models.First(x => x.Name == "GTI"),
                    Trim = db.Trims.First(x => x.Name == "1.8T"),
                });
                db.SaveChanges();
            }
        }
    }
}
