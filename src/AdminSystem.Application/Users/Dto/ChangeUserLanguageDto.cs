using System.ComponentModel.DataAnnotations;

namespace AdminSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}