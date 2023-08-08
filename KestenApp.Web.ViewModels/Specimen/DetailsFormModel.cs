namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Web.ViewModels.Garden;
    using System;

    public class DetailsFormModel
    {

        public DetailsFormModel(Guid gardenId, int row, int column)
        {
            GardenId = gardenId;
            Row = row;
            Column = column;
        }

        public Guid GardenId { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public GardenDetailsModel Garden { get; set; }
    }
}
