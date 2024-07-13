namespace ExemploMVC.Models;

public class UsuarioModel 
{ 
    public uint Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime DataNascimento { get; set; }
}