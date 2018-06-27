using System.ComponentModel.DataAnnotations;

namespace RIMIKS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}