namespace mentoria_carrefour.Entidades
{
    public class Professor : Pessoa    
    {
        public string cargo { get; set; }

        public double salario { get; set; }

        public string funcao { get; set; }

              public Professor(string nome, int idade, string email, string sexo, string cargo, double salario) : base(nome, idade, email, sexo)
        {
            this.cargo = cargo;
            this.salario = salario;
            this.funcao = "Professor fixo";
        }
        public override string ToString() => "Professor(a):" + nome + "\n"
        + "Idade: " + idade + "\n"
        + "Ano Escolar: " +  "\n"
        + "Cargo: " + cargo+ "\n"
        + "Salário: " + salario + "\n"
        + "Função" + funcao;
    }
}