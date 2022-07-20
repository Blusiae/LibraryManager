using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain
{
    public class BookEntity : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public int PublishYear { get; set; }

        [DefaultValue(false)]
        public bool IsBorrowed { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; } //Id of the book's author.

        [Required]
        public virtual AuthorEntity Author { get; set; } //Every book has an author.

        [NotMapped]
        public virtual IEnumerable<BorrowEntity> Borrows { get; set; } //Every borrow has a book.
    }
}
