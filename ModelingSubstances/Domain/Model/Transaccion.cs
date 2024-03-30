namespace ModelingSubstances.Domain.Model
{
    public class Transaccion
    {
        public int id { get; set; }
        public string CantidadAplicada { get; set; }
        public string CantidadVendida { get; set; }
        public string CodigoHabilitacionSuministrador { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string IndicacionesUso { get; set; }
        public string NombreRazonSocialAdquiriente { get; set; }
        public string NombreRazonSocialReceptor { get; set; }
        public string NombreRazonSocialSuministrador { get; set; }
        public int NumeroDocumentoAdquiriente { get; set; }
        public int NumeroDocumentoReceptor { get; set; }
        public int NumeroDocumentoSuministrador { get; set; }
        public string NumeroFactura { get; set; }
        public string NumeroLote { get; set; }
        public string TipoDocumentoAdquiriente { get; set; }
        public string TipoDocumentoReceptor { get; set; }
        public string TipoDocumentoSuministrador { get; set; }
        public string TipoTransaccion { get; set; }
        public string TipoUsuarioAdquiriente { get; set; }
        public string TipoUsuarioReceptor { get; set; }
        public string TipoUsuarioSuministrador { get; set; }
        public UsuarioReportante UsuarioReportante { get; set; }
        public Pais Pais { get; set; }
        public Departamento Departamento { get; set; }
        public Ciudad Ciudad { get; set; }
        public SustanciaModelante SustanciaModelante { get; set; }

    }
}
