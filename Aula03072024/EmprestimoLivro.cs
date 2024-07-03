namespace Aula03072024
{
    public class EmprestimoLivro
    {
        public string UsuarioId { get; }
        public Livro Livro { get; }
        public DateTime DataEmprestimo { get; }

        public EmprestimoLivro(string usuarioId, Livro livro, DateTime dataEmprestimo)
        {
            UsuarioId = usuarioId;
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
        }
    }
}