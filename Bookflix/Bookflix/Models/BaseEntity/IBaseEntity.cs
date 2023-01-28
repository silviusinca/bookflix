namespace Bookflix.Models.Base
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }
        DateTime? DateCreated { get; set; }
        DateTime? DateModified { get; set; }
    }

}
