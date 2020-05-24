using System.Collections.Generic;

namespace ExamenRest.Models
{
    public partial class CodigosPostales
    {

        public int IdPostal { get; set; }
        public string CodigoPostal { get; set; }
        public string AsentamientoPostal { get; set; }
        public string TipoAsentamientoPostal { get; set; }
        public string MunicipioPostal { get; set; }
        public string EstadoPostal { get; set; }
        public string CiudadPostal { get; set; }
        public string ZonaPostal { get; set; }
    }
    public class asentamientos
    {
        public string id { get; set; }
        public string Colonia { get; set; }
        public string TipoAsentamiento { get; set; }
        public string Zona { get; set; }

    }
    public class ResponseCodigo
    {

        public string CodigoPostal { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
        public List<asentamientos> asentamientos { get; set; }


    }
    public class Resp
    {

        public int IdPostal { get; set; }
        public string CodigoPostal { get; set; }
        public string AsentamientoPostal { get; set; }
        public string TipoAsentamientoPostal { get; set; }
        public string MunicipioPostal { get; set; }
        public string EstadoPostal { get; set; }
        public string CiudadPostal { get; set; }
        public string ZonaPostal { get; set; }

    }

    public class RequestCodigos
    {

        public string CodigoPostal { get; set; }
        public string AsentamientoPostal { get; set; }
        public string TipoAsentamientoPostal { get; set; }
        public string MunicipioPostal { get; set; }
        public string EstadoPostal { get; set; }
        public string CiudadPostal { get; set; }
        public string ZonaPostal { get; set; }

    }
}
