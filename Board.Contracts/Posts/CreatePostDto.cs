using Board.Contracts.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Contracts.Posts
{

    /// <summary>
    /// Модель создания объявления
    /// </summary>
    public class CreatePostDto  //: IValidatableObject
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [Required(ErrorMessage = "наименование не указано")]
        [StringLength(5, ErrorMessage = "превышена длинна наименования")]
        [NameValidation]
        public string Name { get; set;}

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set;}

        /// <summary>
        /// Теги
        /// </summary>
        [MaxLength(3)]
        public int[] Tag { get; set;}


        [Range(1, 9)]
        public int Number { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set;}


        /*

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> list = new List<ValidationResult>(); //создали пустой список
            if (string.IsNullOrWhiteSpace(Name))
            {
                list.Add(new ValidationResult("Наименование не указано"));
            }

            
            //проверка таймингов
            if (CreationDate > DateTime.Now)
            {
                list.Add(new ValidationResult("Дата создания не может быть больше текущей"));
            }

            return list;
        }
        */
    }
}
