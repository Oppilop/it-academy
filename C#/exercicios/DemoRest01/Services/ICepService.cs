using System.Collections.Generic;
using DemoRest01.Models;

namespace DemoRest01.Services
{
    public interface ICepService
    {
        IEnumerable<ConsultaCep> ConsultaTodos();
        ConsultaCep ConsultaPorCep(string cep);
        void FazAlgoRuim();
    }
}