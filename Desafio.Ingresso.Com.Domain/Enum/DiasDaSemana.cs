﻿using System.ComponentModel;

namespace Desafio.Ingresso.Com.Domain.Enum
{
    public enum DiasDaSemana : int
    {
        [Description("Domingo")]
        domingo = 1,
        [Description("Segunda")]
        segunda = 2,
        [Description("Terça")]
        terca = 3,
        [Description("Quarta")]
        quarta = 4,
        [Description("Quinta")]
        quinta = 5,
        [Description("Sexta")]
        sexta = 6,
        [Description("Sábado")]
        sabado = 7
    }
}
