using System;
using System.Collections.Generic;
using System.Text;

namespace Museum_Practitioner.Views
{
    public class GalleryP
    {
        public class GalleryPic
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }
        public class GalleryService
        {
            public List<GalleryPic> GetGalleriesList()
            {
                return new List<GalleryPic>()
                {
                new GalleryPic()
                {
                    Name = "Field Archaeology",
                    Image = "WA0028.jpg",
                    Description = "Salvaging the remains of dying Heritage"
                },
                new GalleryPic ()
                {
                    Name = "Archaeology",
                    Image = "WA0025.jpg",
                    Description = "Teaching students field archaelogy"
                },
                 new GalleryPic ()
                {
                    Name = "Cross River Monolith",
                    Image = "WA0026.jpg",
                    Description = "The Cross River Monolith"
                },
                 new GalleryPic ()
                {
                    Name = "Team of Researchers",
                    Image = "WA0024.jpg",
                    Description = "Restoring faith in the Cross River Monolith"
                },
                 new GalleryPic ()
                {
                    Name = "Cross River Monolith",
                    Image = "WA0021.jpg",
                    Description = "The Cross River Monolith"
                },
                  new GalleryPic ()
                {
                    Name = "Team of Researchers",
                    Image = "WA0005.jpg",
                    Description = "Restoring faith in the Cross River Monolith"
                },
                              new GalleryPic ()
                {
                    Name = "Field Archaeology training",
                    Image = "WA0015.jpg",
                    Description = "Lecturing Archaeology students at the Ahmadu Bello University"
                },
                              
                  new GalleryPic ()
                {
                    Name = "Team of Researchers",
                    Image = "WA0021.jpg",
                    Description = "Examining archaeological finds"
                },
                  
                  new GalleryPic ()
                {
                    Name = "Team of Researchers",
                    Image = "WA0014.jpg",
                    Description = "Dr. Edet & Dr. Abubakar"
                }

            };
            }
        }
    }
}

