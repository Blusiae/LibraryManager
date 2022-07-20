using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain
{
    public class AuthorEntity : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; }

        [NotMapped]
        public virtual IEnumerable<BookEntity> Books { get; set; } //Every book has an author.
    }
}
