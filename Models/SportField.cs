using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Models
{
    public enum SportFieldType { football, basketball, volleyball}
    public class SportFieldFeature
    {
        public bool Lighting { get; set; }
        public bool Cloakroom { get; set; }
        public bool ArtificalTurf { get; set; }
        public bool EquipmentRental { get; set; }
    }
    public class SportField
    {
        public SportFieldType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SportFieldFeature Features { get; set; }
        public string City{ get; set; }
        public string Street{ get; set; }
        public string Number { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
