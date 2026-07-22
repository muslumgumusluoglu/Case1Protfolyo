using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "IMG URL Boş geçilemez")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Proje Adı Boş geçilemez")]
        [MinLength(3, ErrorMessage = "Proje adı en az 3 karekter olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proje Açıklaması Boş geçilemez")]
        [MaxLength(100, ErrorMessage = "Proje açıklması en fazla 100 karekter olabilir")]
        public string Description { get; set; }

        [Required(ErrorMessage = "GitHub URL Boş geçilemez")]
        public string GitHuburl { get; set; }

        public List<ProjectTechStack>? ProjectTechStacks { get; set; }

    }

}
