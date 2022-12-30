using System.ComponentModel.DataAnnotations;

namespace CrudContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "O email informado não e valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Phone(ErrorMessage = "O celular informado não e valido")]
        public string Celular { get; set; }

    }
}
