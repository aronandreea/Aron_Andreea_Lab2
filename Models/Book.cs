using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Aron_Andreea_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title {  get; set; }
        public int AuthorId { get; set; }   //cheie straina catre Author
        public Authors Author {  get; set; }    //proprietate de navigatie catre Authors

        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate {  get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
    } //navigation property

}

