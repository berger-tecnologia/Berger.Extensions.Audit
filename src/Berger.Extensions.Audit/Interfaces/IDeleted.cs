namespace Berger.Extensions.Audit
{
    public interface IDeleted
    {
        public bool Deleted { get; }
        public DateTime? DeletedOn { get; }
    }
}