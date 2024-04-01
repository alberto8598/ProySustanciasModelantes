using Microsoft.AspNetCore.Mvc;
using Vehiculos.DrivenAdapters.SqlServer;
using Microsoft.EntityFrameworkCore;
using ModelingSubstances.Domain.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using ModelingSubstances.Domain.UseCase;
using ModelingSubstances.DrivenAdapters.SqlServer;

namespace ModelingSubstances.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SustanciaModelanteController : Controller
    {
        SustaciaModelanteUseCase sustaciaModelanteUseCase = new SustaciaModelanteUseCase();
        private readonly ModelingSubstancesDbContext _modelingSubstancesDbContext;
        
         public SustanciaModelanteController(ModelingSubstancesDbContext modelingSubstancesDbContext)
         {
            _modelingSubstancesDbContext = modelingSubstancesDbContext;
         }

        [HttpGet]
        public async Task<IActionResult> GetAllTransaction()
        {
            Transaccion transactionObj = new Transaccion();

            try
            {
                // Leer el contenido del archivo JSON
                string jsonFilePath = "C:\\Users\\Personal\\Downloads\\per\\msalud\\json\\json1.json";
                // Reemplaza esto con la ruta a tu archivo JSON

                string jsonString = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                // URL del endpoint proporcionado por la otra compañía
                //string url = "URL_DEL_ENDPOINT";

                // Hacer la solicitud GET al endpoint
                // HttpResponseMessage response = await _httpClient.GetAsync(url);

                // Verificar si la solicitud fue exitosa (código de estado 200)
                // if (response.IsSuccessStatusCode)
                //{
                // Leer la respuesta como una cadena de texto
                //string respuesta = await response.Content.ReadAsStringAsync();

                // Deserializar el JSON en una lista de objetos Cliente
                List<Transaccion> transactionList = JsonConvert.DeserializeObject<List<Transaccion>>(jsonString);
                //List<Transaccion> transactionList = JsonConvert.DeserializeObject<List<Transaccion>>(respuesta);

                // Luego, puedes actualizar tu tabla con la información obtenida

                foreach (Transaccion transaction in transactionList)
                {
                    transactionObj.UsuarioReportante = new UsuarioReportante();
                    transactionObj.Pais = new Pais();

                    // Aquí puedes hacer lo que necesites con cada cliente, como agregarlo a una tabla
                    // Acceder a las propiedades de usuario reportante
                    transactionObj.FechaTransaccion = transaction.FechaTransaccion;
                    transactionObj.TipoTransaccion = transaction.TipoTransaccion;
                    transactionObj.TipoUsuarioAdquiriente = transaction.TipoUsuarioAdquiriente;
                    transactionObj.NombreRazonSocialAdquiriente = transaction.NombreRazonSocialAdquiriente;
                    transactionObj.TipoDocumentoAdquiriente = transaction.TipoDocumentoAdquiriente;
                    transactionObj.NumeroDocumentoAdquiriente = transaction.NumeroDocumentoAdquiriente;
                    transactionObj.TipoUsuarioSuministrador = transaction.TipoUsuarioSuministrador;
                    transactionObj.NombreRazonSocialSuministrador = transaction.NombreRazonSocialSuministrador;
                    transactionObj.NumeroDocumentoSuministrador = transaction.NumeroDocumentoSuministrador;
                    transactionObj.CodigoHabilitacionSuministrador = transaction.CodigoHabilitacionSuministrador;
                    transactionObj.TipoUsuarioReceptor = transaction.TipoUsuarioReceptor;
                    transactionObj.NombreRazonSocialReceptor = transaction.NombreRazonSocialReceptor;
                    transactionObj.TipoDocumentoReceptor = transaction.TipoDocumentoReceptor;
                    transactionObj.TipoDocumentoSuministrador = transaction.TipoDocumentoSuministrador;
                    transactionObj.NumeroDocumentoReceptor = transaction.NumeroDocumentoReceptor;
                    transactionObj.NumeroFactura = transaction.NumeroFactura;
                    transactionObj.CantidadVendida = transaction.CantidadVendida;
                    transactionObj.CantidadAplicada = transaction.CantidadAplicada;
                    transactionObj.NumeroLote = transaction.NumeroLote;
                    transactionObj.IndicacionesUso = transaction.IndicacionesUso;
                    transactionObj.UsuarioReportante.id = transaction.UsuarioReportante.id;
                    transactionObj.UsuarioReportante.tipoUsuario = transaction.UsuarioReportante.tipoUsuario;
                    transactionObj.UsuarioReportante.nombreRazonSocial = transaction.UsuarioReportante.nombreRazonSocial;
                    transactionObj.UsuarioReportante.tipoDocumento = transaction.UsuarioReportante.tipoDocumento;
                    transactionObj.UsuarioReportante.numeroDocumento = transaction.UsuarioReportante.numeroDocumento;
                    transactionObj.UsuarioReportante.rolActor = transaction.UsuarioReportante.rolActor;
                    transactionObj.UsuarioReportante.correoElectronico = transaction.UsuarioReportante.correoElectronico;
                    transactionObj.UsuarioReportante.numeroRadicado = transaction.UsuarioReportante.numeroRadicado;
                    transactionObj.UsuarioReportante.fechaRegistro = transaction.UsuarioReportante.fechaRegistro;
                    transactionObj.UsuarioReportante.direccionResidencia = transaction.UsuarioReportante.direccionResidencia;
                    transactionObj.UsuarioReportante.Pais.id = transaction.UsuarioReportante.Pais.id;
                    transactionObj.UsuarioReportante.Pais.Nombre = transaction.UsuarioReportante.Pais.Nombre;
                    transactionObj.UsuarioReportante.Departamento.id = transaction.UsuarioReportante.Departamento.id;
                    transactionObj.UsuarioReportante.Departamento.Nombre = transaction.UsuarioReportante.Departamento.Nombre;
                    transactionObj.UsuarioReportante.Ciudad.id = transaction.UsuarioReportante.Ciudad.id;
                    transactionObj.UsuarioReportante.Ciudad.Nombre = transaction.UsuarioReportante.Ciudad.Nombre;
                    transactionObj.UsuarioReportante.SustanciaModelante.id = transaction.UsuarioReportante.SustanciaModelante.id;
                    transactionObj.UsuarioReportante.SustanciaModelante.Codigo = transaction.UsuarioReportante.SustanciaModelante.Codigo;
                    transactionObj.UsuarioReportante.SustanciaModelante.NombreSustancia = transaction.UsuarioReportante.SustanciaModelante.NombreSustancia;
                    transactionObj.UsuarioReportante.SustanciaModelante.NumeroRegistroSanitario = transaction.UsuarioReportante.SustanciaModelante.NumeroRegistroSanitario;
                    transactionObj.UsuarioReportante.SustanciaModelante.Sustancia = transaction.UsuarioReportante.SustanciaModelante.Sustancia;
                    transactionObj.UsuarioReportante.SustanciaModelante.UsoAprobado = transaction.UsuarioReportante.SustanciaModelante.UsoAprobado;
                    transactionObj.UsuarioReportante.SustanciaModelante.Estado = transaction.UsuarioReportante.SustanciaModelante.Estado;
                    transactionObj.UsuarioReportante.SustanciaModelante.FechaVencimiento = transaction.UsuarioReportante.SustanciaModelante.FechaVencimiento;
                    transactionObj.UsuarioReportante.SustanciaModelante.Referencia = transaction.UsuarioReportante.SustanciaModelante.Referencia;

                    var vehicleResponse = sustaciaModelanteUseCase.Save(transactionObj);

                }

                // Devolver una respuesta indicando el resultado de la operación
                return Ok("Tabla actualizada correctamente");
                //}
                //else
                //{
                // Manejar el caso en que la solicitud no fue exitosa
                //  return StatusCode((int)response.StatusCode, "Error al obtener la respuesta del servicio externo");
                //}

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                return StatusCode(500, $"Error: {ex.Message}");
            }

        }
    }
}
