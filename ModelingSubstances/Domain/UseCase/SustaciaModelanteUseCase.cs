using ModelingSubstances.Domain.Model;
using System.Diagnostics;
using ModelingSubstances.DrivenAdapters.SqlServer;

namespace ModelingSubstances.Domain.UseCase
{
    public class SustaciaModelanteUseCase
    {
        SustanciaModelanteImpl sustanciaModelanteImpl = new SustanciaModelanteImpl();

        public bool Save(Transaccion transaccion)
        {
            bool rpta;

            rpta = sustanciaModelanteImpl.Save(transaccion);

            return rpta;
        }
    }
}
