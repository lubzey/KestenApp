﻿using KestenTestApp.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace KestenTestApp.Models
{
    public class Variety
    {
        public int VarietyId { get; set; }
        public string VarietyName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ConditionEnum? ChestnutBlightResistance { get; set; }
        public ConditionEnum? InkDiseaseResistance { get; set; }
        public ConditionEnum? Peeling { get; set; }
        public PollenTypeEnum? PollenFertility { get; set; }
        public MaturingPeriodEnum? MaturityPeriod { get; set; }
        public bool? IsMarron { get; set; }
        public DateTime CreatedOn { get; set; }

        //One-to-many
        public List<Species> Species { get; set; } = new List<Species>();
        public List<FruitSize> FruitSizes { get; set; } = new List<FruitSize>();

        //Many-to-many
        public List<VarietyPollenizerCompatibility> IsPollenizerFor { get; set; } = new List<VarietyPollenizerCompatibility>();
        public List<VarietyPollenizerCompatibility> IsPollenizedBy { get; set; } = new List<VarietyPollenizerCompatibility>();

        public List<VarietyGraftingCompatibility> IsGraftedOn { get; set; } = new List<VarietyGraftingCompatibility>();
        public List<VarietyGraftingCompatibility> IsRootstockFor { get; set; } = new List<VarietyGraftingCompatibility>();

        //Not mapped        
    }
}
