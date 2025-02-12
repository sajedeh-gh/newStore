namespace newStore.Application.Services.Fainances.Queries.GetRequestPayForAdmin
{
    public class RequestPayDto
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
         public string UserName { get; set; }
         public long UserId { get; set; }
        public int Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? PayDate { get; set; }
        public string Authority { get; set; } 
        public long RefId { get; set; } = 0;
    }
}
