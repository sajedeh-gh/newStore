namespace newStore.Application.Services.Users.Commands.EditProductForAdmin
{
    public class RequestEditProductForAdminDto
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public bool Displayed { get; set; }

        public long ProductsId { get; set; }
    }
}
