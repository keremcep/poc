using System.ComponentModel.DataAnnotations;

namespace poc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}