
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using ModelingSubstances.Domain.Model;

namespace ModelingSubstances.DrivenAdapters.SqlServer
{
    public class SustanciaModelanteImpl
    {
        public bool Save(Transaccion transaccion)
        {
            bool rpta;
            try
            {
                var cn = new Connection();
                using (var conect = new SqlConnection(cn.getCadenaSql()))
                {
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("spSave", conect);
                    
                    cmd.Parameters.AddWithValue("Cantidad_aplicada", transaccion.CantidadAplicada);
                    cmd.Parameters.AddWithValue("Cantidad_vendida", transaccion.CantidadVendida);
                    cmd.Parameters.AddWithValue("Codigo_habilitacion_suministrador", transaccion.CodigoHabilitacionSuministrador);
                    cmd.Parameters.AddWithValue("Fecha_transaccion", transaccion.FechaTransaccion.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("Indicaciones_uso", transaccion.IndicacionesUso);
                    cmd.Parameters.AddWithValue("Nombre_razon_social_adquiriente", transaccion.NombreRazonSocialAdquiriente);
                    cmd.Parameters.AddWithValue("Nombre_razon_social_receptor", transaccion.NombreRazonSocialReceptor);
                    cmd.Parameters.AddWithValue("Nombre_razon_social_suministrador", transaccion.NombreRazonSocialSuministrador);
                    cmd.Parameters.AddWithValue("Numero_documento_adquiriente", transaccion.NumeroDocumentoAdquiriente);
                    cmd.Parameters.AddWithValue("Numero_documento_receptor", transaccion.NumeroDocumentoReceptor);
                    cmd.Parameters.AddWithValue("Numero_documento_suministrador", transaccion.NumeroDocumentoSuministrador);
                    cmd.Parameters.AddWithValue("Numero_factura", transaccion.NumeroFactura);
                    cmd.Parameters.AddWithValue("Numero_lote", transaccion.NumeroLote);
                    cmd.Parameters.AddWithValue("Tipo_documento_adquiriente", transaccion.TipoDocumentoAdquiriente);
                    cmd.Parameters.AddWithValue("Tipo_documento_receptor", transaccion.TipoDocumentoReceptor);
                    cmd.Parameters.AddWithValue("Tipo_documento_suministrador", transaccion.TipoDocumentoSuministrador);
                    cmd.Parameters.AddWithValue("Tipo_transaccion", transaccion.TipoTransaccion);
                    cmd.Parameters.AddWithValue("Tipo_usuario_adquiriente", transaccion.TipoUsuarioAdquiriente);
                    cmd.Parameters.AddWithValue("Tipo_usuario_receptor", transaccion.TipoUsuarioReceptor);
                    cmd.Parameters.AddWithValue("Tipo_usuario_suministrador", transaccion.TipoUsuarioSuministrador);
                    cmd.Parameters.AddWithValue("UsuarioReportante_id", transaccion.UsuarioReportante.id);
                    cmd.Parameters.AddWithValue("UsuarioReportante_tipo_usuario", transaccion.UsuarioReportante.tipoDocumento);
                    cmd.Parameters.AddWithValue("UsuarioReportante_nombre_razon_social", transaccion.UsuarioReportante.nombreRazonSocial);
                    cmd.Parameters.AddWithValue("UsuarioReportante_tipo_documento", transaccion.UsuarioReportante.tipoDocumento);
                    cmd.Parameters.AddWithValue("UsuarioReportante_numero_documento", transaccion.UsuarioReportante.numeroDocumento);
                    cmd.Parameters.AddWithValue("UsuarioReportante_rol_actor", transaccion.UsuarioReportante.rolActor);
                    cmd.Parameters.AddWithValue("UsuarioReportante_correo_electronico", transaccion.UsuarioReportante.correoElectronico);
                    cmd.Parameters.AddWithValue("UsuarioReportante_numero_radicado", transaccion.UsuarioReportante.numeroRadicado);
                    cmd.Parameters.AddWithValue("UsuarioReportante_fecha_registro", transaccion.UsuarioReportante.fechaRegistro.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("UsuarioReportante_direccion_residencia", transaccion.UsuarioReportante.direccionResidencia);
                    cmd.Parameters.AddWithValue("Pais_id", transaccion.UsuarioReportante.Pais.id);
                    cmd.Parameters.AddWithValue("Pais_Nombre", transaccion.UsuarioReportante.Pais.Nombre);
                    cmd.Parameters.AddWithValue("Departamento_id", transaccion.UsuarioReportante.Departamento.id);
                    cmd.Parameters.AddWithValue("Departamento_Nombre", transaccion.UsuarioReportante.Departamento.Nombre);
                    cmd.Parameters.AddWithValue("Ciudad_id", transaccion.UsuarioReportante.Ciudad.id);
                    cmd.Parameters.AddWithValue("Ciudad_Nombre", transaccion.UsuarioReportante.Ciudad.Nombre);
                    cmd.Parameters.AddWithValue("SustanciaModelante_id", transaccion.UsuarioReportante.SustanciaModelante.id);
                    cmd.Parameters.AddWithValue("SustanciaModelante_codigo", transaccion.UsuarioReportante.SustanciaModelante.Codigo);
                    cmd.Parameters.AddWithValue("SustanciaModelante_nombre_sustancia", transaccion.UsuarioReportante.SustanciaModelante.NombreSustancia);
                    cmd.Parameters.AddWithValue("SustanciaModelante_numero_registro_sanitario", transaccion.UsuarioReportante.SustanciaModelante.NumeroRegistroSanitario);
                    cmd.Parameters.AddWithValue("SustanciaModelante_sustancia", transaccion.UsuarioReportante.SustanciaModelante.Sustancia);
                    cmd.Parameters.AddWithValue("SustanciaModelante_uso_aprobado", transaccion.UsuarioReportante.SustanciaModelante.UsoAprobado);
                    cmd.Parameters.AddWithValue("SustanciaModelante_estado", transaccion.UsuarioReportante.SustanciaModelante.Estado);
                    cmd.Parameters.AddWithValue("SustanciaModelante_fecha_vencimiento", transaccion.UsuarioReportante.SustanciaModelante.FechaVencimiento.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("SustanciaModelante_referencia", transaccion.UsuarioReportante.SustanciaModelante.Referencia);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }
               rpta = true;
            }
            catch (Exception e) 
            {
                string error = e.Message;
                rpta = false;
            }
            return rpta;
        }
    }
}



