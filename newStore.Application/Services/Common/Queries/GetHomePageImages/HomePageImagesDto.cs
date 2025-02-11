using newStore.Domain.Entities.HomePages;

namespace newStore.Application.Services.Common.Queries.GetHomePageImages
{
    public class HomePageImagesDto
    {
        public long Id { get; set; }
        public string Src { get; set; }
        public string Link { get; set; }
        public ImageLocation ImageLocation { get; set; }
    }
}
