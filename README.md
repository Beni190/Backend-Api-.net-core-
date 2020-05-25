# Backend-Api-.net-core
Web api EntityFramework Core

https://examen-277900.wl.r.appspot.com/swagger/index.html

GET /api/CodigosPostales
RETURN todos los registros de la base de datos
[
  {
    "idPostal": 1,
    "codigoPostal": "10910",
    "asentamientoPostal": "La Magdalena",
    "tipoAsentamientoPostal": "Pueblo",
    "municipioPostal": "La Magdalena Contreras",
    "estadoPostal": "Ciudad de México",
    "ciudadPostal": "Ciudad de México",
    "zonaPostal": ""
  },
  {
    "idPostal": 2,
    "codigoPostal": "10920",
    "asentamientoPostal": "Las Huertas",
    "tipoAsentamientoPostal": "Colonia",
    "municipioPostal": "La Magdalena Contreras",
    "estadoPostal": "Ciudad de México",
    "ciudadPostal": "Ciudad de México",
    "zonaPostal": ""
  }
]

GET /api/CodigosPostales/{id}
RETURN
{
  "codigoPostal": "10640",
  "estado": "Ciudad de México",
  "ciudad": "Ciudad de México",
  "municipio": "La Magdalena Contreras",
  "asentamientos": [
    {
      "id": "1527",
      "colonia": "La Carbonera",
      "tipoAsentamiento": "Colonia",
      "zona": ""
    },
    {
      "id": "1528",
      "colonia": "Pueblo Nuevo Alto",
      "tipoAsentamiento": "Colonia",
      "zona": ""
    },
    {
      "id": "1529",
      "colonia": "Pueblo Nuevo Bajo",
      "tipoAsentamiento": "Colonia",
      "zona": ""
    }
  ]
}
