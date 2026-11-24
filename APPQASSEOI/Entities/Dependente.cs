using System;

namespace APPQASSEOI.Entities;

public class Dependente
{
    public string Nome { get; set; }
    public string NivelParentesco { get; set; }
    public double ValorSF { get; set; }

    public override string ToString()
    {
        string retorno = "Nome:                 " + Nome + "\n" +
                         "Nível de Parentesco:  " + NivelParentesco + "\n" +
                         "Valor SF:             " + ValorSF.ToString("f2");
        return retorno;
    }
}