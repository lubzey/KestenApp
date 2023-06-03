using System.ComponentModel.DataAnnotations;

namespace KestenTestApp.Models.Enums
{
    public enum SpeciesEnum
    {
        [Display(
            Name = "Castanea sativa", 
            Description = "European chestnut")]
        Sativa = 1,
        [Display(
            Name = "Castanea crenata",
            Description = "Japanese chestnut")]
        Crenata = 2,
        [Display(
            Name = "Castanea mollissima",
            Description = "Chinese chestnut")]
        Mollissima = 3,
        [Display(
            Name = "Castanea dentata",
            Description = "American chestnut")]
        Dentata = 4,
        [Display(
            Name = "Castanea pumila",
            Description = "Allegheny chinkapin")]
        Pumila = 5,
        [Display(
            Name = "Castanea ozarkensis",
            Description = "Ozark chinkapin")]
        Ozarkensis = 6,
        [Display(
            Name = "Castanea henryi",
            Description = "Chinese chinkapin")]
        Henryi = 7,
        [Display(
            Name = "Castanea seguinii",
            Description = "Seguin's chestnut")]
        Seguinii = 8
    }
}