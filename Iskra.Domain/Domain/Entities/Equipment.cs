namespace Iskra.Domain.Models
{
    public class Equipment : Entity<int>
    {
        public Equipment() { }
        public Equipment(int id) : base(id)
        {
        }

        public virtual string Title { get; set; }
        public virtual int Count { get; set; }
        public virtual bool IsArchival { get; set; }
    }
}
