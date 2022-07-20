using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain
{
    public class BorrowEntity : BaseEntity
    {

        [ForeignKey("Reader")]
        public int ReaderId { get; set; } //Id of the borrower of the book.

        [Required]
        public virtual ReaderEntity Reader { get; set; } //Every borrow has a reader (borrower).

        [ForeignKey("Book")]
        public int BookId { get; set; } //Id of the borrowed book.

        [Required]
        public virtual BookEntity Book { get; set; } //Every borrow has a book.

        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDeadline { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
