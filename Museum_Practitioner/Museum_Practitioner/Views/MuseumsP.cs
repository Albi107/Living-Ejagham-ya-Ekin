using System;
using System.Collections.Generic;
using System.Text;

namespace Museum_Practitioner.Views
{
     public class MuseumsP
    {
        public class MuseumsPics
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }
        public class MuseumsService
        {
            public List<MuseumsPics> GetmuseumsList()
            {
                return new List<MuseumsPics>()
                {
                new MuseumsPics()
                {
                    Name = "Field Archaeology",
                    Image = "MP.png",
                    Description = "Salvaging the remains of dying Heritage"
                },
                new MuseumsPics ()
                {
                    Name = "Archaeology",
                    Image = "Museum.png",
                    Description = "Teaching students field archaelogy"
                },
                 new MuseumsPics ()
                {
                    Name = "Cross River Monolith",
                    Image = "WA0020.jpg",
                    Description = "The Cross River Monolith"
                }
                

            };
            }
        }
    
}
}
