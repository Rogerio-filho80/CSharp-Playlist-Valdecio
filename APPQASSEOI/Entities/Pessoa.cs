using System;
using System.Collections.Generic;

namespace APPQASSEOI.Entities
{
    public class Pessoa
    {
        public string nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public int numero { get; set; }
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string telefone { get; set; } = string.Empty;
        public DateTime dataNascimento { get; set; }

        public List<Dependente> Dependentes { get; set; }

        public Pessoa()
        {
            Dependentes = new List<Dependente>();
        }

        public void AddDependente(Dependente d)
        {
            Dependentes.Add(d);
        }
        public void RemoveDependente(int index)
        {
            if (index >= 0 && index < Dependentes.Count)
            {
                Dependentes.RemoveAt(index);
            }
        }

        public override string ToString()
        {
            string retorno = "Nome               : " + nome + "\n" +
                             "Endereço           : " + Endereco + "\n" +
                             "Número             : " + numero + "\n" +
                             "Bairro             : " + Bairro + "\n" +
                             "Cidade             : " + Cidade + "\n" +
                             "Estado             : " + Estado + "\n" +
                             "CEP                : " + Cep + "\n" +
                             "Telefone           : " + telefone + "\n" +
                             "Data de Nascimento : " + dataNascimento.ToString("dd/MM/yyyy") + "\n" +
                             "-----------------------------------------------------\n" +
                             "Dependentes:\n" +
                             "-----------------------------------------------------\n";

            foreach (Dependente d in Dependentes)
            {
                // Correção aplicada aqui: uso de {d.Propriedade} e aspas no lugar certo
                retorno += $"Nome                : {d.Nome}\n" +
                           $"Nível de Parentesco : {d.NivelParentesco}\n" +
                           $"Valor SF            : {d.ValorSF:F2}\n" +
                           "----------------------------------------------------------\n";
            }

            return retorno;
        }
    }
}