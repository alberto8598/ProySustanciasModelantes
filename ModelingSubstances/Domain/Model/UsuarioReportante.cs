namespace ModelingSubstances.Domain.Model
{
    public class UsuarioReportante
    {
        public int id { get; set; }
        public string correoElectronico { get; set; }

        public string direccionResidencia { get; set; }

        public DateTime fechaRegistro { get; set; }

        public string nombreRazonSocial { get; set; }

        public string numeroDocumento { get; set; }

        public string numeroRadicado { get; set; }

        public string rolActor { get; set; }

        public string tipoDocumento { get; set; }

        public string tipoUsuario { get; set; }

        public Pais Pais { get; set; }

        public Departamento Departamento { get; set; }

        public Ciudad Ciudad { get; set; }

        public SustanciaModelante SustanciaModelante { get; set; }

        public UsuarioReportante()
        {
            Pais = new Pais();
            Departamento = new Departamento();
            Ciudad = new Ciudad();
            SustanciaModelante = new SustanciaModelante();
        }

    }
}
